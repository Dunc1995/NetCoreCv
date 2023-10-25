<script lang="ts">
  import SideBar from './lib/SideBar.svelte';
  import WorkExperience from './lib/WorkExperience.svelte';
  import Picture from './lib/Picture.svelte';
  import CvSection from './lib/CvSection.svelte';
  import {
    CurriculumVitae
} from "./schemas/curriculum-vitae";

const getCurriculumVitae = async (): Promise <CurriculumVitae> => {
  const response = await fetch("http://localhost:5187/api/CurriculumVitae/Get/1");
  const content = await response.json();

  return content;
}
</script>

<main>
  <div class="grid grid-cols-1 md:grid-cols-6 gap-4">
    <div class="md:col-span-1">
      <Picture/>
      <SideBar/>
    </div>

{#await getCurriculumVitae() then cv}
    <div class="md:col-span-5 md:border-l-2 md:border-solid md:border-gray-100">
      <CvSection title="Education">
        Hello World
      </CvSection>
      <CvSection title="Work Experience">
        <div class="grid grid-flow-row auto-rows-max gap-4 p-5">
          {#each cv.workExperience as experience}
          <WorkExperience {experience}/>
          {/each}
        </div>
      </CvSection>
      <CvSection title="Projects">
        Hello World
      </CvSection>
    </div>
{/await}
  </div>
</main>