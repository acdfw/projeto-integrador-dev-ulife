app.controller("StudentAssignmentToDoCtrl", function ($scope, ExamModel, $routeParams) {
  var me = $scope;

  me.content = ExamModel.getExamById($routeParams.id);
 
  function getAnswers(){
    var answers = []
    var answer
    me.content.questions.forEach(question => {
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



});
