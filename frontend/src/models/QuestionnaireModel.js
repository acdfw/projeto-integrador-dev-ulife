app.factory("QuestionnaireModel", function ($http) {
  return {
    getQuestionnaireById: function (id) {
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

      let exam = {
        id: "fasjkdhajkshjkndasjhd",
        name: "prova de teste",
        questions: examQuestions,
      };

      return exam;
    },
    getQuestionnaires: function () {
      let exams = [
        {
          id: "eqwdjlaklmckzc",
          name: "prova de teste 1",
          questions: examQuestions,
        },
        {
          id: "ggfhdgretfdsgrt",
          name: "prova de teste 2",
          questions: examQuestions,
        },
        {
          id: "hgfbvsfgergfdsg",
          name: "prova de teste 3",
          questions: examQuestions,
        },
        {
          id: "sdbdnbyregbhdf",
          name: "prova de teste 4",
          questions: examQuestions,
        },
      ];

      return exams;
    },
    create: function (obj) {
      console.log(obj);
    },
    
  };
});
