<template>
  <div>
    <h2>
      <TextRender :text="text" :entities="entities"/>
    </h2>
  </div>
</template>

<script>
import TextRender from '../../../services/TextRenderService.vue'

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