<script>
import TextCardBuilder from './text_cards/TextCardBuilder.vue';
import ListCard from './ListCard.vue';

export default {
  name: "CardBuilder",
  functional: true,
  components: {
    TextCardBuilder,
    ListCard
  },

  render: function(createElement, context) {
    var card = context.props.card;
    
    function selectedCard() {
      // выбор карты
      switch (card.cardType) {
        case 0:
          return TextCardBuilder;
        case 1:
          return ListCard;
        default:
          alert( 'Я таких значений не знаю' );
          return TextCardBuilder;
      }
    }

    return createElement(selectedCard(), context)
  }
};
</script>