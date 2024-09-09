<script>
    import SocialsButton from "../../../SocialsButton.svelte";
</script>

<div class="container">
    <div class="name-header">
        <h1 class="header">Kamil Górny</h1>
        <div class="socials">
        <SocialsButton name="Github" icon="mdi:github" href="https://github.com/kamil-gorny"/>
        <SocialsButton name="Linkedin" icon="mdi:linkedin" href="https://github.com/kamil-gorny"/>
        </div>
    </div>
    <p>I’m a software engineer specializing in .NET and C#.

        Things I work with:
        .Net

        C#
        Cloud expertise:
        Azure
        Frontend:
        Svelte

        Flutter

        Figma
        Outside of programming I have a strong passion for cybersecurity and actively participate in bug bounty programs during my free time.

        My focus is on building secure and scalable systems that empower developers to create with confidence.

        I’m currently based in Gdańsk, Poland.</p>
</div>

<style>
    .container{
        width: 50%;
    }
    .name-header{
        display: flex;
        flex-display: row;
        justify-content: space-between;
        align-items: center;
    }
</style>