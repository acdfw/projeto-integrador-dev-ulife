app.config([
  "$routeProvider",
  function ($routeProvider) {
    $routeProvider
    .when("/student/assignment-todo/:id", {
      templateUrl: "views/student/StudentAssignmentToDo.html",
      controller: "StudentAssignmentToDoCtrl",
      authorize: true,
      role: "S",
    })
    .when("/student/assignment-done/:id", {
      templateUrl: "views/student/StudentAssignmentDone.html",
      controller: "StudentAssignmentDoneCtrl",
      authorize: true,
      role: "S",
    })
    .when("/student/assignments", {
      templateUrl: "views/student/StudentAssignmentsList.html",
      controller: "StudentAssignmentsListCtrl",
      authorize: true,
      role: "S",
    })
    .when("/student/classes", {
      templateUrl: "views/student/StudentClassesList.html",
      controller: "StudentClassesListCtrl",
      authorize: true,
      role: "S",
    })
    .when("/student/class/:id", {
      templateUrl: "views/student/StudentClassView.html",
      controller: "StudentClassViewCtrl",
      authorize: true,
      role: "S",
    });
  },
]);
