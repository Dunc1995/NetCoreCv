import { Address } from "./address";
import { Responsibility } from "./responsibility";

export class WorkExperience {
    id: number;
    addressId: number | null;
    jobTitle: string;
    startDate: string;
    endDate: string;
    address: Address | null;
    responsibilities: Responsibility[] | null;
}