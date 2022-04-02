var app = angular.module("website", ["ngRoute", 'ui.tinymce', 'ngSanitize']);

app.config([
    "$routeProvider",
    function ($routeProvider) {      
      $routeProvider
        .when("/", { templateUrl: "views/home.html", controller: "HomeCtrl" })
        .when("/teacher/classes", { templateUrl: "views/teacher/TeacherClass.html", controller: "TeacherClassCtrl" })
        .when("/404", { templateUrl: "views/404.html" })
        .otherwise("/404");
    },
  ]);