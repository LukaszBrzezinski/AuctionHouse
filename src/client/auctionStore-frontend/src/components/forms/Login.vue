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
            <form method="POST">
                <div class="input-wrapper">
                    <div class="row">
                        <p>LOGIN</p>
                    </div>
                    <div class="row">
                        <input type="text" name="login">
                    </div>
                    <div class="row">
                        <p>HASŁO</p>
                    </div>
                    <div class="row">
                        <input type="password" name="password">
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
export default {
    
}
</script>
<style lang="css">

</style>