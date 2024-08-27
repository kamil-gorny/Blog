<script>
    import {
        getAuth,
        signInWithPopup,
        GoogleAuthProvider,
    } from "firebase/auth";
    import GoMarkGithub from 'svelte-icons/go/GoMarkGithub.svelte'

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

            <span class="login-header">Create an account</span>
            <span class="login-subtext">Enter your email below to create your account</span>

            <input type="email" placeholder="name@example.com">
            <div class="email-button">Sign in with Email</div>
            <p>OR CONTINUE WITH</p>
            <div class="github-button">
               <div class="icon"><GoMarkGithub/></div>Github</div>
            <p>By clicking continue, you agree to our Terms of Service and Privacy Policy.</p>
        </div>
    </div>
</div>


<style>
    .icon{
        height: 16px;
        width: 16px;
    }
    input{
        width: 344px;
        height: 30px;
        border-radius: 5px;
        border:1px solid #7E7E7E;
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
        width: 350px;
    }
    .login-header{
        font-weight: 600;
        font-size: 24px;
    }
    .login-subtext{
        color: #7E7E7E;
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
        background-color: #7E7E7E;
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
        height: 100vh;
    }

</style>