app.controller("HomeCtrl", function ($scope, $location) {
  var me = $scope;

  me.OpenModal = (type) => {
    me.modal = {
      type,
      isVisible: true,
    };
  };
  
});
