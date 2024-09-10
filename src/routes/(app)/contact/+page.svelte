<script>
    import { Send } from 'lucide-svelte';
    import { onMount } from 'svelte';
    import {  fade } from 'svelte/transition';
    import Input from "../../../Input.svelte";
    let isVisble = false;

    onMount(() => isVisble = true);

</script>

{#if isVisble}
<div class="flex flex-col justify-center self-center gap-2.5 pt-12 w-1/2" in:fade>
    <span class="header">Contact me</span>
    <span>If you’d like to talk to me about anything, feel free to reach out.</span>
    <div class="upper-section">
        <Input label="Name" name="name" placeholder="Name"/>
        <Input label="Email" name="email" placeholder="name@email.com"/>

    </div>
    <label class="text-area-label" for="message">Message</label>
    <textarea class="message" name="message" placeholder="Message"></textarea>
    <div class="send-button"><Send size="18"/>Send</div>
</div>
{/if}

<style>
    .header{
        color: #424245;
        font-weight: bold;
        font-size: 36px;
        padding-bottom: 36px;

    }
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




    .upper-section{
        display: flex;
        flex-direction: row;
        gap: 20px;
    }

</style>