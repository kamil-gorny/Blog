<script>
    import SocialsButton from "../../../SocialsButton.svelte";
    import Icon from "@iconify/svelte";
    import WorkExperienceTile from "../../../WorkExperienceTile.svelte";
</script>


    <div class="flex-row justify-between items-center w-1/2 mt-10">
        <div class="flex flex-row justify-between items-start">
            <h1 class="font-bold text-2xl mb-5">Kamil Górny</h1>
            <div class="flex flex-row items-center gap-4">
                <SocialsButton name="Github" icon="mdi:github"/>
                <SocialsButton name="Linkedin" icon="mdi:linkedin"/>

            </div>
        </div>
        <p class="flex flex-row items-center pt-3"><Icon icon="mdi:location"/> Gdańsk, Poland</p>
        <p>Software Engineer with passion for creating secure web apps </p>



        <h1 class="mt-10 font-bold text-2xl mb-7">Work experience</h1>

        <WorkExperienceTile company="Nsure" position="Software Engineer" timeframe="2021 - present" description=""/>

    </div>
