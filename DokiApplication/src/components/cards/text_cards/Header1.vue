<template>
  <div>
    <h1 v-html="htmlText">
    </h1>
  </div>
</template>

<script>
import TextRender from '../../../services/TextRenderService.js'

export default {
  name: "Header1",
  components: {
    TextRender
  },
  props: {
    text: String,
    entities: Array
  },
  computed: {
    htmlText: function() {
      return TextRender.render(this.text, this.entities);  
    }
  }
};
</script>
