<script>
    import {fade} from "svelte/transition";
    import { onMount } from 'svelte';
    export let data;
    let visible = false;

    onMount(() => visible = true);
</script>

<div class="w-1/2">
        <div class="pt-5">
            <p class="text-prime font-semibold text-3xl pb-6">Posts</p>
            <div class="flex flex-col gap-7">
                {#each data.posts as {subtitle, title, link, date }, index}
                    {#if visible}
                    <div class="flex justify-between gap-5 pl-5" in:fade>
                        <div class="flex flex-col">
                            <a class="no-underline text-sm" href="/posts/{link}">{title}</a>
                            <br>
                            <span class="text-gray-500">{subtitle}</span>
                        </div>
                        <span class="text-gray-500">{date}</span>
                    </div>
                    {/if}
                {/each}
            </div>
        </div>
</div>

