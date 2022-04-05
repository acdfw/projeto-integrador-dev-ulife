app.run(function ($rootScope, $location, AuthTokenService) {
  function isLogged() {
    return !AuthTokenService.getToken() ? false : true;
  }

  function CheckRole(data) {
    return AuthTokenService.getToken() == data.role;
  }

  $rootScope.$on("$routeChangeStart", function (event, next, current) {
    if (next.authorize) {
      console.log(AuthTokenService.getRole())
      if (!isLogged() || !CheckRole(next)) {
        $rootScope.$evalAsync(function () {
          $location.path("/");
        });
      }
    }
  });
});
