<template>
  <!--<div id="input" ref="input" v-on:keyup="keyInput" v-on:click="onClick" tabindex="0" v-html="message"></div>-->
  <div 
    ref="input" 
    contenteditable="true" 
    v-text="message">
  </div>
</template>

<script>
import TextRender from "../services/TextRenderService.js";

export default {
  name: "TextEditor",
  components: {
    TextRender
  },
  props: {
    text: Object
  },
  data: function() {
    return {
      message: 'abc',
      position: Number
    }
  }
}
</script>
<style scoped>
</style>
