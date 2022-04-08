app.directive("editableQuestion", function () {
  return {
    replace: true,
    scope: {
      content: "=",
    },
    templateUrl: "components/editable-question/editable-question.html",
    controller: function ($scope) {
      var me = $scope;

      me.options = []

      NUM_OPTIONS = 5;

      for(var i=0; i<NUM_OPTIONS; i++){
        me.options.push({text: "", isAnswer: false})
      }

      me.tinymceOptions = {
        resize: true,
        plugins: 'print textcolor link image',
        toolbar: "undo redo | styleselect | bold italic underline | forecolor backcolor | link image | alignleft aligncenter alignright alignjustify | outdent indent | print"

    };

    },
  };
});
