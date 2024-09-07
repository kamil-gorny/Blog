<script>
    import Icon from '@iconify/svelte';
    export let icon;
    export let name;
</script>

<div class="test">
    <Icon {icon}/>
    <p>{name}</p>
</div>

<style>
    .test{
        display: inline-flex;
        flex-direction: row;
        align-items: center;
        justify-content: center;
        background-color: #eee;
        border-radius: 5px;



    }
</style>