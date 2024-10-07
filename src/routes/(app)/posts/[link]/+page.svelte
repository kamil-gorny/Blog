<script>

    import { marked } from 'marked';
    export let data;
</script>
<div class="container">
<div class="post-header">
 <!--   <p class="post-header-date">{data.post.date}</p>
    <h1>{data.post.title}</h1>-->
    <div class="socials">
        <!--<div class="icon">
            <FaFacebook/>
        </div>
        <div class="icon">
            <FaTwitter/>
        </div>
        <div class="icon">
            <FaLink />
        </div>-->


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