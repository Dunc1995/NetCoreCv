<script lang="ts">
import {
    WorkExperience
} from "../schemas/work-experience";

export let experience : WorkExperience
const { jobTitle, company, address, startDateDisplay, endDateDisplay, responsibilities } = experience;
</script>

<div class="border-spacing-1">
    <h2 class="font-semibold">{jobTitle}</h2>
    <span class="font-medium">{company.name}</span><br>
    <div>
        <span class="font-light">{address.townOrCity}, {address.countryName}</span><br>
        <span class="italic font-light">{startDateDisplay} - {endDateDisplay}</span>
    </div>
    <div class="pl-3">
        <ul>
            <li>Testing 1, 2, 3</li>
            <!-- {#each responsibilities as { description }}
            <li>{description}</li>
            {/each} -->
        </ul>
    </div>
</div>

