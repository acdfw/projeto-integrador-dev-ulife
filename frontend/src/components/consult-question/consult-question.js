app.directive("consultQuestion", function () {
  return {
    replace: true,
    scope: {
      content: "=",
    },
    templateUrl: "components/consult-question/consult-question.html",
    controller: function ($scope) {
      var me = $scope;

      me.alternativeIdentifier = ["A", "B", "C", "D", "E"];

      me.answer = !me.content.question.answer ? '' : me.content.question.answer.id

      me.review = me.content.review ? me.content.review.find(obj => obj.id == me.content.question.id) : null

      me.studentIsCorrect = () => {
        return me.review.studentAnswer == me.review.correctAnswer  
      }

      me.updateAnswer = (index) => {
        me.content.question.answer = {id: me.content.question.options[index].id, alternative: me.alternativeIdentifier[index]}
      }
    },
  };
});
