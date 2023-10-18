<script>
  import SideBar from './lib/SideBar.svelte';
  import WorkExperience from './lib/WorkExperience.svelte';
  import Card from './lib/Card.svelte';
    import Picture from './lib/Picture.svelte';
</script>

<main>
  <div class="grid grid-cols-1 md:grid-cols-6 gap-4">
    <div class="md:col-span-1">
      <Picture/>
      <SideBar/>
    </div>
    <div class="bg-green-500 md:col-span-5">
      02
    </div>
  </div>
</main>