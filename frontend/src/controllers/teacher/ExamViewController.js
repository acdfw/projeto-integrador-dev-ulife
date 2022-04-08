app.controller("ExamViewCtrl", function ($scope, ExamModel, $routeParams) {
  var me = $scope;

  me.content = ExamModel.getExamById($routeParams.id);
 
  me.hideRadioButtons = true;

});
