app.controller("StudentClassesListCtrl", function ($scope, StudentClassModel) {
  var me = $scope;

  classes = StudentClassModel.getClasses();

  subscribedClasses = classes.filter((obj) => obj.registration != null);
  unsubscribedClasses = classes.filter((obj) => obj.registration == null);

  subscribedClasses = subscribedClasses.map((obj) => ({
    className: obj.className,
    teacherName: obj.teacherName,
    pendingAssignments: obj.assignments.filter((ass) => ass.grade == null).length,
    link: `student/class/${obj.id}`,
  }));

  var tableSubscribedClasses = {
    rows: subscribedClasses,
    colNames: {
      className: "Turma",
      teacherName: "Instrutor(a)",
      pendingAssignments: "Avaliações Pendentes",
    },
    colOrder: ["className", "teacherName", "pendingAssignments"],
    showHeader: true,
    search: { show: false },
  };
  
  me.subscribedClasses = {
    title: "Matriculado",
    subtitles: [""],
    tables: [tableSubscribedClasses],
  };

  var tableUnsubscribedClasses = {
    rows: unsubscribedClasses,
    colNames: {
      className: "Turma",
      teacherName: "Instrutor(a)",
      pendingAssignments: "Avaliações Pendentes",
    },
    colOrder: ["className", "teacherName", "pendingAssignments"],
    showHeader: true,
    search: { show: false },
  };

  me.unsubscribedClasses = {
    title: "Outras turmas",
    subtitles: [""],
    tables: [tableUnsubscribedClasses],
  };

});
