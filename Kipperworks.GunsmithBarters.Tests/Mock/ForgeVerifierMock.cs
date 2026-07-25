using Verifier;
using Verifier.Checks;
using Verifier.Extraction;
using Verifier.Output;

namespace Kipperworks.GunsmithBarters.Tests.Mock;

internal class ForgeVerifierMock
{
    public const string ARCHIVE_EXTRACTION_CHECK_NAME = "archive_extraction";
    public static ForgeVerifierMockRun RunVerifierProgram(VerifierOptions options)
    {
        if (!File.Exists(options.InputFile))
        {
            throw new FileNotFoundException($"Input file not found at {options.InputFile}");
        }

        string sha256 = FileHasher.Sha256(options.InputFile);

        Directory.CreateDirectory(options.ExtractDir);

        string? extractionError = ArchiveExtractor.ValidateAndExtract(options);
        if (extractionError is not null)
        {
            return new ForgeVerifierMockRun(sha256, null, [CheckResult.Failed(ARCHIVE_EXTRACTION_CHECK_NAME, extractionError)]);
        }

        ScanResult scan = PostExtractionScanner.Scan(options);
        if (scan.Error is not null)
        {
            return new ForgeVerifierMockRun(sha256, null, [CheckResult.Failed(ARCHIVE_EXTRACTION_CHECK_NAME, scan.Error)]);
        }

        ArchiveInfo archive = new(scan.FileTree, scan.Truncated, scan.SymlinksRemoved);
        List<CheckResult> checks = [CheckResult.Passed(ARCHIVE_EXTRACTION_CHECK_NAME)];
        checks.AddRange(CheckRegistry.RunAll(new CheckContext(options.ExtractDir, scan.FileTree, options.ArchiveSize, options.ModVersion, options.ModGuid)));
        return new ForgeVerifierMockRun(sha256, archive, checks);
    }
}

internal class ForgeVerifierMockRun
{
    public string? Sha256 { get; set; }
    public ArchiveInfo? Archive { get; set; }
    public List<CheckResult> Checks { get; set; } = new();
    public ForgeVerifierMockRun(string? sha256, ArchiveInfo? archive, List<CheckResult> checks)
    {
        Sha256 = sha256;
        Archive = archive;
        Checks = checks;
    }
}
