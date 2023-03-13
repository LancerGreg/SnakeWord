<template>
  <div class="post">
    <div v-if="loading" class="loading">
      Loading... Please refresh once the ASP.NET backend has started.
    </div>

    <div v-if="post" class="content">The ASP.NET backend is started</div>
  </div>
</template>

<script>
import { defineComponent } from "vue";

export default defineComponent({
  data() {
    return {
      loading: false,
      post: null,
    };
  },
  created() {
    this.fetchData();
  },
  watch: {
    $route: "fetchData",
  },
  methods: {
    fetchData() {
      this.post = null;
      this.loading = true;

      fetch("lifecycle")
        .then((r) => r.json())
        .then((json) => {
          this.post = json;
          this.loading = false;
          return;
        });
    },
  },
});
</script>

<style scoped>
.post, .content {
  text-align: center;
}
</style>