<script setup lang="ts">
// import HelloWorld from './components/HelloWorld.vue'
// import TheWelcome from './components/TheWelcome.vue'

import { ref, reactive } from 'vue';

let counter = ref(0);
let total = ref(0); //aqui se usa el .value
let items = reactive(Array<number>());

function addValue() {
  console.log('call addValue');
  counter.value++;
  // counter.value = counter.value + 2;
}

function addToList() {
  items.push(counter.value);
}

function deleteLastNumberArray() {
  if(items.length > 0) {
    items.pop();
  }else {
    alert('No hay elementos para borrar en el array');
  }
}
</script>

<template>
  <main>
    <div class="buttons">
      <!-- el @ es igual a v-on:click -->
      <div><button @click="counter++">+</button></div>
      <div><button @click="addValue">Sumar desde funcion</button></div>
      <div>El contador vale: {{ counter }}</div>
      <div><button @click="counter--">-</button></div>
      <div><button v-on:click="total += counter">ADD to TOTAL</button></div>
      <div><button @click="addToList">Add to LIST</button></div>
    </div>

    <div><button @click="deleteLastNumberArray">Delete</button></div>
    <div>Total: {{ total }}</div>
    <ul>
      <li v-for="item in items">{{ item }}</li>
    </ul>
    <!-- <TheWelcome /> -->
  </main>
</template>

<style scoped>
.buttons {
  display: flex;
  width: 600px;
  justify-content: space-between;
}

header {
  line-height: 1.5;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style>
