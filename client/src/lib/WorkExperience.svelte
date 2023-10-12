<script lang='ts'>
    import { WorkExperience } from "../schemas/work-experience";
  
    const getWorkExperience = async () : Promise<WorkExperience[]> => {
      const response = await fetch("http://localhost:5187/api/WorkExperience");
      const content = await response.json();
  
      return content;
    }
</script>
{#await getWorkExperience() then experiences}
{#each experiences as { jobTitle, startDateDisplay, endDateDisplay, responsibilities }}
<div>
    <strong>{jobTitle}</strong>
    <br>
    <span>{startDateDisplay} - {endDateDisplay}</span>
    <ul>
        {#each responsibilities as { description }}
        <li>{description}</li>
        {/each}
    </ul>
</div>
{/each}
{/await}
  