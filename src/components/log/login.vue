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
      <el-form-item>
        <span>立即体验</span>
        <span>忘记密码？</span>
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

//      loginAct: function () {
//        this.removeCookie();
//        var _this = this;
//        this.$ajax({
//            url: api.login,
//            method: 'post',
//            data: {
//              agent_name: _this.ruleForm.agent_name,
//              pwd: _this.ruleForm.pwd,
//              captcha: _this.ruleForm.captcha
//            }
//          })
//          .then(function (response) {
//            if(response.data.data.code==400){
//              alert(response.data.message)
//            }
//            if(response.data.code==200){
//              _this.userData = response.data.data;
//              var value = _this.userData.access_token;
//              //save cookies
//              var time = 7 * 24 * 60 * 60 * 1000;
//              _this.savecookie(value, time);
////                        存cookie end
////                       存Login status start
//              _this.$store.dispatch('getLoginData', {'loginScale': _this.userData.scale});
////                       存Login status end
//
//              _this.successLogin();
//            }
//
//          })
//      },
      loginSucess(){
        var _this = this
        _this.$router.push('/');
//        window.location.href = 'http://www.cetione.com/'
      }
    }
  })
</script>

<style>
  body{
    width:100%;
    margin:0;
    padding:0;
    background: url("../../../static/image/bk/backgroundImg.jpg");
    -webkit-background-size:100%;
    background-size:100%;
  }

  .c-login{
    position: relative;
  }

  .el-row {
    padding-top: 6.5%;
    position: fixed;
    width: 100%;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    overflow-y: auto;
  }
  .submitBtn{
    text-align: center;
  }
  .main {
    padding: 20px;
  }

  .el-form{
    width: 300px;
    height: 400px;
    background: #fff;
    position: absolute;
    right: 60px;
    top: 200px;
    border-radius: 5px;
  }

  .el-input{
    width: 225px;
  }

</style>
