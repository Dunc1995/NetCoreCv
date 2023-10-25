import { Address } from "./address";
import { Education } from "./education";
import { WorkExperience } from "./work-experience";
import { Project } from "./project";

export class CurriculumVitae {
    id: number;
    curriculumVitaeId: number;
    userName: string;
    emailAddress: string;
    currentAddressId: number | null;
    currentAddress: Address | null;
    education: Education[];
    workExperience: WorkExperience[];
    projects: Project[];
}