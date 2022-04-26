app.controller("TeacherQuestionnairesListCtrl", function ($scope, getQuestionnaires, $location) {
  var me = $scope;

  var exams = getQuestionnaires;

  exams = exams.map(obj=> ({ ...obj, link: `teacher/questionnaire/${obj.id}`}))
  
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
