<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <h2>{{ count }} con cừu</h2>
    <button @click="xulysukien(2)">Click vào đây</button>
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  data(){
    return{
      count:0
    }
  },
  props: {
    msg: String
  },
  method: {
    xulysukien(step){
      this.count +=step;
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
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
