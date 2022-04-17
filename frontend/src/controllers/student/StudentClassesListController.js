app.controller("StudentClassesListCtrl", function ($scope, ClassModel) {
  var me = $scope;

  classes = ClassModel.getStudentClasses();

  classes = classes.map( obj => ({
    className : obj.name,
    teacherName : obj.teacher.name,
    pendingAssignments : obj.assignments.filter(ass => !ass.grade).length,
    doneAssignments : obj.assignments.filter(ass => ass.grade).length,
    link: `/student/class/${obj.id}`
  }))

  me.table = {
    rows: classes,
    colNames: {
      className: "Turma",
      teacherName: "Instrutor(a)",
      pendingAssignments: "Avaliações Pendentes",
      doneAssignments: "Avaliações Realizadas",
    },
    colOrder: ["className", "teacherName", "doneAssignments", "pendingAssignments"],
    showHeader: true,
    search: { show: false },
  };
  
});
