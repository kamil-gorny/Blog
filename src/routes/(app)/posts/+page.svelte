<script>
    import {backOut, cubicOut, sineInOut} from "svelte/easing";
    import {fade} from "svelte/transition";
    import { onMount } from 'svelte';


    export let data;
    let visible = false;

    onMount(() => visible = true);
</script>

<main>

        <div class="latest-posts">
            <p class="latest-posts-header">Posts</p>
            <div class="post-list">
                {#each data.posts as {subtitle, title, link, date }, index}
                    {#if visible}
                    <div class="post" in:fade>
                        <div class="post-left-side">
                            <a href="/posts/{link}">{title}</a>
                            <br>
                            <span class="subtitle">{subtitle}</span>
                        </div>
                        <div class="post-right-side">
                            <span class="date">{date}</span>
                        </div>
                    </div>
                    {/if}
                {/each}
            </div>
        </div>

</main>

<style>
    .date {
        color: #1D1D1F;
    }
    main {
        width: 50%;
    }
    a {
        font-size: 18px;
        text-decoration: none;
        color: #3F3F46;
    }
    .subtitle {
        font-size: 16px;
        color: #6E6E73;
    }
    .post {
        padding-left: 20px;
        box-sizing: border-box;
        gap: 20px;
        display: flex;
        justify-content: space-between;
    }
    .post-left-side {
        display: flex;
        flex-direction: column;
    }
    .post-list {
        display: flex;
        flex-direction: column;
        gap: 30px;
    }
    .latest-posts {
        padding-top: 20px;
    }
    .latest-posts-header {
        color: #3F3F46;
        font-size: 32px;
        font-weight: bold;
    }
</style>
