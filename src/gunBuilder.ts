import { IItem } from "@spt/models/eft/common/tables/IItem";
import * as ask74nDefaultJson from "../db/aks74nDefault.json";
import * as ak102DefaultJson from "../db/ak102Default.json";
import * as ak105DefaultJson from "../db/ak105Default.json";
import * as akmnDefaultJson from "../db/akmnDefault.json";
import * as krissVector9x19DefaultJson from "../db/krissVector9x19Default.json";
import * as hk416a5DefaultJson from "../db/hk416a5Default.json";
import * as asValDefaultJson from "../db/asValDefault.json";

export class GunBuilder
{
    public getAks74nDefault(): IItem[]
    {
        return ask74nDefaultJson.items as IItem[];
    }

    public getAk102Default(): IItem[]
    {
        return ak102DefaultJson.items as IItem[];
    }

    public getAk105Default(): IItem[]
    {
        return ak105DefaultJson.items as IItem[];
    }

    public getAkmnDefault(): IItem[]
    {
        return akmnDefaultJson.items as IItem[];
    }

    public getKrissVector19x9Default(): IItem[]
    {
        return krissVector9x19DefaultJson.items as IItem[];
    }

    public getHk416a5Default(): IItem[]
    {
        return hk416a5DefaultJson.items as IItem[];
    }

    public getAsValDefault(): IItem[]
    {
        return asValDefaultJson.items as IItem[];
    }
}
