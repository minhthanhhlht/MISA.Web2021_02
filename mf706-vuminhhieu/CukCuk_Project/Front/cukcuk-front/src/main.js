import Vue from 'vue'
import App from './App.vue'

Vue.config.productionTip = false
// import './lib/css/bootstrap.css'
new Vue({
  render: h => h(App),
}).$mount('#app')
