<script>
	import profilePicture from '$lib/images/profile.jpeg';
	import { Github } from 'lucide-svelte/icons';
	import { Send } from 'lucide-svelte';
	import { navigating } from "$app/stores";
	import "$lib/app.css";
	import NProgress from 'nprogress';


	NProgress.configure({ showSpinner: false });
	$: {
		if ($navigating) {
			NProgress.start();
		} else NProgress.done();
	}
</script>
<nav class="w-3/4 flex p-5 flex-row justify-around items-center ml-auto mr-auto">
	<div class="flex flex-row justify-self-start gap-2.5">

	</div>
	<div class="flex flex-row gap-9">
		<a href="/">~/</a>
		<a href="/posts">Blog</a>
		<a href="https://github.com/kamil-gorny">
		<Github size="18"/>
		</a>
		<a href="/contact">
			<Send size="18" />
		</a>
	</div>
</nav>

<main class="flex justify-center">
	<slot></slot>
</main>
<footer class="mt-12 flex justify-center items-center p-8">
	<p>Copyright © 2024 Kamil Górny. All Rights Reserved</p>
</footer>

