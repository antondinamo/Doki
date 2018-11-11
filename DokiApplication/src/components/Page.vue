<template>
  <div>
    <h1>{{title}}</h1>
    <h3>{{description}}</h3>
    <PageEntity 
      v-for="entity in entities" :key="entity.id" :text="entity.value">
    </PageEntity>
  </div>
</template>

<script>
import PageEntity from "./PageEntityBuilder.vue";

export default {
  name: "Page",
  components: {
    PageEntity
  },
  data: function(){
    return{
      title: "",
      description: "",
      entities: []
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
        this.entities = json.components;
        console.log(json);
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