app.controller("HomeCtrl", function ($scope) {
  var me = $scope;

  me.OpenModal = (type) => {
    me.modal = {
      type,
      isVisible: true,
    };
  };
  
});
