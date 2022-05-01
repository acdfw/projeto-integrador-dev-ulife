app.config([
  "$routeProvider",
  function ($routeProvider) {
    $routeProvider
      .when("/", { templateUrl: "views/home.html", controller: "HomeCtrl" })  
      .when("/about", { templateUrl: "views/about.html", controller: "AboutCtrl" })     
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
      .when("/401", { templateUrl: "views/401.html" })
      .when("/403", { templateUrl: "views/403.html" })
      .otherwise("/404");
  },
]);
