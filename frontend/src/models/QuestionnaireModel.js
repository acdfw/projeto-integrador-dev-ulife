app.factory("QuestionnaireModel", function ($http) {
  return {
    getQuestionnaireById: function (id) {
      return new Promise((resolve, reject) => {
        $http({
          method: "GET",
          url: `${API_URL}/Prova/${id}/questoes`,
        }).then(function successCallback(response) {
          let questionnaire = {
            title: "nomeProva",
            questions: response.data.map((obj) => ({
              id: obj.id,
              statement: obj.enunciado,
              title: obj.nomeQuestao,
              options: obj.alternativas.map((opt) => ({
                id: opt.id,
                statement: opt.texto,
              })),
            })),
          };
          resolve(questionnaire);
        });
      });
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
            numQuestions: obj.qtdQuestoes,
          }));
          resolve(questionnaires);
        });
      });
    },
    create: function (data) {
      return new Promise((resolve, reject) => {
        $http({
          method: "POST",
          url: `${API_URL}/Prova`,
          data: data,
        })
          .then((response) => {
            resolve({ msg: response.data });
          })
          .catch((err) => {
            reject({ msg: err.data });
          });
      });
    },
  };
});
