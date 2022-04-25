app.factory("QuestionnaireModel", function ($http) {
  return {
    getQuestionnaireById: function (id) {
      let exam = {
        id: "fasjkdhajkshjkndasjhd",
        name: "prova de teste",
        questions: examQuestions,
      };

      return exam;
    },
    getQuestionnaires: function (id) {
      return new Promise((resolve, reject) => {
        $http({
          method: "GET",
          url: `${API_URL}/Professor/${id}/provas`,
        }).then(function successCallback(response) {
          let questionnaires = response.data.map((obj) => ({
            id: obj.identificador,
            name: obj.nomeProva,
            numQuestions: obj.qtdQuestoes
          }));
          resolve(questionnaires);
        });
      });    
    },
    create: function (obj) {
      console.log(obj);
    },
    
  };
});
