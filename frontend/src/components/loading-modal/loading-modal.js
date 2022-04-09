app.directive("loadingModal", function () {
  return {
    replace: true,
    scope: {
      settings: "=",
    },
    templateUrl: "components/loading-modal/loading-modal.html",
    controller: function ($scope) {
      
    },
  };
});
