<script>
    import Icon from '@iconify/svelte';
    export let icon;
    export let name;
</script>

<div class="container">
    <Icon {icon}/>
    <span class="name">{name}</span>
</div>

<style>
    .container{
        gap:0.25rem;
        padding: 4px 6px;
        display: inline-flex;
        flex-direction: row;
        align-items: center;
        justify-content: center;
        background-color: #88888822;
        color: #888888;
        border-radius: .25rem;
    }

</style>