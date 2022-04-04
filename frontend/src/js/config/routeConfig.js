app.config([
  "$routeProvider",
  function ($routeProvider) {
    $routeProvider
      .when("/", { templateUrl: "views/home.html", controller: "HomeCtrl" })
      .when("/teacher/class/:id", {
        templateUrl: "views/teacher/TeacherClass.html",
        controller: "TeacherClassCtrl",
        authorize: true,
        role: "T",
      })
      .when("/teacher/classes", {
        templateUrl: "views/teacher/TeacherClasses.html",
        controller: "TeacherClassesCtrl",
        authorize: true,
        role: "T",
      })
      .when("/teacher/assignments", {
        templateUrl: "views/teacher/TeacherAssignments.html",
        controller: "TeacherAssignmentsCtrl",
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
