<script lang='ts'>
  import { WorkExperience } from "../schemas/work-experience";

  const getContent = async () : Promise<WorkExperience> => {
    const response = await fetch("http://localhost:5187/api/WorkExperience/Get/1");
    const content = await response.json();

    return content;
  }
</script>
{#await getContent() then workExperience}
  <ul>
    <li>{workExperience.id}</li>
    <li>{workExperience.jobTitle}</li>
    <li>{workExperience.startDate}</li>
    <li>{workExperience.endDate}</li>
  </ul>
{/await}
