<script>
	import profilePicture from '$lib/images/profile.jpeg';
	import { Github } from 'lucide-svelte/icons';
	import { Send } from 'lucide-svelte';
</script>
<nav>
	<div class="navigation--left">
		<img src={profilePicture} alt="Profile picture" class="profile-pic"/>
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
		justify-self: start;
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
