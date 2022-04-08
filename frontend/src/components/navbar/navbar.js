app.directive("navbar", function (MenuService) {
  return {
    replace: true,
    templateUrl: "components/navbar/navbar.html",
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
