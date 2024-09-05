<script>
    export let data;
    import { fly } from 'svelte/transition';
    let visible = false;

    import { onMount } from 'svelte';


    let ready = false;
    onMount(() => visible = true);

</script>

<main>

    {#if visible}
        <div class="latest-posts" in:fly={{ y: 200, duration: 2000 }}>
            <p class="latest-posts-header">
                Latest posts
            </p>
            {#each data.posts as { title, link, date }}
                <li>
                    <a href="/posts/{link}">{title}</a>
                    <span>{date}</span>
                </li>
                <hr>
            {/each}
        </div>
    {/if}

</main>

<style>

    li{
        font-size: 22px;
        list-style: none;
        display: flex;
        padding-top: 33px;
        justify-content: space-between;
    }
    li span{
        color: #7E7E7E;
    }
    li a{
        text-decoration: none;
        color: #000;
        padding-bottom: 35px;
    }
    img{
        max-height: 528px;
        max-width: 981px;
        border-radius: 10px;
        box-shadow: 0px 44px 34px 0px rgba(0, 0, 0, 0.25);

    }
    .hero{
        width: 981px;
        height: 528px;
        display: flex;
        margin-left: auto;
        margin-right: autos;
        align-content: center;

    }

    hr{
        color:#E4E4E4;
    }

    .header-main{
        font-size: 53px;
        font-weight: 600;
    }
    .header-sub{
        font-size: 28px;
        font-family: "Inter", sans-serif;
    }
    .latest-posts{
        padding-top:81px;

    }

    .latest-posts-header{
        font-size: 32px;
        padding-bottom: 37px;

    }
    .header-container{
        text-align: center;
        padding-top:72px;
        padding-bottom: 81px;
        display: flex;
        flex-direction: column;
        gap:12px;
    }

</style>