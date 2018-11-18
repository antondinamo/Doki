<template>
  <div>
    <p>{{htmlText}}</p>
    <p v-html="htmlText" />
  </div>
</template>

<script>
import TextRender from '../../../services/TextRenderService.js'

export default {
  name: "Paragraph",
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