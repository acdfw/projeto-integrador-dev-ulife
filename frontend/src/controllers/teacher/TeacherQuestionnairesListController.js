app.controller("TeacherQuestionnairesListCtrl", function ($scope, QuestionnaireModel, $location) {
  var me = $scope;

  var exams = QuestionnaireModel.getQuestionnaires();

  exams = exams.map(obj=> ({ id: obj.id, name: obj.name, numQuestions: obj.questions.length, link: `teacher/questionnaire/${obj.id}`}))
  
  me.table = {
    rows: exams,
    colNames: { name: "Titulo", numQuestions: "Número de Questões", id: "Identificador" },
    colOrder: ["id", "name", "numQuestions"],
    showHeader: true,
    search: { show: true },
  };  
  
me.redirectToQuestions = () => {
  $location.path("/teacher/questions")
}

});
