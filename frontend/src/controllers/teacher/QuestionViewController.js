app.controller("QuestionViewCtrl", function ($scope, QuestionModel, $routeParams) {
  var me = $scope;

  me.question = QuestionModel.getQuestionById($routeParams.id);
  me.hideRadioButtons = true; 

});
