<script>
import TechnologyButton  from "../../TechnologyButton.svelte";
import { fade } from 'svelte/transition';
import {onMount} from "svelte";
import SocialsButton from "../../SocialsButton.svelte";
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
    <hr>
<p>
       Outside of programming I have a strong passion for cybersecurity and actively participate in bug bounty programs during my free time.
    <br><br>My focus is on building secure and scalable systems that empower developers to create with confidence.
    <br><br>
       I’m currently based in Gdańsk, Poland.

   </p>
    <hr>
    <p>Find me on</p>
    <div class="socials">
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

<style>
    hr{
        width: 50px;
        margin-top: 20px;
        border: 0.5px solid #E8E8ED;
    }
    .socials{
        display: flex;
        gap: 15px;
        padding-bottom: 20px;
    }
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
        font-family: "Poppins", sans-serif;
        padding-top: 50px;
        color: #555555;
        font-size: 16px;
        justify-content: center;
        align-self: center;
        flex-direction: column;
        display: flex;
        width: 50%;
    }

</style>
