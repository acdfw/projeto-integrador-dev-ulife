app.controller("TeacherAssignmentDoneCtrl", function ($scope, getAssignment) {
  var me = $scope;

  var assignment = getAssignment;

  console.log(getAssignment)
 
  me.assignmentName = assignment.name;
  me.className = assignment.class.name;
  me.studentName = assignment.student.name;

  me.questionnaire = assignment.questionnaire.questions.sort((a,b) => a.id - b.id);

  me.answers = assignment.answers.sort((a,b) => a.id - b.id);



});
