<script>
    import Icon from '@iconify/svelte';
    export let icon;
    export let name;
    export let href;
</script>

<a href="{href}" class="container">
    <Icon {icon} />
    <span class="name">{name}</span>
</a>

<style>
    .container{
        border-bottom: 2px solid #E8E8ED;
        font-size: 18px;
        gap:5px;
        padding: 4px 0;
        display: inline-flex;
        flex-direction: row;
        align-items: center;
        justify-content: center;
    }
    .container:hover{
        border-bottom: 1px solid #1D1D1F;
        cursor: pointer;
    }
    a{
        text-decoration: none;
        color: #1D1D1F;
    }
</style>