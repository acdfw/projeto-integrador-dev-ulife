app.controller(
  "TeacherQuestionsListCtrl",
  function ($scope, getQuestions, $location, QuestionnaireModel, AuthTokenService) {
    var me = $scope;

    var questions = getQuestions;

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

    me.createQuestionnaire = async () => {
      if (
        me.questionsTable.selectedItems.length > 0 &&
        me.newQuestionnaireName
      ) {
        try{
          response = await QuestionnaireModel.create({
            nome: me.newQuestionnaireName,
            usuarioId: AuthTokenService.getUserId(),
            questoesId: me.questionsTable.selectedItems.map((obj) => obj.id),
          });
          alert(response.msg)
        }catch(err){
          alert(err.err)
        }
        
      } else {
        alert("O questionário precisa de um nome e de questões");
      }
    };
  }
);
