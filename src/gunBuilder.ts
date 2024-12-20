import { Item } from "@spt/models/eft/common/tables/IItem";
import * as ask74nDefaultJson from "../db/aks74nDefault.json";
import * as ak102DefaultJson from "../db/ak102Default.json";
import * as ak105DefaultJson from "../db/ak105Default.json";
import * as akmnDefaultJson from "../db/akmnDefault.json";
import * as krissVector9x19DefaultJson from "../db/krissVector9x19Default.json";
import * as hk416a5DefaultJson from "../db/hk416a5Default.json";
import * as asValDefaultJson from "../db/asValDefault.json";

export class GunBuilder
{
    public getAks74nDefault(): Item[]
    {
        return ask74nDefaultJson.items as Item[];
    }

    public getAk102Default(): Item[]
    {
        return ak102DefaultJson.items as Item[];
    }

    public getAk105Default(): Item[]
    {
        return ak105DefaultJson.items as Item[];
    }

    public getAkmnDefault(): Item[]
    {
        return akmnDefaultJson.items as Item[];
    }

    public getKrissVector19x9Default(): Item[]
    {
        return krissVector9x19DefaultJson.items as Item[];
    }

    public getHk416a5Default(): Item[]
    {
        return hk416a5DefaultJson.items as Item[];
    }

    public getAsValDefault(): Item[]
    {
        return asValDefaultJson.items as Item[];
    }
}
