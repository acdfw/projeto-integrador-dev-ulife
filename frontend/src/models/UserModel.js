app.factory(
  "UserModel",
  function ($http, AuthTokenService, $location, $rootScope) {
    return {
      login: function (data) {
        $http({
          method: "POST",
          url: `${API_URL}/login`,
          data: data,
        }).then(function successCallback(response) {
          AuthTokenService.setRole(response.data.usuario.role);
          AuthTokenService.setToken(response.data.token);
          AuthTokenService.setUserId(response.data.usuario.id);
          if (response.data.usuario.role == "aluno") {
            $location.path("/student/classes");
          } else if (response.data.usuario.role == "professor") {
            $location.path("/teacher/classes");
          }
        });

        return true;
      },
      logout: function () {
        AuthTokenService.reset();
        $location.path("/");
      },
      register: function (data) {
        $http.post("api/signup", data);
      },
    };
  }
);
