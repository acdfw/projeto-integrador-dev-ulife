app.controller("StudentAssignmentDoneCtrl", function ($scope, getAssignment) {
  var me = $scope;

  var assignment = getAssignment;
 
  me.assignmentName = assignment.name;
  me.className = assignment.class.name;
  me.teacherName = assignment.teacher.name;

  me.questionnaire = assignment.questionnaire.questions.sort((a,b) => a.id - b.id);

  me.answers = assignment.answers.sort((a,b) => a.id - b.id);



});
