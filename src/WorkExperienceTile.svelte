<script>
    export let company;
    export let position;
    export let timeframe;
    export let description;
</script>

<div class="rounded overflow-hidden border shadow">
    <div class="px-1.5 py-4">
        <div class="flex flex-row justify-between">
            <div>
                <div class="font-bold text-xl">{company}</div>
                <div class="">{position}</div>
            </div>
            <p>{timeframe}</p>
        </div>
        <p class="text-gray-700 text-base">
            {description}
        </p>
    </div>

</div>