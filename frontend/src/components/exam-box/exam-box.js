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

        function getAnswers(){
          var answers = []
          var answer
          me.content.forEach(question => {
            if(!question.answer){
              answer = ''
            }else{
              answer = question.answer.id
            }
            answers.push(answer)
          })
          return answers;
        }

        me.submitExam = () => {
          var answers = getAnswers();

          if(answers.filter(answer => answer == '').length > 0){
            alert("Você não respondeu todas as perguntas")
          }else{
            console.log(answers)
          }
        }


      },
    };
  });
