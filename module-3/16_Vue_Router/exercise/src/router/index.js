import Vue from 'vue';
import VueRouter from 'vue-router'
import Home1 from "../views/Home1"
import MyBooks from '../views/MyBooks'
import NewBook from '../views/NewBook'
import Details from '../views/Details'



Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Home1',
    component: Home1
  },
  {
    path: '/myBooks',
    name: 'myBooks',
    component: MyBooks
  },
  {
    path: '/addBook',
    name: 'NewBook',
    component: NewBook
  },
  {
    path: '/book/:isbn',
    name: 'Book',
    component: Details
  }
  
 
];

const router = new VueRouter({
  mode: 'history',
  routes
});

export default router;
