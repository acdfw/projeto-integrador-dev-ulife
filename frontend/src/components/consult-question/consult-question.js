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

      me.answer = !me.content.answer ? '' : me.content.answer.id

      me.updateAnswer = (index) => {
        me.content.answer = {id: me.content.options[index].id, alternative: me.alternativeIdentifier[index]}
      }
    },
  };
});
