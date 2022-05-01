app.controller("StudentAssignmentsListCtrl", function ($scope, getStudentAssignments) {
  var me = $scope;

  var assignments = getStudentAssignments;

  assignments = assignments.map( obj => ({
    assignment : obj.name,
    className : obj.class.name,
    teacherName : obj.teacher.name,
    grade : obj.studentResult ? obj.studentResult.grade :  '-',
    link: obj.studentResult ? `/student/assignment-done/${obj.id}` : `/student/assignment-todo/${obj.id}`
  }))

  me.table = {
    rows: assignments,
    colNames: {
      assignment: "Avaliação",
      className: "Turma",
      teacherName: "Instrutor(a)",
      grade: "Nota",
    },
    colOrder: ["className", "teacherName", "assignment", "grade"],
    showHeader: true,
    search: { show: true },
  };
  
});
