app.controller("StudentAssignmentToDoCtrl", function ($scope, AssignmentModel, $routeParams) {
  var me = $scope;

  var assignment = AssignmentModel.getStudentAssignmentById($routeParams.id);
 
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
      answers.push(answer)
    })
    return answers;
  }

  me.submitExam = () => {
    var answers = getAnswers();

    if(answers.filter(answer => answer == null).length > 0){
      if(confirm("Você não respondeu todas as perguntas. Deseja prosseguir?")){
        AssignmentModel.submit({
          assignment: assignment.id,
          answers: answers
        })
      }
    }
  }



});
