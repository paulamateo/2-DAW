import { createRouter, createWebHistory } from "vue-router"
import HomeView from "../views/HomeView.vue"
import BillboardView from "../views/BillboardView.vue"
import ProgrammingView from "../views/ProgrammingView.vue"
import ShowView from "../views/ShowView.vue"

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        {
            path: '/',
            name: 'home',
            component: HomeView
        },
        {
            path: '/billboard',
            name: 'billboard',
            component: BillboardView
        },
        {
            path: '/programming',
            name: 'programming',
            component: ProgrammingView
        },
        {
            path: '/show',
            name: 'show',
            component: ShowView
        }
    ]
})

export default router