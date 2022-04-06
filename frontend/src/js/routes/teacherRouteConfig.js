app.config([
  "$routeProvider",
  function ($routeProvider) {
      $routeProvider
        .when("/teacher/classes", {
          templateUrl: 'views/teacher/ClassesList.html',
          controller: "ClassesListCtrl",
          authorize: true,
          role: "T",
        })
        .when("/teacher/class/:id", {
          templateUrl: 'views/teacher/ClassView.html',
          controller: "ClassViewCtrl",
          authorize: true,
          role: "T",
        })
        .when("/teacher/assignments", {
          templateUrl: 'views/teacher/AssignmentsList.html',
          controller: "AssignmentsListCtrl",
          authorize: true,
          role: "T",
        })
        .when("/teacher/assignment/:id", {
          templateUrl: 'views/teacher/AssignmentView.html',
          controller: "AssignmentViewCtrl",
          authorize: true,
          role: "T",
        })
        .when("/teacher/exams", {
          templateUrl: 'views/teacher/ExamsList.html',
          controller: "ExamsListCtrl",
          authorize: true,
          role: "T",
        })
        .when("/teacher/exam/:id", {
          templateUrl: 'views/teacher/ExamView.html',
          controller: "ExamViewCtrl",
          authorize: true,
          role: "T",
        })        
    },
  ]);