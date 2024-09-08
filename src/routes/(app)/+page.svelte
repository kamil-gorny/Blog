<script>
import TechnologyButton  from "../../TechnologyButton.svelte";
import { fade } from 'svelte/transition';
import {onMount} from "svelte";
let isVisible = false;

onMount(() =>{
    isVisible = true;
})
</script>
{#if isVisible}
<div class="container" in:fade>
    <span class="header">Kamil Górny</span>
   <p>I’m a software engineer specializing in .NET and C#.</p>
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
<p>
       Outside of programming I have a strong passion for cybersecurity and actively participate in bug bounty programs during my free time. My focus is on building secure and scalable systems that empower developers to create with confidence.

       I’m currently based in Gdańsk, Poland.

   </p>
    <p>Find me on</p>


    Or mail me at contact@kamilgorny.dev
</div>
    {/if}

<style>
    .technologies{
        display: flex;
        flex-direction: column;
        gap: 5px;
    }
    .header{
        font-size: 32px;
        font-weight: 700;
    }
    .container{
        padding-top: 50px;
        color: #1D1D1F;
        justify-content: center;
        align-self: center;
        flex-direction: column;
        display: flex;
        width: 50%;
    }

</style>
