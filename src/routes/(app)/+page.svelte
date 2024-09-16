<script>
import TechnologyButton  from "../../TechnologyButton.svelte";
import profilePicture from '$lib/images/profile-image.jpg';
import { fade } from 'svelte/transition';
import {onMount} from "svelte";
import SocialsButton from "../../SocialsButton.svelte";
import Separator from "../../Separator.svelte";
let isVisible = false;


onMount(() =>{
    isVisible = true;
})
</script>
{#if isVisible}
<div class="pt-12 flex flex-col justify-center w-1/2 self-center" in:fade>

    <span class="text-3xl font-bold">Kamil Górny</span>
   <p>I’m a software engineer specializing in .NET and C#.</p>
    <div class="flex flex-row items-center gap-56">
    <div class="technologies">
        <div>Things I work with:
            <TechnologyButton name=".Net" icon="skill-icons:dotnet"/>
            <TechnologyButton name="C#" icon="devicon:csharp"/>
        </div>
        <div>Cloud expertise:
            <TechnologyButton name="Azure" icon="devicon:azure"/>
        </div>
        <div>Frontend:
            <TechnologyButton name="Svelte" icon="devicon:svelte"/>
            <TechnologyButton name="Flutter" icon="logos:flutter"/>
            <TechnologyButton name="Figma" icon="logos:figma"/>
        </div>
    </div>
    <img  src="{profilePicture}" alt="me" class="w-48 h-48 rounded-xl -rotate-3 border-blue-500 border-4 "/>
    </div>

<p class="pt-10">
       Outside of programming I have a strong passion for cybersecurity and actively participate in bug bounty programs during my free time.
    <br><br>My focus is on building secure and scalable systems that empower developers to create with confidence.
    <br><br>
       I’m currently based in Gdańsk, Poland.

   </p>

    <p>Find me on</p>
    <div class="flex gap-4 pb-5 pt-7">
        <SocialsButton name="Github" icon="mdi:github"/>
        <SocialsButton name="Hackerone" icon="cib:hackerone" href="https://hackerone.com/"/>
        <SocialsButton name="Twitter" icon="prime:twitter"/>
        <SocialsButton name="Linkedin" icon="mdi:linkedin"/>
        <SocialsButton name="Youtube" icon="mdi:youtube"/>
        <SocialsButton name="Youtube" icon="mdi:instagram"/>
    </div>

    <p>Or mail me at contact@kamilgorny.dev</p>

</div>
    {/if}

