<script>
	import mainImage from '$lib/images/mainimage.jpg';
</script>


<!-- <img src="{digital}" alt=""/> -->

<main>
	<div class="header-container">
		<span class="header-main">Hi, I am Kamil.</span>
		<span class="header-sub">Web developer and cybersec enthusiast.</span>	
	</div>	
	<img class="hero" src="{mainImage}" alt="">
</main>

<style>
	.hero{
		width: 981px;
		height: 528px;
	}
	main{
		text-align: center;
	}
	.header-main{
		font-size: 53px;
		font-weight: 600;
	}
	.header-sub{
		font-size: 28px;
		font-family: "Inter", sans-serif;
	}
	.header-container{
		padding-top:72px;
		padding-bottom: 81px;
		display: flex;
		flex-direction: column;
		gap:12px;
	}
</style>