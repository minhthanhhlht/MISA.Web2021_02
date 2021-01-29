<template>
  <div id="app">
    <Navbar />
    <Header />
    <Content />
  </div>
</template>

<script>
import Navbar from "@/components/layout/navbar";
import Header from "@/components/layout/header";
import Content from "@/components/layout/content";
export default {
  name: "App",
  components: {
    Navbar,
    Header,
    Content,
  },
};
</script>

<style lang="scss">
  @import "./styles/index.scss";


::-webkit-scrollbar {
    width: 5px !important;
    height: 5px !important;
    z-index: 1231232123421
}

::-webkit-scrollbar-track {
    width:6px;
    background-color: #bbb;
}

::-webkit-scrollbar-thumb {
    background-color: #808080;
    border-radius: 8px
}
</style>
