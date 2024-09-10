<script>
    export let label;
    export let name;
    export let placeholder;
    export let type = "text";
</script>
<div class="flex w-1/2 flex-col gap-1">
    <label for="{name}">{label}</label>
    <input class="p-2.5 rounded-md border-2 border-gray-200" name="{name}" {type} {placeholder}>
</div>

