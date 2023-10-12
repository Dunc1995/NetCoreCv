<script lang='ts'>
  import { WorkExperience } from "../schemas/work-experience";

  const getContent = async () : Promise<WorkExperience> => {
    const response = await fetch("http://localhost:5187/api/WorkExperience/Get/1");
    const content = await response.json();

    return content;
  }
</script>
{#await getContent() then { jobTitle, startDateDisplay, endDateDisplay, responsibilities }}
  <div>
    <strong>{jobTitle}</strong>
    <br>
    <span>{startDateDisplay} - {endDateDisplay}</span>
    <ul>
      {#each responsibilities as responsibility}
        <li>{responsibility.description}</li>
      {/each}
    </ul>
  </div>
{/await}
