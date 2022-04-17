app.directive("editableQuestion", function (QuestionModel) {
  return {
    replace: true,
    scope: {
      content: "=",
    },
    templateUrl: "components/editable-question/editable-question.html",
    controller: function ($scope) {
      var me = $scope;

      me.options = [];

      NUM_OPTIONS = 5;

      for (var i = 0; i < NUM_OPTIONS; i++) {
        me.options.push({ statement: "", isAnswer: false });
      }

      me.tinymceOptions = {
        resize: true,
        plugins: "print textcolor link image",
        toolbar:
          "undo redo | styleselect | bold italic underline | forecolor backcolor | link image | alignleft aligncenter alignright alignjustify | outdent indent | print",
      };

      me.saveQuestion = () => {
        me.options.forEach((opt, index) => opt.isAnswer = (me.answer == index) ? true : false)
        QuestionModel.create({ name: me.newQuestionName, statement: me.newQuestionStatement, options: me.options});
      };
    },
  };
});
