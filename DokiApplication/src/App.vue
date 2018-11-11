<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png">
    <HelloWorld msg="Hello world"/>
    <Page/>
  </div>
</template>

<script>
import HelloWorld from "./components/HelloWorld.vue";
import Page from "./components/Page.vue";

export default {
  name: "app",
  components: {
    HelloWorld,
    Page
  }
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
