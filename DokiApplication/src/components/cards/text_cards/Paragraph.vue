<template>
  <div>
    <p>
      <TextRender :text="text" :entities="entities"/>
    </p>
  </div>
</template>

<script>
import TextRender from '../../../services/TextRenderService.vue'

export default {
  name: "Paragraph",
  components: {
    TextRender
  },
  props: {
    text: String,
    entities: Array
  }
};
</script>