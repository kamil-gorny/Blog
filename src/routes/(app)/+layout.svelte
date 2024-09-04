<script>
	import profilePicture from '$lib/images/profile.jpeg';
	import { Github } from 'lucide-svelte/icons';
	import { Send } from 'lucide-svelte';
</script>
<nav>
	<div class="navigation--left">
		<img class="profile-pic" src="{profilePicture}" alt="profile picture"/>
		<a href="/" class="logo">kamil-gorny</a>
	</div>

	<div class="navigation-items">
		<a href="/">Blog</a>
		<a href="/about">Projects</a>
		<a href="/contact">CV</a>
		<Github size="18"/>
		<Send size="18"/>
	</div>
</nav>

<main>
	<slot></slot>
</main>

<style>
	.navigation--left{
		display: flex;
		flex-direction: row;
		gap:10px;
	}
	.profile-pic{
		width: 32px;
		height: 32px;
		border-radius: 50%;
	}

	.icon {
		padding-top: 2px;
		width: 16px;
		height: 16px;
	}
	.logo {
		font-size: 1.125rem;
	}
	* {
		font-family: "Poppins", sans-serif;
	}
	nav {
		font-weight: 400;
		margin: 0 auto;
		padding: 20px;
		display: flex;
		flex-direction: row;
		justify-content: space-around;
	}
	.navigation-items {
		font-size: 16px;
		flex-direction: row;
		align-items: center;
		display: flex;
		gap: 36px;
		color: #374151;
		justify-content: space-between;
	}
	a {
		color: #374151;
		text-decoration: none;
		display: flex; /* CSS3 */
		align-items: center; /* Vertical align */
		justify-content: center; /* Horizontal align */
	}
</style>
