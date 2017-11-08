<template>
  <el-container style="height: 100%;">
    <el-aside width="210px">
      <el-menu :default-openeds="['1', '9']">
        <div>
          <img :src="menuLogo" alt="">
        </div>
        <el-menu-item-group>
          <el-menu-item>
            <el-input placehoder="搜索"></el-input>
            <i class="el-icon-search"></i>
          </el-menu-item>
        </el-menu-item-group>
        <el-submenu index="1">
          <template slot="title">采购管理</template>
          <el-menu-item-group>
            <el-menu-item index="1-1">请购单</el-menu-item>
            <el-menu-item index="1-3">采购单</el-menu-item>
            <el-menu-item index="1-4">采购入库单</el-menu-item>
          </el-menu-item-group>
        </el-submenu>
        <el-submenu index="2">
          <template slot="title">销售管理</template>
          <el-menu-item-group>
            <el-menu-item index="2-1">选项1</el-menu-item>
            <el-menu-item index="2-2">选项2</el-menu-item>
          </el-menu-item-group>
          <el-menu-item-group title="分组2">
            <el-menu-item index="2-3">选项3</el-menu-item>
          </el-menu-item-group>
          <el-submenu index="2-4">
            <el-menu-item index="2-4-1">选项4-1</el-menu-item>
          </el-submenu>
        </el-submenu>
        <el-submenu index="3">
          <template slot="title">仓库管理</template>
          <el-submenu index="3-1">
            <template slot="title">采购入库单</template>
            <el-menu-item-group>
              <el-menu-item index="3-1-1">选项1</el-menu-item>
              <el-menu-item index="3-1-2">选项2</el-menu-item>
            </el-menu-item-group>
          </el-submenu>
          <el-submenu index="3-2">
            <template slot="title">其它出入库</template>
            <el-menu-item-group>
              <el-menu-item index="3-2-1">选项3</el-menu-item>
            </el-menu-item-group>
          </el-submenu>
          <el-submenu index="3-3">
            <template slot="title">报表</template>
            <el-menu-item-group>
              <el-menu-item index="3-3-1">发料统计表</el-menu-item>
              <el-menu-item index="3-3-2">存货余额报告</el-menu-item>
            </el-menu-item-group>
          </el-submenu>
        </el-submenu>
        <el-submenu index="4">
          <template slot="title">工程管理</template>
          <el-menu-item-group>
            <el-menu-item index="4-1">选项1</el-menu-item>
            <el-menu-item index="4-2">选项2</el-menu-item>
          </el-menu-item-group>
        </el-submenu>
        <el-submenu index="5">
          <template slot="title">生产管理</template>
          <el-menu-item-group>
            <el-menu-item index="5-1">选项1</el-menu-item>
            <el-menu-item index="5-2">选项2</el-menu-item>
          </el-menu-item-group>
        </el-submenu>
        <el-submenu index="6">
          <template slot="title">智能分析</template>
          <el-menu-item-group>
            <el-menu-item index="6-1">选项1</el-menu-item>
            <el-menu-item index="6-2">选项2</el-menu-item>
          </el-menu-item-group>
        </el-submenu>
        <el-submenu index="7">
          <template slot="title">智能分析</template>
          <el-menu-item-group>
            <el-menu-item index="7-1">选项1</el-menu-item>
            <el-menu-item index="7-2">选项2</el-menu-item>
          </el-menu-item-group>
        </el-submenu>
        <el-submenu index="8">
          <template slot="title">基础资料</template>
          <el-submenu>
            <template slot="title">公共类</template>
            <el-menu-item-group>
              <el-menu-item index="8-1">部门</el-menu-item>
              <el-menu-item index="8-2">职位</el-menu-item>
              <el-menu-item index="8-3">员工资料</el-menu-item>
            </el-menu-item-group>
          </el-submenu>
          </el-submenu>
        <el-submenu index="9">
          <template slot="title">系统管理</template>
          <el-menu-item-group>
            <el-menu-item index="9-1">用户权限</el-menu-item>
            <el-menu-item index="9-2">系统参数</el-menu-item>
            <el-menu-item index="9-3">个人信息</el-menu-item>
            <el-menu-item index="9-4">编码规则</el-menu-item>
          </el-menu-item-group>
        </el-submenu>
      </el-menu>
    </el-aside>
    <el-container>
      <el-header>
        <el-dropdown>
          <i class="el-icon-setting" style="margin-right: 15px"></i>
          <el-dropdown-menu slot="dropdown">
            <el-dropdown-item>查看</el-dropdown-item>
            <el-dropdown-item>新增</el-dropdown-item>
            <el-dropdown-item @click.native="exitSystem()">退出</el-dropdown-item>
          </el-dropdown-menu>
        </el-dropdown>
        <span>黄计发</span>
        </div>
      </el-header>
    </el-container>
  </el-container>
  </el-container>
</template>

<script>
  export default({
    data(){
      return{
        menuLogo:'../../static/image/log/logo.png'
      }
    },
    methods:{
      exitSystem(){
        this.$router.push('/login')
      }
    }
  })
</script>

<style scoped>
  body{
    margin:0px;
    background-color:rgba(226, 226, 226, 1);
    position:static;
    left:auto;
    width:1587px;
  }

  .el-aside,.el-menu,.el-menu-item-group,.el-menu-item,.el-input__inner{
    background: #294757;
  }

  .el-menu-item:hover,.el-submenu__title:hover{
    background: #FF0000;
  }

  .el-input{
    width: 150px;
  }

  .el-input__inner{
    border-radius: 0;
    border: none;
    border-bottom: 1px solid #697D94;
  }

  .el-submenu__title,.el-menu-item{
    color: #ffffff;
    font-size: 15px;
  }

  .el-header{
    background-color: #294757;
  }

  .el-header>span{
    height: 60px;
    line-height: 60px;
    color: #fff;
    font-size: 15px;
  }

</style>
