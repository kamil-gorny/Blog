<script>
    import { Send } from 'lucide-svelte';
    import { onMount } from 'svelte';
    import {  fade } from 'svelte/transition';
    let isVisble = false;

    onMount(() => isVisble = true);

</script>

{#if isVisble}
<div class="container" in:fade>
    <span class="header">Contact me</span>
    <span>If you’d like to talk to me about anything, feel free to reach out.</span>
    <div class="upper-section">
        <div class="contact-input">
            <label for="name">Name</label>
            <input name="name" type="text" placeholder="Your name">
        </div>
        <div class="contact-input">
            <label for="email">Email</label>
            <input name="email" type="email" placeholder="name@email.com">
        </div>
    </div>
    <label class="text-area-label" for="message">Message</label>
    <textarea class="message" name="message" placeholder="Message"></textarea>
    <div class="send-button"><Send size="18"/>Send</div>
</div>
{/if}

<style>
    .send-button{
        width: 105px;
        height: 44px;
        border-radius: 8px;
        align-self: end;
        display: flex;
        align-items: center;
        justify-content: center;
        gap: 5px;
        color: #F5F5F5;
        background-color: #29d;
    }
    .message{
        box-sizing: border-box;
        padding:10px;
    }

    .text-area-label{
        margin-top:5px;
    }
    label{
        font-weight: 500;
    }
    textarea{
        height: 150px;
        border: 1px solid #E8E8ED;
    }
    .contact-input{
        gap:5px;
        width: 50%;
        display: flex;
        flex-direction: column;
    }

    .contact-input > input{
        padding: 10px;
        border-radius: 5px;
        border: 1px solid #E8E8ED;
    }

    .header{
        color: #424245;
        font-weight: bold;
        font-size: 36px;
        padding-bottom: 36px;

    }
    .upper-section{
        display: flex;
        flex-direction: row;
        gap: 20px;
    }
    .container{
        padding-top: 50px;
        color: #1D1D1F;
        justify-content: center;
        align-self: center;
        flex-direction: column;
        display: flex;
        gap:10px;
        width: 50%;
    }
</style>