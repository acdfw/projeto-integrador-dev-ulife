angular.module("website").directive("loadingModal", function () {
  return {
    replace: true,
    scope: {
      settings: "=",
    },
    templateUrl: "views/components/loading-modal/loading-modal.html",
    controller: function ($scope) {
      
    },
  };
});
