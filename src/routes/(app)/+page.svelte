<script>
	export let data;
	import IoIosArrowBack from 'svelte-icons/io/IoIosArrowBack.svelte'
	import FaRegCopyright from 'svelte-icons/fa/FaRegCopyright.svelte'
	import mainImage from '$lib/images/mainimage.jpg';

	import { onMount } from 'svelte';
	import { authStore } from '../../stores/authStore.js';

	let ready = false;
	onMount(() => ready = true);
	function typewriter(node, { speed = 1 }) {
	const valid = node.childNodes.length === 1 && node.childNodes[0].nodeType === Node.TEXT_NODE;

	if (!valid) {
		throw new Error(`This transition only works on elements with a single text node child`);
	}

	const text = node.textContent;
	const duration = text.length / (speed * 0.01);

	return {
		duration,
		tick: (t) => {
			const i = Math.trunc(text.length * t);
			node.textContent = text.slice(0, i);
		}
	};
}
</script>

<main>
	
	<div class="header-container">
		{#if ready}
		<span transition:typewriter class="header-main">Hi, I am Kamil.</span>
		<span transition:typewriter class="header-sub">Web developer and cybersec enthusiast.</span>	
		{/if}
	</div>	

	<div class="hero">
		<img src="{mainImage}" alt="">
	</div>{console.log($authStore.isLoggedIn)}

	<div class="latest-posts">
		<p class="latest-posts-header">
			Latest posts
		</p>
		{#each data.posts as { title, content, date }}
		<li>
			<a href="/blog/{title}">{title}</a>
			<span>{date}</span>
		</li>
		<hr>
		{/each}
	</div>
	<div class="older">
		<div class="icon"><IoIosArrowBack/></div>
		
		<p>View Older Posts</p>
		</div>
</main>
<footer>
	<div class="footer-icon">
		<FaRegCopyright />
	</div>
</footer>
<style>
	footer{
		text-align: center;
		justify-content: center;
		margin: auto;
	}
	.footer-icon{
		height: 17px;
		width: 17px;
	}
	.icon{
		align-self: center;
		height: 22px;
		padding-right: 12px;
		width: 22px;
	}
	.older{
		padding-top: 39px;
		display: flex;
		flex-direction: row;
		font-size: 22px;
		color: #7E7E7E;
	}
	li{
		font-size: 22px;
		list-style: none;
		display: flex;
		padding-top: 33px;
		justify-content: space-between;
	}
	li span{
		color: #7E7E7E;
	}
	li a{
		text-decoration: none;
		color: #000;
		padding-bottom: 35px;
	}
	img{
		max-height: 528px;
		max-width: 981px;
		border-radius: 10px;
		box-shadow: 0px 44px 34px 0px rgba(0, 0, 0, 0.25);
		
	}
	.hero{
		width: 981px;
		height: 528px;
		display: flex;
		margin-left: auto;
		margin-right: autos;
		align-content: center;

	}
	main{

		margin:auto;
		width: 60%;
	}
	hr{
		color:#E4E4E4;
	}

	.header-main{
		font-size: 53px;
		font-weight: 600;
	}
	.header-sub{
		font-size: 28px;
		font-family: "Inter", sans-serif;
	}
	.latest-posts{
		padding-top:81px;
		
	}

	.latest-posts-header{
		font-size: 32px;
		padding-bottom: 37px;
		
	}
	.header-container{
		text-align: center;
		padding-top:72px;
		padding-bottom: 81px;
		display: flex;
		flex-direction: column;
		gap:12px;
	}
	
</style>