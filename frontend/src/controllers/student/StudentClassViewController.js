app.controller("StudentClassViewCtrl", function ($scope, ClassModel, $routeParams) {
  var me = $scope;

  var studentClass = ClassModel.getStudentClassById($routeParams.id)

  me.className = studentClass.name;

  me.pendingAssignmentsTable = {
    rows: studentClass.assignments.filter(a => !a.grade).map(obj => ({...obj, link: `/student/assignment-todo/${obj.id}`})),
    colNames: { name: "Nome" },
    colOrder: ["name"],
    showHeader: true,

  };
  
  me.doneAssignmentsTable = {
    rows: studentClass.assignments.filter(a => a.grade).map(obj => ({...obj, link: `/student/assignment-done/${obj.id}`})),
    colNames: { name: "Nome", grade: "Nota" },
    colOrder: ["name", "grade"],
    showHeader: true,
  };
  
});
