<script>
    import Icon from "@iconify/svelte";

    export let data;
</script>
<div class="w-1/2 ml-auto mr-auto">
<div class="flex flex-col pt-24 pb-12 w-4/5 justify-start">
    <p class="text-gray-500">{data.date}</p>
    <h1 class="text-2xl font-bold m-0 p-0">{data.title}</h1>
    <div class="pt-3 flex h-4 justify-start gap-2">
        <div class="text-gray-500">
            <Icon icon="ic:baseline-facebook" width="1.4em" height="1.4em"  style="color: #1d1d1f"/>
        </div>
        <div class="icon">
            <Icon icon="mdi:twitter" width="1.4em" height="1.4em"  style="color: #1d1d1f" />
        </div>
        <div class="icon">
            <Icon icon="material-symbols:share" width="1.4em" height="1.4em"  style="color: #1d1d1f" />
        </div>


    </div>
</div>

    <div class="content">
        {@html data.content}
    </div>
</div>
