app.config([
  "$routeProvider",
  function ($routeProvider) {
    $routeProvider
      .when("/", { templateUrl: "views/home.html", controller: "HomeCtrl" })
      .when("/teacher/classes", {
        templateUrl: "views/teacher/TeacherAllClasses.html",
        controller: "TeacherAllClassesCtrl",
        authorize: true,
        role: "T",
      })
      .when("/teacher/class/:id", {
        templateUrl: "views/teacher/TeacherOneClass.html",
        controller: "TeacherOneClassCtrl",
        authorize: true,
        role: "T",
      })
      .when("/teacher/assignments", {
        templateUrl: "views/teacher/TeacherAllAssignments.html",
        controller: "TeacherAllAssignmentsCtrl",
        authorize: true,
        role: "T",
      })
      .when("/teacher/assignment", {
        templateUrl: "views/teacher/TeacherOneAssignment.html",
        controller: "TeacherAssignmentCtrl",
        authorize: true,
        role: "T",
      })
      .when("/teacher/exams", {
        templateUrl: "views/teacher/TeacherAllExams.html",
        controller: "TeacherAllExamsCtrl",
        authorize: true,
        role: "T",
      })
      .when("/teacher/exam/:id", {
        templateUrl: "views/teacher/TeacherOneExam.html",
        controller: "TeacherOneExamCtrl",
        authorize: true,
        role: "T",
      })
      .when("/logout", {
        resolve: {
          logout: [
            "UserModel",
            function (UserModel) {
              UserModel.logout();
            },
          ],
        },
      })

      .when("/404", { templateUrl: "views/404.html" })
      .otherwise("/404");
  },
]);
