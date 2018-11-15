<template>
  <div>
    <h3>
      <TextRender :text="text" :entities="entities"/>
    </h3>
  </div>
</template>

<script>
import TextRender from '../../../services/TextRenderService.vue'

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