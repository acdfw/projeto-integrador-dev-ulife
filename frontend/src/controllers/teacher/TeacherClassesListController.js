app.controller("TeacherClassesListCtrl", function ($scope, ClassModel) {
  var me = $scope;

  classes = ClassModel.getTeacherClasses();

  me.classesTable = {
    rows: classes.map((obj) => ({
      name: obj.name,
      assignments: obj.assignments.length.toString(),
      members: obj.students.length.toString(),
      link: `teacher/class/${obj.id}`,
    })),
    colNames: { name: "Turma", members: "Inscritos", assignments: "Avaliações" },
    colOrder: ["name", "members", "assignments"],
    showHeader: true,
    search: { show: true },
  };

  me.newClassName = "";

  me.NewClass = () => {
    ClassModel.create(me.newClassName);
  };
});
