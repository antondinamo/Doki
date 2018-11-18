<template>
  <div id="input" ref="input" v-on:keyup="keyInput" v-on:click="onClick" tabindex="0">{{message}}<strong>{{message}}</strong>{{message}}</div>
</template>

<script>
import TextRender from "../services/TextRenderService.js";

export default {
  name: "TextEditor",
  components: {
    TextRender
  },
  props: {
    text: Object
  },
  data: function() {
    return {
      message: "abc"
    }
  },
  methods: {
    keyInput: function(event) {
      if (event) event.preventDefault();
      let code = event.keyCode;
      if ((code >= 48 && code <= 90)
        || (code >= 96 && code <= 110)
        || (code == 32)) {
        this.message += event.key;
        console.log({key: event.key});
      }
    },
    onClick: function(event) {
      this.$refs.input.focus();
      
      var selection = window.getSelection(),
        range = selection.getRangeAt(0);
        //console.log(selection, range);
      
      let pos = getCurrentCursorPosition('input');
      console.log(pos);
      
      function isChildOf(node, parentId) {
        while (node !== null) {
            if (node.id === parentId) {
                return true;
            }
            node = node.parentNode;
        }
      }
      
      function getCurrentCursorPosition(parentId) {
        var selection = window.getSelection(),
            charCount = -1,
            node;

        if (selection.focusNode) {
            if (isChildOf(selection.focusNode, parentId)) {
                node = selection.focusNode; 
                charCount = selection.focusOffset;

                while (node) {
                    if (node.id === parentId) {
                        break;
                    }

                    if (node.previousSibling) {
                        node = node.previousSibling;
                        charCount += node.textContent.length;
                    } else {
                        node = node.parentNode;
                        if (node === null) {
                            break
                        }
                    }
              }
          }
        }

        return charCount;
      }
    }
  }
}
</script>
<style scoped>

</style>
