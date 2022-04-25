app.factory("QuestionModel", function ($http) {
  return {
    getQuestionById: function (id) {
      // $http({
      //     method: 'GET',
      //     url: '/someUrl'
      //   }).then(function successCallback(response) {
      //       // this callback will be called asynchronously
      //       // when the response is available
      //     }, function errorCallback(response) {
      //       // called asynchronously if an error occurs
      //       // or server returns response with an error status.
      //     });
      
      return examQuestions[0];
    },
    getQuestions: function (id) {
      return new Promise((resolve, reject) => {
        $http({
          method: "GET",
          url: `${API_URL}/Professor/${id}/questoes`,
        }).then(function successCallback(response) {
          let questions = response.data.map((obj) => ({
            id: obj.id,
            title: obj.nomeQuestao,
            statement: obj.enunciado,
            options: obj.alternativas.map(opt => ({id: opt.id, statement: opt.texto}))
          }));
          resolve(questions);
        });
      });
    },
    create: function (obj) {
        console.log(obj)
    }
  };
});
