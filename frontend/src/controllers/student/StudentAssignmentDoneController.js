app.controller("StudentAssignmentDoneCtrl", function ($scope, AssignmentModel, $routeParams) {
  var me = $scope;

  var assignment = AssignmentModel.getDoneAssignmentById($routeParams.id);
 
  me.assignmentName = assignment.name;
  me.className = assignment.class.name;
  me.teacherName = assignment.teacher.name;

  me.questionnaire = assignment.questionnaire.questions.sort((a,b) => a.id - b.id);

  me.answers = assignment.studentResult.questions.sort((a,b) => a.id - b.id);



});
