<script>
    import Icon from '@iconify/svelte';
    export let icon;
    export let name;
    export let href;
</script>

<a href="{href}" class=" hover:border-b-gray-400 hover:cursor-pointer inline-flex justify-center items-center border-b-gray-200 gap-1 text-lg border-b border-gray-200 hover:border-gray-600">
    <Icon {icon} />
    <span class="name">{name}</span>
</a>

<style>

    a{
        text-decoration: none;
        color: #1D1D1F;
    }
</style>