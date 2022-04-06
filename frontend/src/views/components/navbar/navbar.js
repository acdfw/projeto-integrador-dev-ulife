angular.module("website").directive("navbar", function (MenuService) {
  return {
    replace: true,
    templateUrl: "views/components/navbar/navbar.html",
    controller: function ($scope, $rootScope) {
      var me = $scope;
      var root = $rootScope;

      root.brandname = "Whiteboard";

      root.$watch("Role", () => {
        me.menu = MenuService.getMenu();
      });
    },
  };
});
