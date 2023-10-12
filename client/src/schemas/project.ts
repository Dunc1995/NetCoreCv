import { Address } from "./address";

export class Project {
    id: number;
    addressId: number | null;
    title: string;
    description: string;
    address: Address | null;
}