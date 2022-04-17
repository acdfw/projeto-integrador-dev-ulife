app.controller("TeacherClassViewCtrl", function ($scope, ClassModel, $routeParams, QuestionnaireModel) {
  var me = $scope;

  var teacherClass = ClassModel.getTeacherClassById($routeParams.id)

  var tableAssignments = {
    rows: teacherClass.assignments.map(obj => ({...obj, link: `/teacher/assignment/${obj.id}`})),
    colNames: { id: "Identificador" ,name: "Apelido" },
    colOrder: ["id", "name"],
    showHeader: true,
    search: { show: true },
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
  
  me.questionnaires = QuestionnaireModel.getQuestionnaires();

me.CreateNewAssignment = () => {
  console.log({name: me.newAssignmentName, questionnaire: me.questionnaireBase})  
}

});
