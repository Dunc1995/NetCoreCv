import { Address } from "./address";
import { Responsibility } from "./responsibility";
import { Company } from "./company";

export class WorkExperience {
    id: number;
    addressId: number | null;
    companyId: number | null;
    jobTitle: string;
    startDate: string;
    endDate: string;
    startDateDisplay: string;
    endDateDisplay: string;
    address: Address | null;
    company: Company | null;
    responsibilities: Responsibility[] | null;
}