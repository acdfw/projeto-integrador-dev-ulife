app.controller("TeacherQuestionnaireViewCtrl", function ($scope, QuestionnaireModel, $routeParams) {
  var me = $scope;

  me.content = QuestionnaireModel.getQuestionnaireById($routeParams.id);
 
  me.hideRadioButtons = true;

});
