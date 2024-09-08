<script>
	import profilePicture from '$lib/images/profile.jpeg';
	import { Github } from 'lucide-svelte/icons';
	import { Send } from 'lucide-svelte';
	import { navigating } from "$app/stores";

	import NProgress from 'nprogress';


	NProgress.configure({ showSpinner: false });
	$: {
		if ($navigating) {
			NProgress.start();
		} else NProgress.done();
	}
</script>
<nav>
	<div class="navigation--left">
		<a href="/">
		<img src={profilePicture} alt="me" class="profile-pic"/>
		</a>
	</div>
	<div class="navigation-items">
		<a href="/posts">Blog</a>
		<a href="/about">Projects</a>
		<a href="/resume" >Resume</a>
		<a href="https://github.com/kamil-gorny">
		<Github size="18"/>
		</a>
		<a href="/contact">
			<Send size="18" />
		</a>
	</div>
</nav>

<main>
	<slot></slot>
</main>
<footer>
	<p>Copyright © 2024 Kamil Górny. All Rights Reserved</p>
</footer>
<style>
	footer{
		font-size: 14px;
		margin-top: 50px;
		display: flex;
		justify-content: center;
		align-items: center;
		padding: 30px;
	}
	main{
		display: flex;
		justify-content: center;
	}
	.navigation--left{
		display: flex;
		flex-direction: row;
		justify-self: start;
		gap:10px;
	}
	.profile-pic{
		width: 32px;
		height: 32px;
		border-radius: 50%;
	}


	* {
		font-family: "Poppins", sans-serif;
	}
	nav {
		font-weight: 400;
		padding: 20px;
		width: 75%;
		flex-direction: row;
		align-items: center;
		display: flex;
		margin-left: auto;
		margin-right: auto;
		justify-content: space-around;

	}
	.navigation-items {
		display: flex;
		flex-direction: row;
		gap: 36px;
		color: #6E6E73;
		font-size: 16px;
	}

	.navigation-items > a {
		transition: color 0.3s ease; /* You can adjust the duration and easing */
	}

	.navigation-items > a:hover{
		color:#1D1D1F;
	}

	.navigation-items > a{
		color:#6E6E73;
	}
	a {
		color: #6E6E73;
		text-decoration: none;
		display: flex; /* CSS3 */
		align-items: center; /* Vertical align */
		justify-content: center; /* Horizontal align */
	}
</style>
