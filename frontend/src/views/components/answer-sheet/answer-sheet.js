angular.module("website").directive("answerSheet", function () {
  return {
    replace: true,
    scope: {
      content: "=",
    },
    templateUrl: "views/components/answer-sheet/answer-sheet.html",
    controller: function ($scope, $location) {
      var me = $scope;

      

    },
  };
});
