<script>
    import {Facebook} from "lucide-svelte";
    import Icon from "@iconify/svelte";

    export let data;
</script>
<div class="container">
<div class="post-header">
    <p class="post-header-date">{data.date}</p>
    <h1 class="text-2xl font-bold">{data.title}</h1>
    <div class="socials">
        <div class="icon">
            <Icon icon="ic:baseline-facebook" width="1.8em" height="1.8em"  style="color: #1d1d1f"/>
        </div>
        <div class="icon">
            <Icon icon="mdi:twitter" width="1.8em" height="1.8em"  style="color: #1d1d1f" />
        </div>
        <div class="icon">
            <Icon icon="material-symbols:share" width="2em" height="2em"  style="color: #1d1d1f" />
        </div>


    </div>
</div>

    <div class="content">
        {@html data.content}
    </div>
</div>

<style>
    .post-header-date{
        color:#7A7A7E;
    }
    .icon{
        color:#7E7E7E;
    }
    .container{
        width: 50%;
        margin-left: auto;
        margin-right: auto;
    }
    .socials{
        padding-top: 11px;
        display: flex;
        height: 16px;
        justify-content: start;
        gap: 8px;
    }
    .post-header{
        padding-bottom: 50px;
        padding-top: 100px;
        width:80%;
        display: flex;
        flex-direction: column;
        justify-content: start;
    }
    h1{
        padding: 0;
        margin: 0;
    }
</style>