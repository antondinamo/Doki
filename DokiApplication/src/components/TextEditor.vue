<template>
  <!--<div id="input" ref="input" v-on:keyup="keyInput" v-on:click="onClick" tabindex="0" v-html="message"></div>-->
  <div ref="input" contenteditable="true" v-on:input="update">{{content}}</div>
</template>

<script>
import TextRender from "../services/TextRenderService.js";

export default {
  name: "TextEditor",
  components: {
    TextRender
  },
  props: {
    text: Object,
    content: String
  },
  data: function() {
    return {
      message: 'abc',
      position: Number
    }
  },
  methods: {
    update: function(event) {
      this.$emit('update', event.target.innerText);
    },
    keyInput: function(event) {
      if (event) event.preventDefault();
      let code = event.keyCode;
      if ((code >= 48 && code <= 90)
        || (code >= 96 && code <= 110)
        || (code == 32)) {
        this.message = insert(this.position, this.message, event.key);
        this.position += event.key.length;
        console.log({key: event.key});
      }
      
      function insert(position, string, substring) {
        if (position == string.length) {
          return string + substring;
        }
        else {
          return string.substring(0, position) + 
            substring + string.substring(position);
        }
      }
    },
    onClick: function(event) {
      this.$refs.input.focus();
      
      this.position = getCurrentCursorPosition(this.$refs.input.id);
      
      console.log(this.position);
      
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
  .caret {
    display: inline;
    color: black;
    background-image: '../../dist/asserts/img/caret.png';
  }
</style>
