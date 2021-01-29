<template>
 <div id='app'>
    <Navbar />
    <Header />
    <Content />
  </div>
  <!-- <div id='nav'>
    <router-link to='/'>Home</router-link> |
    <router-link to='/about'>About</router-link>
  </div> -->
</template>
<script>
import Navbar from '@/components/layout/Navbar'
import Header from '@/components/layout/Header'
import Content from '@/components/layout/Content'
export default {
  name: 'App',
  components: {
    Navbar,
    Header,
    Content
  }
}
</script>
<style lang='scss'>
@import './styles/index.scss';

#nav {
  padding: 30px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

#nav a.router-link-exact-active {
  color: #019160;
}
.navbar .navbar-content .nav-item.router-link-exact-active {
    background-color: #e5e5e5;
}
</style>
