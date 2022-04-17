app.directive("answerSheetReviewMode", function () {
  return {
    replace: true,
    scope: {
      content: "=",
    },
    templateUrl: "components/answer-sheet-review-mode/answer-sheet-review-mode.html",
    controller: function ($scope, $location) {
      var me = $scope;

      

    },
  };
});
