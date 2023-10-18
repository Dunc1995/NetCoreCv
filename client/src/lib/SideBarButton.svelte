<script>
    export let text;
</script>

<li class="items-center p-3">
    <a href="#" class="block text-sm font-medium text-gray-600 dark:text-gray-400 w-3/4 m-auto">
        <slot name="icon"></slot> {text}
    </a>
</li>
