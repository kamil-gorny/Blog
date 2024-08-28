<script>
    import {
        getAuth,
        signInWithPopup,
        GoogleAuthProvider,
    } from "firebase/auth";
    import FaGoogle from 'svelte-icons/fa/FaGoogle.svelte'
    import { onMount } from "svelte";

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

    async function loginWithGoogle() {
        const provider = new GoogleAuthProvider();
        const auth = getAuth();
        signInWithPopup(auth, provider)
            .then((result) => {
                const credential =
                    GoogleAuthProvider.credentialFromResult(result);
                const token = credential.accessToken;
                const user = result.user;
                console.log(user.email);
            })
            .catch((error) => {
                const errorCode = error.code;
                const errorMessage = error.message;
                const email = error.customData.email;

                const credential =
                    GoogleAuthProvider.credentialFromError(error);

            });
    }
</script>

<div class="container">
    <div class="container--left">

    </div>
    <div class="container--right">
        <div class="login-section">
            <div class="login-text">
                <span class="login-header">Create an account</span>
                <span class="login-subtext">Enter your email below to create your account</span>
            </div>
            <input type="email" placeholder="name@example.com">
            <div class="email-button">Sign in with Email</div>
            <div class="divider">
                <p class="divider-text">OR CONTINUE WITH</p>
            </div>
            <button class="github-button" on:click={loginWithGoogle}>
               <div class="icon"><FaGoogle/></div>Google</button>
            <p class="terms">By clicking continue, you agree to our <span class="underline">Terms<br/> of Service</span> and <span class="underline">Privacy Policy.</span></p>
        </div>
    </div>
</div>


<style>
    .divider-text{
        padding: 5px;
    }
 .divider {
    color: #71717E;
    font-size: 12px;
  display: flex;
  align-items: center;
  width: 350px;
}

.divider::before, .divider::after {
  flex: 1;
  content: '';
  padding: .5px;
  background-color: #E5E6E7;
  margin: 1px;
}
    .login-text{
        display: flex;
        flex-direction: column;
        align-items: center;
        gap:12px;
    }
    .underline{
        text-decoration: underline;
    }
    .icon{
        height: 16px;
        width: 16px;
    }
    input{
        outline: none;
        width: 344px;
        height: 30px;
        padding-left: 10px;
        border-radius: 5px;
        border:1px solid #E5E6E7;
    }
    .email-button{
        width: 350px;
        height: 36px;
        background-color: #000;
        color:#fff;
        text-align: center;
        line-height: 36px;
        border-radius: 5px;

    }
    .github-button{
        background-color: #fff;
        display: flex;
        width: 350px;
        height: 36px;
        border: 1px solid #E5E6E7;
        flex-direction: row;
        align-items: center;
        justify-content: center;
        gap:6px;
        width: 350px;
    }
    .github-button:hover{
        cursor: pointer;
    }
    .login-header{
        font-weight: 600;
        font-size: 24px;
    }
    .login-subtext{
        color: #71717E;
        font-size: 14px;
    }
    .container{
        font-family: 'Poppins', sans-serif;
        display: flex;
        flex-direction: row;
        height: 100vh;
    }
    .container--left{
        background-size: cover;
        background-image: url(https://images.unsplash.com/photo-1590069261209-f8e9b8642343?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1376&q=80);
        background-color: #71717E;
        width: 50vw;

    }
    .container--right{
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .login-section{
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        width: 50vw;
        gap:12px;
        height: 100vh;
    }
    .terms{
        text-align: center;
        color: #71717E;
    }

</style>