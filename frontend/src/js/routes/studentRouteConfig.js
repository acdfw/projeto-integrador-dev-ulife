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
    .when("/student/classes", {
      templateUrl: "views/student/StudentClassesList.html",
      controller: "StudentClassesListCtrl",
      authorize: true,
      role: "S",
    });
  },
]);
