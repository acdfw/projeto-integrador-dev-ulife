app.config([
  "$routeProvider",
  function ($routeProvider) {
      $routeProvider
        .when("/teacher/classes", {
          templateUrl: 'views/teacher/TeacherClassesList.html',
          controller: "TeacherClassesListCtrl",
          authorize: true,
          role: "T",
        })
        .when("/teacher/class/:id", {
          templateUrl: 'views/teacher/TeacherClassView.html',
          controller: "TeacherClassViewCtrl",
          authorize: true,
          role: "T",
        })
        .when("/teacher/assignments", {
          templateUrl: 'views/teacher/TeacherAssignmentsList.html',
          controller: "TeacherAssignmentsListCtrl",
          authorize: true,
          role: "T",
        })
        .when("/teacher/assignment/:id", {
          templateUrl: 'views/teacher/TeacherAssignmentView.html',
          controller: "TeacherAssignmentViewCtrl",
          authorize: true,
          role: "T",
        })
        .when("/teacher/questionnaires", {
          templateUrl: 'views/teacher/TeacherQuestionnairesList.html',
          controller: "TeacherQuestionnairesListCtrl",
          authorize: true,
          role: "T",
        })
        .when("/teacher/questionnaire/:id", {
          templateUrl: 'views/teacher/TeacherQuestionnaireView.html',
          controller: "TeacherQuestionnaireViewCtrl",
          authorize: true,
          role: "T",
        })  
        .when("/teacher/questions", {
          templateUrl: 'views/teacher/TeacherQuestionsList.html',
          controller: "TeacherQuestionsListCtrl",
          authorize: true,
          role: "T",
        })       
        .when("/teacher/question/:id", {
          templateUrl: 'views/teacher/TeacherQuestionView.html',
          controller: "TeacherQuestionViewCtrl",
          authorize: true,
          role: "T",
        }) 
        .when("/teacher/new-question", {
          templateUrl: 'views/teacher/TeacherQuestionNew.html',
          controller: "TeacherQuestionNewCtrl",
          authorize: true,
          role: "T",
        }) 
    },
  ]);