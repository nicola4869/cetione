<template>
  <div class="header">
    <el-row class="icon-menu-thumbnail">
      <!--菜单缩略图标-->
      <el-col :span="4"></el-col>
      <!--右侧两个提示-->
      <el-col :span="3" :offset="18">
        <span class="icon-home">123</span>
        <!--这里记得把链接存到一个变量里，动态改变-->
        <a href="">首页</a>
      </el-col>
      <el-col :span="3">
        <span class="icon-help">123</span>
        <a href="">帮助中心</a>
      </el-col>
    </el-row>
  </div>
</template>

<script>

</script>

<style lang="scss" type="text/css" scoped="">
  body,html{
    margin: 0;
    padding: 0;
  }

  .header{
    height: 36px;
    background-color: #465464;
  }

  .icon-menu-thumbnail a{
    display: inline-block ;
    font-size: 18px;
    height: 36px;
    line-height: 36px;
    color: #fff;
    text-decoration: none;
  }
</style>
