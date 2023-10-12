import { Education} from "./education";
import { Project } from "./project";
import { WorkExperience } from "./work-experience";

export class Address {
    id: number;
    firstLine: string;
    secondLine: string;
    county: string;
    postCode: string;
    isCurrent: boolean;
    projects: Project[] | null;
    workExperiences: WorkExperience[] | null;
    education: Education[] | null;
}