app.run(function ($rootScope, $location, AuthTokenService) {
  function isLogged() {
    return !AuthTokenService.getToken() ? false : true;
  }

  function CheckRole(data) {
    return AuthTokenService.getRole() == data.role;
  }

  $rootScope.$on("$routeChangeStart", function (event, next, current) {
    if (next.authorize) {
      if (!isLogged() || !CheckRole(next)) {
        $rootScope.$evalAsync(function () {
          $location.path("/");
        });
      }
    }
  });
});
