app.controller("TeacherQuestionnairesListCtrl", function ($scope, TeacherQuestionnaireModel) {
  var me = $scope;

  var exams = TeacherQuestionnaireModel.getQuestionnaires();

  exams = exams.map(obj=> ({ ...obj, link: `teacher/questionnaire/${obj.id}`}))
  
  var tableTeacherExams = {
    rows: exams,
    colNames: { title: "Titulo", numQuestions: "Número de Questões", id: "Identificador" },
    colOrder: ["id", "title", "numQuestions"],
    showHeader: true,
    search: { show: true },
  };  
  
  me.content = {
    title: "Suas Provas",
    subtitles: [""],
    tables: [tableTeacherExams],
  };

});
