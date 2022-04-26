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
      .otherwise("/404");
  },
]);
