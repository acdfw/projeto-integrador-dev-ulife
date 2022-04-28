app.controller("TeacherQuestionnaireViewCtrl", function ($scope, getQuestionnaire) {
  var me = $scope;

  me.content = getQuestionnaire
 
  me.hideRadioButtons = true;

});
