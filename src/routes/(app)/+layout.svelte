<script>
	//import "../../app.css";
	import { onMount } from "svelte";
	import GoSearch from "svelte-icons/go/GoSearch.svelte";
	import { initializeApp } from "firebase/app";
	import { getAnalytics } from "firebase/analytics";
	onMount(() => {
		const firebaseConfig = {
			apiKey: "AIzaSyANk7hiz2HRx8_7EN_PWFp9tZQSkoZ5NYw",
			authDomain: "blog-74819.firebaseapp.com",
			projectId: "blog-74819",
			storageBucket: "blog-74819.appspot.com",
			messagingSenderId: "796437908916",
			appId: "1:796437908916:web:36ba6d508a3ce9450736e1",
			measurementId: "G-350TBFQTSX",
		};
		const app = initializeApp(firebaseConfig);
		const analytics = getAnalytics(app);
	});
</script>

<nav>
	<a href="/" class="logo">kamilgorny.dev</a>
	<div class="navigation-items">
		<a href="/">Home</a>
		<a href="/about">About</a>
		<a href="/contact">Contact</a>
	</div>
	<a href="/signup" class="search">Sign up</a>
</nav>

<main>
	<slot></slot>
</main>

<style>
	.search {
		display: flex;
		justify-content: space-between;
		gap: 4px;
		font-size: 18px;
	}
	.icon {
		padding-top: 2px;
		width: 18px;
		height: 18px;
	}
	.logo {
		font-weight: bold;
		font-size: 25px;
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
		font-size: 18px;
		flex-direction: row;
		display: flex;
		gap: 36px;
		justify-content: space-between;
	}
	a {
		color: black;
		text-decoration: none;
		display: flex; /* CSS3 */
		align-items: center; /* Vertical align */
		justify-content: center; /* Horizontal align */
	}
</style>
