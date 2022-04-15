app.controller(
  "TeacherQuestionsListCtrl",
  function ($scope, QuestionModel, $location, QuestionnaireModel) {
    var me = $scope;

    var questions = QuestionModel.getQuestions();

    questions = questions.map((obj) => ({ ...obj, selected: false }));

    me.questionsTable = {
      rows: questions,
      colNames: { title: "Título", statement: "Enunciado" },
      colOrder: ["title", "statement"],
      showHeader: true,
      search: { show: true },
      selectable: true,
      selectedItems: [],
    };

    me.createQuestion = () => {
      $location.path("/teacher/new-question");
    };

    me.cleanSelection = () => {
      me.questionsTable.rows.forEach(row => row.selected = false);
      me.questionsTable.selectedItems = []
    };

    me.createQuestionnaire = () => {
      if (
        me.questionsTable.selectedItems.length > 0 &&
        me.newQuestionnaireName
      ) {
        QuestionnaireModel.create({
          name: me.newQuestionnaireName,
          questions: me.questionsTable.selectedItems.map((obj) => obj.id),
        });
      } else {
        alert("O questionário precisa de um nome e de questões");
      }
    };
  }
);
