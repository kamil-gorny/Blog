
<nav>
	<a href="/" class="logo">kamilgorny.dev</a>
	<div class="navigation-items">
		<a href="/">Home</a>
		<a href="/about">About</a>
		<a href="/contact">Contact</a>
	</div>
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
