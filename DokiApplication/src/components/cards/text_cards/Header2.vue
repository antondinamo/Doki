<template>
  <div>
    <h2>
    </h2>
  </div>
</template>

<script>
import TextRender from '../../../services/TextRenderService.js'

export default {
  name: "Header2",
  components: {
    TextRender
  },
  props: {
    text: String,
    entities: Array
  }
};
</script>