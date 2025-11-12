<script>
        import { navigating } from "$app/stores";
	import "../../app.css";
	import NProgress from 'nprogress';
	import Icon from "@iconify/svelte";

    export const prerender = true;
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
			<Icon icon="mingcute:github-line" width="1.4em" height="1.4em"  style="color: #1d1d1f" />
		</a>
	</div>
</nav>

<main class="flex justify-center">
	<slot></slot>
</main>
<footer class="mt-12 flex justify-center items-center p-8">
	<p>Copyright © 2024 Kamil Górny. All Rights Reserved</p>
</footer>

