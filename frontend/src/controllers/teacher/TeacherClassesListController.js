app.controller("TeacherClassesListCtrl", function ($scope, TeacherClassModel) {
  var me = $scope;

  classes = TeacherClassModel.getClasses();

  classes = classes.map(obj=> ({ ...obj, link: `teacher/class/${obj.id}`}))

  var tableTeacherClasses = {
    rows: classes,
    colNames: { turma: "Turma", inscritos: "Inscritos" },
    colOrder: ["turma", "inscritos"],
    showHeader: true,
    search: { show: false },
  };
  
  me.content = {
    title: "Suas turmas",
    subtitles: [""],
    tables: [tableTeacherClasses],
  };

});
