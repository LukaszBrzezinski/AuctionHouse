<template>
    <div class="wrapper">
        <div class="container" data-color="light">
            <div class="user-select">
                <div class="row">
                    <p>ZAREJESTRUJ SIĘ</p>
                </div>
            </div>
        </div>
        <div class="container" data-color="light">
            <form method="POST">
                <div class="input-wrapper form">
                    <div class="left">
                        <div class="row">
                            <p>ADRES E-MAIL</p>
                        </div>
                        <div class="row">
                            <input type="text" name="mail" v-model="this.userCredentials.Email">
                        </div>
                        <div class="row">
                            <p>LOGIN</p>
                        </div>
                        <div class="row">
                            <input type="text" name="login" v-model="this.userCredentials.Name">
                        </div>
                        <div class="row">
                            <p>DATA URODZENIA</p>
                        </div>
                        <div class="row">
                            <input type="date" name="data" v-model="this.userCredentials.Date">
                        </div>
                        <div class="row" @click="$store.dispatch('setLoginForm')">
                            <p class="subtext">Masz już konto? Zaloguj się....</p>
                        </div>
                    </div>
                    <div class="right">
                        <div class="row">
                            <p>HASŁO</p>
                        </div>
                        <div class="row">
                            <input type="password" name="password" v-model="this.userCredentials.Password">
                        </div>
                        <div class="row">
                            <p>PODAJ HASŁO PORAZ DRUGI</p>
                        </div>
                        <div class="row">
                            <input type="password" name="password2">
                        </div>
                        <div class="row">
                            <input type="submit" value="ZAREJESTRUJ SIĘ" @submit.prevent="submit">
                        </div>
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
            let response = axios.post("https://localhost:44370/api/auth/register",this.userCredentials);
            console.log(response);
        }
    }
}
</script>
<style lang="css">

</style>