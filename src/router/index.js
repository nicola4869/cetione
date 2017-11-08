import Vue from 'vue'
import Router from 'vue-router'
import Login from '@/components/log/login'
import Layout from '@/layout'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/login',
      name: 'login',
      component: Login
    },
    {
      path: '/',
      component: Layout,

    },
  ]
})
