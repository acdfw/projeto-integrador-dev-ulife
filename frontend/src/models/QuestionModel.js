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
      
      return true;
    },
    getQuestions: function () {
        return questions;
    },
    registerQuestion: function () {
        return questions;
    }
  };
});