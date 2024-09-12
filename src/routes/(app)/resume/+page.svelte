<script>
    import SocialsButton from "../../../SocialsButton.svelte";
    import Icon from "@iconify/svelte";
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



        <h1 class="mt-10 font-bold text-2xl">Work experience</h1>

        <div class="rounded overflow-hidden border shadow">
            <div class="px-1.5 py-4">
                <div class="font-bold text-xl mb-2">Nsure - Tech lead</div>
                <p class="text-gray-700 text-base">
                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus quia, nulla! Maiores et perferendis eaque, exercitationem praesentium nihil.
                </p>
            </div>

        </div>

    </div>
