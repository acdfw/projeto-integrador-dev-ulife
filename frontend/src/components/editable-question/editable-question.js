app.directive("editableQuestion", function (QuestionModel, AuthTokenService) {
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

      me.saveQuestion = async () => {
        if(me.answer){
          me.options.forEach(
            (opt, index) => (opt.isAnswer = me.answer == index ? true : false)
          );
          try{
            response = await QuestionModel.create({
              nome: me.newQuestionName,
              enunciado: me.newQuestionStatement,
              alternativas: me.options.map((obj) => ({
                texto: obj.statement,
                alternativaCorreta: obj.isAnswer,
              })),
              usuarioId: AuthTokenService.getUserId(),
            });
            alert(response.msg)
          }catch(err){
            alert(err.err)
          }
        } else {
          alert ("Favor selecione a resposta")
        }
      };
    },
  };
});
