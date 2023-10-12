import { Address } from "./address";
import { Responsibility } from "./responsibility";

export class WorkExperience {
    id: number;
    addressId: number | null;
    jobTitle: string;
    startDate: string;
    startDateDisplay: string;
    endDate: string;
    endDateDisplay: string;
    address: Address | null;
    responsibilities: Responsibility[] | null;
}