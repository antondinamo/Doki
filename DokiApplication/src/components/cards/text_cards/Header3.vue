<template>
  <div>
    <h3>
    </h3>
  </div>
</template>

<script>
import TextRender from '../../../services/TextRenderService.js'

export default {
  name: "Header3",
  components: {
    TextRender
  },
  props: {
    text: String,
    entities: Array
  }
};
</script>