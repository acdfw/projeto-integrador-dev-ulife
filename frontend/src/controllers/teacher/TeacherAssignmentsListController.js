app.controller(
  "TeacherAssignmentsListCtrl",
  function ($scope, getInfo, $route) {
    var me = $scope;

    var assignments = getInfo.assignments;

    me.assignmentsTable = {
      rows: assignments.map((obj) => ({
        class: obj.class.name,
        assignment: obj.name,
        questionnaire: obj.questionnaire.name,
        done: obj.done.toString(),
        link: `teacher/assignment/${obj.id}`,
      })),
      colNames: { class: "Turma", assignment: "Avaliação", questionnaire: "Questionário", done: "Realizadas" },
      colOrder: ["class", "assignment", "questionnaire", "done"],
      showHeader: true,
      search: { show: true },
    };

    me.questionnaires = getInfo.questionnaires;

    me.classes = getInfo.classes

    me.CreateNewAssignment = async () => {
      var data = {
        nomeAvaliacao: me.newAssignmentName,
        provaId: me.questionnaireBase,
        turmaId: me.targetClass,
      };
      try {
        response = await AssignmentModel.create(data);
        alert(response.msg);
      } catch (err) {
        alert(err.err);
      }
      $route.reload();
    };
  }
);
