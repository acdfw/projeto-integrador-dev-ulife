app.controller("ClassesListCtrl", function ($scope, ClassModel) {
  var me = $scope;

  classes = ClassModel.getClasses();

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
