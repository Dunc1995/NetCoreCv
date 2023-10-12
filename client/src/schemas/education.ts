import { Address } from "./address";

export class Education {
    id: number;
    addressId: number | null;
    title: string;
    grade: string;
    startDate: string;
    endDate: string;
    address: Address | null;
}