app.controller("TeacherClassesListCtrl", function ($scope, getTeacherClasses) {
  var me = $scope; 

  me.classesTable = {
    rows: getTeacherClasses.map((obj) => ({...obj, link: `teacher/class/${obj.id}`})),
    colNames: {
      name: "Turma",
      members: "Inscritos",
      assignments: "Avaliações",
    },
    colOrder: ["name", "members", "assignments"],
    showHeader: true,
    search: { show: true },
  };

  me.newClassName = "";

  me.NewClass = () => {
    ClassModel.create(me.newClassName);
  };

});
