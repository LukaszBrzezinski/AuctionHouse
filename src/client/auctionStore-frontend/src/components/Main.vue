<template>
    <main>
        <TitlePage v-if="$store.getters.getIsTitlePage"/>
        <AddNewOffert v-if="$store.getters.getIsAddNewOffert"/>
        <Login v-if="$store.getters.getIsLoginForm"/>
        <Register v-if="$store.getters.getIsRegisterForm"/>
        <Favourite v-if="$store.getters.getIsFavourite"/>
        <Account v-if="$store.getters.getIsAccountPage"/>
    </main>
</template>
<script>
import TitlePage from "./main/TitlePage.vue"
import AddNewOffert from "./main/AddNewOffert.vue"
import Login from "./forms/Login.vue"
import Register from './forms/Register.vue'
import Favourite from "./main/Favourite.vue"
import Account from "./main/Account.vue"

export default {
    components:{
        TitlePage,
        AddNewOffert,
        Login,
        Register,
        Favourite,
        Account,
    },
}
</script>
<style>
</style>