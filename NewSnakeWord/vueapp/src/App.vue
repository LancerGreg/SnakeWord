<template>
  <picture>
    <img alt="Vue logo" src="./assets/logo.png">
  </picture>
  <LoadInit />
</template>

<script>
import LoadInit from './components/LoadInit.vue'

export default {
  name: 'App',
  components: {
    LoadInit
  }
}
</script>
