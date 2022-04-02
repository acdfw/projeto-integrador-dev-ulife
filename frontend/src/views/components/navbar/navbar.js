angular.module("website").directive("navbar", function () {
  return {
    replace: true,
    scope: {
      content: "=",
    },
    templateUrl: "views/components/navbar/navbar.html",
    controller: function ($scope) {
      var me = $scope;

      me.brandname = "Whiteboard";

      me.menu = [
        { text: "Home", link: "#/" },
        { text: "Equipe", link: "#/equipe" },
        { text: "Sobre", link: "#/sobre" },
      ];
    },
  };
});
