<script>
import Paragraph from './Paragraph.vue'
import Header1 from './Header1.vue'
import Header2 from './Header2.vue'
import Header3 from './Header3.vue'

export default {
  name: "TextCardBuilder",
  functional: true,

  render: function(createElement, context) {
    var card = context.props.card;
    context.props = {
      text: card.text.value,
      entities: card.text.entities
    }

    function selectedCard() {
      switch (card.textType) {
        case 0:
          return Paragraph;
        case 1:
          return Header1;
        case 2:
          return Header2;
        case 3:
          return Header3;
      }
    }

    return createElement(selectedCard(), context);
  }
};
</script>