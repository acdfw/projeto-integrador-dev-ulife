var app = angular.module("website", ["ngRoute"]);

app.config([
    "$routeProvider",
    function ($routeProvider) {
      $routeProvider
        .when("/", { templateUrl: "views/home.html", controller: "HomeCtrl" })
        .when("/404", { templateUrl: "views/404.html" })
        .otherwise("/404");
    },
  ]);