app.controller("TeacherAssignmentViewCtrl", function ($scope, AssignmentModel, $routeParams) {
  var me = $scope;

  var assignment = AssignmentModel.getTeacherAssignmentById($routeParams.id);
 
  me.assignmentName = assignment.name;
  me.className = assignment.class.name;
  me.questionnaireName = assignment.questionnaire.name;
  me.questionnaire = assignment.questionnaire.questions;

  me.hideRadioButtons = true;

  me.studentsResults = {
    rows: assignment.studentsResults.map((obj) => ({
      studentId: obj.student.id,
      studentName: obj.student.name,
      grade: (obj.grade) ? obj.grade : '-',
      link: (obj.grade) ? `teacher/assignment-done/${obj.id}` : null,
    })),
    colNames: { studentId: "Matrícula", studentName: "Nome do Aluno", grade: "Nota"},
    colOrder: ["studentId", "studentName", "grade"],
    showHeader: true,
    search: { show: true },
  };

  var grades = assignment.studentsResults.filter(obj => obj.grade).map(obj => Number(obj.grade))

  me.numDoneAssignments = assignment.studentsResults.filter(obj => obj.grade).length
  me.numPendingAssignments = assignment.studentsResults.length - me.numDoneAssignments;
  me.minGrade = Math.min(...grades);
  me.maxGrade = Math.max(...grades);
  me.averageGrade = (grades.reduce((a, b) => a + b, 0)/grades.length).toFixed(2);

});
