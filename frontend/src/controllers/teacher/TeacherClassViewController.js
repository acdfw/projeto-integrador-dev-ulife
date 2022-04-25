app.controller("TeacherClassViewCtrl", function ($scope, QuestionnaireModel, getTeacherClassInfo) {
  var me = $scope;

  var tableAssignments = {
    rows: getTeacherClassInfo.assignments.map(obj => ({...obj, link: `/teacher/assignment/${obj.id}`})),
    colNames: { id: "Identificador" ,name: "Apelido" },
    colOrder: ["id", "name"],
    showHeader: true,
    search: { show: true },
  };
  
  var tableStudents = {
    rows: getTeacherClassInfo.students,
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
