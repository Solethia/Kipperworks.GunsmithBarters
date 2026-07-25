using FluentAssertions;
using Kipperworks.GunsmithBarters.Tests.Mock;
using System.IO.Compression;
using Verifier;

namespace Kipperworks.GunsmithBarters.Tests;

public class ForgeVerificationTests
{
    private static string GetTempExtractDir() => Path.Combine(Path.GetTempPath(), "mod_extract");

    [Fact]
    public void LocalMod_PassesExactForgeVerificationLogic()
    {
        var modMetadata = new ModMetadata();
        var assembly = typeof(ModMetadata).Assembly;

        var assemblyDir = Path.GetDirectoryName(assembly.Location) ?? throw new InvalidOperationException("Could not resolve assembly location");
        var assemblyName = assembly.GetName().Name ?? throw new InvalidOperationException("Could not resolve assembly name");
        var zipFilePath = CreateMockReleaseZip(assemblyDir, assemblyName, modMetadata.Version.ToString());

        // Ensure MSBuild generated the ZIP
        File.Exists(zipFilePath).Should().BeTrue(
            $"Mod ZIP archive missing at '{zipFilePath}'. Make sure MSBuild ran 'CreateReleaseZip'."
        );

        var modZipFile = new FileInfo(zipFilePath);
        string extractDir = Path.Combine(Path.GetTempPath(), "mod_extract_" + Guid.NewGuid());

        try
        {
            var options = new VerifierOptions(
                InputFile: modZipFile.FullName,
                Extension: "zip",
                ArchiveSize: modZipFile.Length,
                MaxRatio: 100,
                MaxExtractedSize: 500_000_000,
                MaxFileTreeEntries: 1000,
                ModVersion: modMetadata.Version.ToString(),
                ModGuid: modMetadata.ModGuid,
                ExtractDir: extractDir
            );

            var result = ForgeVerifierMock.RunVerifierProgram(options);

            var failedChecks = result.Checks.Where(c => c.Status != "passed").ToList();

            // If failedChecks is not empty, FluentAssertions prints the full object representation for every failed check
            failedChecks.Should().BeEmpty("all verification checks should pass");
        }
        finally
        {
            if (Directory.Exists(extractDir))
                Directory.Delete(extractDir, true);
        }
    }

    private static string CreateMockReleaseZip(string assemblyDir, string assemblyName, string version)
    {
        string tempRoot = Path.Combine(Path.GetTempPath(), "zip_staging_" + Guid.NewGuid());

        // Replicate your exact MSBuild target folder hierarchy: SPT\user\mods\<AssemblyName>
        string stagingModDir = Path.Combine(tempRoot, "SPT", "user", "mods", assemblyName);
        Directory.CreateDirectory(stagingModDir);

        // Copy built output files into staging
        foreach (string filePath in Directory.GetFiles(assemblyDir))
        {
            string fileName = Path.GetFileName(filePath);
            if (!fileName.EndsWith(".zip"))
            {
                File.Copy(filePath, Path.Combine(stagingModDir, fileName), overwrite: true);
            }
        }

        // Zip the staging folder
        string zipOutputPath = Path.Combine(Path.GetTempPath(), $"{assemblyName}-v{version}.zip");
        if (File.Exists(zipOutputPath))
            File.Delete(zipOutputPath);

        ZipFile.CreateFromDirectory(tempRoot, zipOutputPath);
        Directory.Delete(tempRoot, true);

        return zipOutputPath;
    }
}
