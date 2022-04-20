app.directive("loginModal", function (UserModel) {
  return {
    replace: true,
    scope: {
      settings: "=",
    },
    templateUrl: "components/login-modal/login-modal.html",
    controller: function ($scope) {
      var me = $scope;

      me.hideModal = function () {
        me.settings.isVisible = false;
      };

      me.userLogin = () => {
        var data =  {login: me.login, senha: me.password}
        UserModel.login(data);
      };
    },
  };
});
