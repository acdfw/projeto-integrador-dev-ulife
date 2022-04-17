app.controller("TeacherQuestionViewCtrl", function ($scope, TeacherQuestionModel, $routeParams) {
  var me = $scope;

  me.question = TeacherQuestionModel.getQuestionById($routeParams.id);
  me.hideRadioButtons = true; 

});
