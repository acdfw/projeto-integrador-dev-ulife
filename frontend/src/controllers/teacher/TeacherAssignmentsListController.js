app.controller(
  "TeacherAssignmentsListCtrl",
  function ($scope, getAssignments, QuestionnaireModel, ClassModel) {
    var me = $scope;

    var assignments = getAssignments;

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

    me.questionnaires = QuestionnaireModel.getQuestionnaires();

    me.classes = ClassModel.getTeacherClasses();
  }
);
