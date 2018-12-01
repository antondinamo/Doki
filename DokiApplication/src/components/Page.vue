<template>
  <div>
    <h1>{{title}}</h1>
    <h3>{{description}}</h3>
    <CardBuilder 
      v-for="card in cards" :key="card.id" :card="card">
    </CardBuilder>
    <TextEditor :content="text" @update="text = $event"/>
  </div>
</template>

<script>
import CardBuilder from "./cards/CardBuilder.vue";
import TextEditor from "./TextEditor.vue";

export default {
  name: "Page",
  components: {
    CardBuilder,
    TextEditor
  },
  data: function(){
    return{
      title: String,
      description: String,
      cards: Array,
      text: "asdasdasd"
    }
  },
  created() {
    fetch('/api/pages/2')
      .then((response) => {
        if(response.ok) {
          return response.json();
        }
      
        throw new Error('Network response was not ok');
      })
      .then((json) => {
        this.title = json.title;
        this.description = json.description;
        this.cards = json.cards;
      })
      .catch((error) => {
        console.log(error);
      });
  }
};
</script>

<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>