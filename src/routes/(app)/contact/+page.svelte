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
    <span class="font-bold text-4xl pb-9 text-prime">Contact me</span>
    <span>If you’d like to talk to me about anything, feel free to reach out.</span>
    <div class="flex flex-row gap-5">
        <Input label="Name" name="name" placeholder="Name"/>
        <Input label="Email" name="email" placeholder="name@email.com"/>

    </div>
    <label class="mt-1" for="message">Message</label>
    <textarea class="p-2.5 h-36 rounded border-gray-200 border-2" name="message" placeholder="Message"></textarea>
    <div class="flex w-24 h-11 self-end items-center justify-center bg-indigo-500 text-gray-200 gap-1 rounded"><Send size="18"/>Send</div>
</div>
{/if}

