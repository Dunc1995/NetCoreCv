<script>
    export let title;
</script>

<div class="w-full m-5">
    <h2 class="text-gray-800 dark:text-gray-200 p-2 font-medium">{title}</h2>
    <div class="text-sm font-medium text-gray-600 dark:text-gray-400">
        <slot/>
    </div>
</div>