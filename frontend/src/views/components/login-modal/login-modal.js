angular.module("website").directive("loginModal", function () {
  return {
    replace: true,
    scope: {
      settings: "=",
    },
    templateUrl: "views/components/login-modal/login-modal.html",
    controller: function ($scope) {
      var me = $scope;

      teacherLogin = {
        role : "Professor",  
        action: "teste"        
      }

      studentLogin = {
        role : "Aluno",  
        action: "teste"        
      }

      if (!me.settings){
        me.settings = {
          type: 'S'
        }
      }


      me.$watch("settings", ()=>{
        if(me.settings.type == 'T'){
          me.content = teacherLogin
        } else if(me.settings.type == 'S'){
          me.content = studentLogin
        }
      })

      me.hideModal = function(){
        me.settings.isVisible = false;
      }      
    },
  };
});
