app.factory("TeacherQuestionnaireModel", function ($http) {
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
        title: "prova de teste",
        questions: examQuestions,
      };

      return exam;
    },
    getQuestionnaires: function () {
      
      let exams = [
        {
          id: "eqwdjlaklmckzc",
          title: "prova de teste 1",
          numQuestions: "10",
        },
        {
          id: "ggfhdgretfdsgrt",
          title: "prova de teste 2",
          numQuestions: "15",
        },
        {
          id: "hgfbvsfgergfdsg",
          title: "prova de teste 3",
          numQuestions: "12",
        },
        {
          id: "sdbdnbyregbhdf",
          title: "prova de teste 4",
          numQuestions: "20",
        },
      ];

      return exams;
    },
    createQuestionnaire: function () {
      return true;
    },
  };
});
