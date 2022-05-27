<template>
    <div class="wrapper">
        <div class="container" data-color="light">
            <div class="user-select">
                <div class="row">
                    <p>ZALOGUJ SIĘ</p>
                </div>
            </div>
        </div>
        <div class="container" data-color="light">
            <form method="POST" @submit.prevent="submit">
                <div class="input-wrapper">
                    <div class="row">
                        <p>LOGIN</p>
                    </div>
                    <div class="row">
                        <input type="text" name="login" v-model="this.userCredentials.Name">
                    </div>
                    <div class="row">
                        <p>HASŁO</p>
                    </div>
                    <div class="row">
                        <input type="password" name="password" v-model="this.userCredentials.Password">
                    </div>
                    <div class="row">
                        <input type="submit" value="ZALOGUJ SIĘ">
                    </div>
                    <div class="row" @click="$store.dispatch('setRegisterForm')">
                        <p class="subtext">Nie masz konta? Zarejestruj się...</p>
                    </div>
                </div>
            </form>
        </div>
    </div>
</template>
<script>
import axios from 'axios'
export default {
    data(){
        return{
            userCredentials:{
                Name:'',
                Password:'',
                Email:'',
                Date:'',
            }
        }
    },
    methods:{
        submit(){
            let response = axios.post("https://localhost:44370/api/auth/login",this.userCredentials);
            console.log(response);
        }
    }
}
</script>
<style lang="css">

</style>