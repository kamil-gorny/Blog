<script>
    import Icon from '@iconify/svelte';
    export let icon;
    export let name;
</script>

<div class="inline-flex gap-0.5 flex-row items-center justify-center bg-gray-100 rounded pl-1 pr-1">
    <Icon {icon}/>
    <span class="name">{name}</span>
</div>
