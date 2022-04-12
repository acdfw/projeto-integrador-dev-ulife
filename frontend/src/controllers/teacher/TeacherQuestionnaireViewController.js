app.controller("TeacherQuestionnaireViewCtrl", function ($scope, TeacherQuestionnaireModel, $routeParams) {
  var me = $scope;

  me.content = TeacherQuestionnaireModel.getQuestionnaireById($routeParams.id);
 
  me.hideRadioButtons = true;

});
