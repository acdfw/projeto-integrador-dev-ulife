app
  .directive("examBox", function (QuestionModel) {
    return {
      scope: {
        content: '='
      },
      replace: true,      
      templateUrl: "components/exam-box/exam-box.html",
      controller: function ($scope) {
        var me = $scope;

        me.actualQuestion = 0;

        me.questionsPerPage = 1;

        me.nextPage = function () {
          if (me.questionsPerPage * (me.actualQuestion + 1) < me.content.length) {
            me.actualQuestion += 1;
          }
        };
  
        me.previousPage = function () {
          if (me.questionsPerPage * (me.actualQuestion - 1) > -1) {
            me.actualQuestion -= 1;
          }
        };        

      },
    };
  });
