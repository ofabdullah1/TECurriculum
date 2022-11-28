<template>
<div>
  <h1>Product Detail</h1>
  <h2>{{productId}}</h2>
  </div>
</template>

<script>
export default {
  data: () => {
    return {
      productId: 0,
    };
  },
  created(){
      this.productId = this.$route.params.productId;
      console.log("reached created of ProductDetail.vue")
  }
};
</script>

<style>
</style>