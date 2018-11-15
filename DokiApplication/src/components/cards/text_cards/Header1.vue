<template>
  <div>
    <h1>
      <TextRender :text="text" :entities="entities"/>
    </h1>
  </div>
</template>

<script>
import TextRender from '../../../services/TextRenderService.vue'

export default {
  name: "Header1",
  components: {
    TextRender
  },
  props: {
    text: String,
    entities: Array
  }
};
</script>
