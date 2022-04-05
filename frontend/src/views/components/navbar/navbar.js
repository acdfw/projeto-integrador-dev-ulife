angular.module("website").directive("navbar", function (MenuService) {
  return {
    replace: true,
    scope: {
      content: "=",
    },
    templateUrl: "views/components/navbar/navbar.html",
    controller: function ($scope) {
      var me = $scope;

      me.brandname = "Whiteboard";

      me.menu = MenuService.getMenu()
    },
  };
});
