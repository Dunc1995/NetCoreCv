<script>
  import SideBarButton from "./SideBarButton.svelte";
</script>
<nav>
  <ul>
    <SideBarButton text="Curriculum Vitae">
      <i slot="icon" class="fa-solid fa-briefcase"></i>
    </SideBarButton>
    <SideBarButton text="Work Experience"/>
    <SideBarButton text="Projects"/>
    <SideBarButton text="Education"/>
  </ul>
</nav>
<button>
  Hide
</button>