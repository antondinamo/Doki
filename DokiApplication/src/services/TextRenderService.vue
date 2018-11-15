<script>
export default {
  name: "TextRenderService",
  functional: true,

  render: function(createElement, context) {
    var text = context.props.text;
    var entities = context.props.entities;

    /*
    entities.forEach(entity => {
      var entityText = text.
      textElements.push(renderEntity(entity));
    });
    */
    return createElement('span', text);

    function renderEntity(entity, text) {
      var element = '';
      switch (entity.type) {
        case 0:
          element = 'strong';
          break;
        case 1:
          element = 'em';
          break;
        case 2:
          element = 'ins';
          break;
        case 2:
          element = 'del';
          break;
      }
      return createElement(element, text)
    }
  }
};
</script>