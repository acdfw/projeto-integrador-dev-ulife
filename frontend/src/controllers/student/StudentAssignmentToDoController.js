app.controller("StudentAssignmentToDoCtrl", function ($scope, getAssignment, $routeParams, AuthTokenService, AssignmentModel) {
  var me = $scope;

  console.log(getAssignment)
  var assignment = getAssignment
  me.assignmentName = assignment.name;
  me.className = assignment.class.name;
  me.teacherName = assignment.teacher.name;

  me.questionnaire = assignment.questionnaire.questions;

  function getAnswers(){
    var answers = []
    var answer

    assignment.questionnaire.questions.forEach(question => {
      if(!question.answer){
        answer = null
      }else{
        answer = question.answer.id
      }
      answers.push({questaoId: question.id, alternativaid: answer})
    })
    return answers;
  }

  me.submitExam = async () => {
    var answers = getAnswers();
    console.log('aqui')
    if(answers.filter(answer => answer.alternativaId == null).length > 0){
      if(confirm("Você não respondeu todas as perguntas. Deseja prosseguir?")){
        try{
          let response =  await AssignmentModel.submit({
            avaliacaoId: $routeParams.id,
            usuarioId: AuthTokenService.getUserId(),          
            respostas: answers
          })
          alert(response.msg)
        }catch(err){
          alert(err.msg)
        }
      }
    }
  }



});
