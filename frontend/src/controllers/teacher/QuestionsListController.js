app.controller("QuestionsListCtrl", function ($scope, QuestionModel) {
  var me = $scope;

  var questions = QuestionModel.getQuestions();

  questions = questions.map(obj=> ({ ...obj, link: `teacher/question/${obj.id}`}))
  
  var tableQuestions = {
    rows: questions,
    colNames: { id: "Identificador", title: "Título"},
    colOrder: ["id", "title"],
    showHeader: true,
    search: { show: true },
  };  
  
  me.content = {
    title: "Suas Questões",
    subtitles: [""],
    tables: [tableQuestions],
  };

});
