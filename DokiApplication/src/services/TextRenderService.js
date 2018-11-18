export default {
  name: "TextRenderService",
  functional: true,

  render: function(textValue = "", textEntities = []) {
    Int8Array.prototype.sum = function(start = 0, stop = this.length) {
      let sum = 0;
      for (var i = start; i < stop; i++) {
        sum += this[i];
      }
      return sum;
    };
    String.prototype.insert = function(string, position) {
      return this.substring(0, position) + string + this.substring(position);
    };

    return renderText(textValue, textEntities);

    function renderText(text = "", entities = []) {
      let summator = new Int8Array(text.length);

      entities.forEach(entity => {
        let tags = selectTags(entity);

        let openPos = entity.position + summator.sum(0, entity.position + 1);
        text = text.insert(tags.open, openPos);
        summator[entity.position] += tags.open.length;

        // let closePos = entity.position + entity.length + summator.sum(0, entity.position + entity.length - 1);
        // ниже тоже самое, только чуть-чуть оптимизировано
        let closePos =
          openPos +
          tags.open.length +
          summator.sum(entity.position + 1, entity.position + entity.length) +
          entity.length;
        text = text.insert(tags.close, closePos);
        summator[entity.position + entity.length] += tags.close.length;
      });

      return text;
    }

    function selectTags(entity) {
      switch (entity.type) {
        case 0:
          return {
            open: "<strong>",
            close: "</strong>"
          };
        case 1:
          return {
            open: "<em>",
            close: "</em>"
          };
        case 2:
          return {
            open: "<ins>",
            close: "</ins>"
          };
        case 3:
          return {
            open: "<del>",
            close: "</del>"
          };
        default:
          throw new Error("unknown entity type");
      }
    }
  }
};
