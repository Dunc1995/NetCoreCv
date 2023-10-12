<script>
    import { onMount } from "svelte";

    // Initialization for ES Users
    import {
      Sidenav,
      Ripple,
      initTE,
    } from "tw-elements";
    import Picture from "./Picture.svelte";

    onMount(() => {
        initTE({ Sidenav, Ripple });  
    })
</script>

<!-- Sidenav -->
<nav
  id="sidenav-8"
  class="absolute left-0 top-0 z-[1035] h-full w-60 -translate-x-full overflow-hidden bg-white shadow-[0_4px_12px_0_rgba(0,0,0,0.07),_0_2px_4px_rgba(0,0,0,0.05)] data-[te-sidenav-hidden='false']:translate-x-0 dark:bg-zinc-800"
  data-te-sidenav-init
  data-te-sidenav-hidden="false"
  data-te-sidenav-position="absolute"
  data-te-sidenav-accordion="true">
  <Picture/>
  <ul
    class="relative m-0 list-none px-[0.2rem] pb-12"
    data-te-sidenav-menu-ref>
    <li class="relative">
      <a
        class="flex cursor-pointer items-center truncate rounded-[5px] px-6 py-[0.45rem] text-[0.85rem] text-gray-600 outline-none transition duration-300 ease-linear hover:bg-slate-50 hover:text-inherit hover:outline-none focus:bg-slate-50 focus:text-inherit focus:outline-none active:bg-slate-50 active:text-inherit active:outline-none data-[te-sidenav-state-active]:text-inherit data-[te-sidenav-state-focus]:outline-none motion-reduce:transition-none dark:text-gray-300 dark:hover:bg-white/10 dark:focus:bg-white/10 dark:active:bg-white/10"
        data-te-sidenav-link-ref>
        <span
          class="mr-4 [&>svg]:h-3.5 [&>svg]:w-3.5 [&>svg]:text-gray-400 dark:[&>svg]:text-gray-300">
        </span>
        <span>Overview</span>
      </a>
    </li>
    <li class="relative pt-4">
      <span
        class="px-6 py-4 text-[0.6rem] font-bold uppercase text-gray-600 dark:text-gray-400"
        >Work Experience</span
      >
      <a
        class="flex cursor-pointer items-center truncate rounded-[5px] px-6 py-[0.45rem] text-[0.85rem] text-gray-600 outline-none transition duration-300 ease-linear hover:bg-slate-50 hover:text-inherit hover:outline-none focus:bg-slate-50 focus:text-inherit focus:outline-none active:bg-slate-50 active:text-inherit active:outline-none data-[te-sidenav-state-active]:text-inherit data-[te-sidenav-state-focus]:outline-none motion-reduce:transition-none dark:text-gray-300 dark:hover:bg-white/10 dark:focus:bg-white/10 dark:active:bg-white/10"
        data-te-sidenav-link-ref>
        <span
          class="mr-4 [&>svg]:h-5 [&>svg]:w-5 [&>svg]:text-gray-400 dark:[&>svg]:text-gray-300">
        </span>
        <span>Example</span>
      </a>
    </li>
  </ul>
</nav>
<!-- Sidenav -->