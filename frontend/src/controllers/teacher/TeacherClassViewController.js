app.controller(
  "TeacherClassViewCtrl",
  function (
    $scope,
    QuestionnaireModel,
    getTeacherClassInfo,
    $routeParams,
    AssignmentModel,
    $route
  ) {
    var me = $scope;

    var tableAssignments = {
      rows: getTeacherClassInfo.assignments.map((obj) => ({
        ...obj,
        link: `/teacher/assignment/${obj.id}`,
      })),
      colNames: { id: "Identificador", name: "Apelido" },
      colOrder: ["id", "name"],
      showHeader: true,
      search: { show: true },
    };

    var tableStudents = {
      rows: getTeacherClassInfo.students,
      colNames: { id: "Matrícula", name: "Nome" },
      colOrder: ["id", "name"],
      showHeader: true,
      search: {
        show: true,
      },
    };

    me.content = {
      title: getTeacherClassInfo.class.name,
      subtitles: ["Avaliações", "Alunos"],
      tables: [tableAssignments, tableStudents],
    };

    me.questionnaires = QuestionnaireModel.getQuestionnaires();

    me.CreateNewAssignment = async () => {
      var data = {
        nomeAvaliacao: me.newAssignmentName,
        provaId: me.questionnaireBase,
        turmaId: $routeParams.id,
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
