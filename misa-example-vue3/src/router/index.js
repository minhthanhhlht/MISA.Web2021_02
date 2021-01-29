import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'
import Customer from '../views/dictionary/customer/CustomerList.vue'
import Employee from '../views/dictionary/employee/EmployeeList.vue'

const routes = [
  {path: '/',name: 'Home',component: Home},
  {path: '/about',name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  },
  {
    path: '/dictionary/customer',
    name: 'Customer',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: Customer
  },
  {
    path: '/dictionary/employee',
    name: 'Employee',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: Employee
  }

]

const router = createRouter({
  mode: 'history',
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
