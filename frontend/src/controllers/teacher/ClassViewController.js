app.controller("ClassViewCtrl", function ($scope, ClassModel, $routeParams) {
  var me = $scope;

  var teacherClass = ClassModel.getClassById($routeParams.id)

  var tableAssignments = {
    rows: teacherClass.assignments,
    colNames: { id: "Identificador" ,title: "Apelido" },
    colOrder: ["id", "title"],
    showHeader: true,
    search: { show: false },
  };
  
  var tableStudents = {
    rows: teacherClass.students,
    colNames: { id: "Matrícula", name: "Nome" },
    colOrder: ["id", "name"],
    showHeader: true,
    search: {
      show: true
    }
  };
  
  me.content = {
    title: teacherClass.title,
    subtitles: ["Avaliações", "Alunos"],
    tables: [tableAssignments, tableStudents],
  };
  


});
