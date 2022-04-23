app.config([
  "$routeProvider",
  function ($routeProvider) {
    $routeProvider
      .when("/teacher/classes", {
        templateUrl: "views/teacher/TeacherClassesList.html",
        controller: "TeacherClassesListCtrl",
        authorize: true,
        role: "professor",
        resolve: {
          getTeacherClasses: function (ClassModel) {
            return ClassModel.getTeacherClasses();
          },
        },
      })
      .when("/teacher/class/:id", {
        templateUrl: "views/teacher/TeacherClassView.html",
        controller: "TeacherClassViewCtrl",
        authorize: true,
        role: "professor",
        resolve: {
          getTeacherClassInfo: function (
            AssignmentModel,
            StudentModel,
            $route,
            $q
          ) {
            return $q.all({
              assignments: AssignmentModel.getTeacherAssignmentsByClassId(
                $route.current.params.id
              ),
              students: StudentModel.getTeacherStudentsByClassId(
                $route.current.params.id
              ),
            });
          },
        },
      })
      .when("/teacher/assignments", {
        templateUrl: "views/teacher/TeacherAssignmentsList.html",
        controller: "TeacherAssignmentsListCtrl",
        authorize: true,
        role: "professor",
        resolve: {
          getAssignments: function(AssignmentModel, AuthTokenService){
            return AssignmentModel.getTeacherAssignments(AuthTokenService.getUserId());
          }
        }
      })
      .when("/teacher/assignment/:id", {
        templateUrl: "views/teacher/TeacherAssignmentView.html",
        controller: "TeacherAssignmentViewCtrl",
        authorize: true,
        role: "professor",
        resolve: {
          getTeacherAssignmentInfo: function (
            AssignmentModel,
            $route,
            $q
          ) {
            return $q.all({
              assignment: AssignmentModel.getTeacherAssignmentById(
                $route.current.params.id
              ),
              studentsResults: AssignmentModel.getTeacherGradesByAssignmentId(
                $route.current.params.id
              ),
            });
          },
        },
      })
      .when("/teacher/assignment-done/:id", {
        templateUrl: "views/teacher/TeacherAssignmentDone.html",
        controller: "TeacherAssignmentDoneCtrl",
        authorize: true,
        role: "professor",
      })
      .when("/teacher/questionnaires", {
        templateUrl: "views/teacher/TeacherQuestionnairesList.html",
        controller: "TeacherQuestionnairesListCtrl",
        authorize: true,
        role: "professor",
      })
      .when("/teacher/questionnaire/:id", {
        templateUrl: "views/teacher/TeacherQuestionnaireView.html",
        controller: "TeacherQuestionnaireViewCtrl",
        authorize: true,
        role: "professor",
      })
      .when("/teacher/questions", {
        templateUrl: "views/teacher/TeacherQuestionsList.html",
        controller: "TeacherQuestionsListCtrl",
        authorize: true,
        role: "professor",
      })
      .when("/teacher/question/:id", {
        templateUrl: "views/teacher/TeacherQuestionView.html",
        controller: "TeacherQuestionViewCtrl",
        authorize: true,
        role: "professor",
      })
      .when("/teacher/new-question", {
        templateUrl: "views/teacher/TeacherQuestionNew.html",
        controller: "TeacherQuestionNewCtrl",
        authorize: true,
        role: "professor",
      });
  },
]);
