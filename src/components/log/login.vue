<template>
  <el-row class="c-login">
    <!--顶部菜单-->
    <el-row class="c-menu">
      <!--左侧logo-->
      <el-col class="menu-logo" :span="6">
        <img :src="logoImg" alt="">
      </el-col>
      <!--右侧content-->
      <el-col class="menu-content" :span="9" :offset="9">
        <span>商学院</span>
        <span>帮助中心</span>
        <span>关于我们</span>
      </el-col>
    </el-row>
    <!--右侧登陆框-->
    <el-form class="c-log" :model="ruleForm" :rules="rules" ref="ruleForm">
      <el-form-item label="用户" prop="cus_name">
        <el-input type="text" v-model="ruleForm.cus_name" placeholder="登陆名"></el-input>
      </el-form-item>
      <el-form-item label="密码" prop="cus_pwd">
        <el-input type="password" v-model="ruleForm.cus_pwd" placeholder="密码"></el-input>
      </el-form-item>
      <el-form-item prop="captcha">
        <el-input v-model="ruleForm.captcha" placeholder="验证码"></el-input>
      </el-form-item>
      <el-form-item class="submitBtn">
        <el-button type="danger" @click="submitForm('ruleForm')">登陆</el-button>
      </el-form-item>
    </el-form>
  </el-row>
</template>

<script>


  export default({
    name:'login',
    data(){
      var checkPwd = (rule,value,callback)=>{
        if(value === ""){
          callback(new Error(('请输入密码')));
        }
      };
      return{
        logoImg:'../../static/image/log/logo-long.png',
        ruleForm:{
          cus_name:'',
          cus_pwd:'',
          captcha:''
        },
        rules:{
          cus_name:[
            { required:true,message:'请输入登录名',trigger:'blur'},
            { min:3,message:"请输入正确的登录名",trigger:'blur'}
          ],
          pwd:[
            { validator: checkPwd, trigger:'blur'}
          ],
          captcha:[
            { required: true,message:"请输入验证码",trigger:'blur'}
          ]
        }
      }
    },
    methods:{
      submitForm(formName){
        this.$refs[formName].validate((valid)=>{
          if(valid){
            alert('submit');
            this.loginAct();
          }else{
            console.log("error submit")
            return false
          }
        })
      },
      loginAct(){
        var _this = this;
        _this.loginSucess();
      },
      loginSucess(){
        this.$router.push('/');
        window.location.href = 'http://www.cetione.com/'
      }
    }
  })
</script>

<style lang="scss" scoped>
  body{
    width:100%;
    margin:0;
    padding:0;
    background: url("../../../static/image/bk/backgroundImg.jpg");
    -webkit-background-size:100%;
    background-size:100%;
  }



</style>
