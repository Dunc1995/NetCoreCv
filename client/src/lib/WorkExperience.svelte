<script lang='ts'>
    import { WorkExperience } from "../schemas/work-experience";
  
    const getWorkExperience = async () : Promise<WorkExperience[]> => {
      const response = await fetch("http://localhost:5187/api/WorkExperience");
      const content = await response.json();
  
      return content;
    }
</script>
{#await getWorkExperience() then experiences}
<div class="grid grid-flow-row auto-rows-max gap-4 p-5">
{#each experiences as { jobTitle, startDateDisplay, endDateDisplay, responsibilities }}
<div class="">
    <h2 class="font-medium">{jobTitle}</h2>
    <span class="italic">{startDateDisplay} - {endDateDisplay}</span>
    <div class="pl-3">
        <ul>
            {#each responsibilities as { description }}
            <li>{description}</li>
            {/each}
        </ul>
    </div>
</div>
{/each}
</div>
{/await}
  