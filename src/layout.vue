<template>
  <div class="wrapper">
    <!--<top_header></top_header>-->
    <left_side></left_side>
    <right_side>
      <router-view></router-view>
    </right_side>
  </div>
</template>

<script>
//  import top_header from './components/layout/topHeader.vue'
  import left_side from './components/layout/leftSide.vue'
  import right_side from './components/layout/rightSide.vue'

  export default({
    name:'layout',
    components: {
//      top_header,
      left_side,
      right_side
    }
  })
</script>

<style></style>
