app.factory("UserModel", function ($http, AuthTokenService, $location, $rootScope) {
  return {
    login: function (data) {
      $http({
          method: 'POST',
          url: '/login',
          data: data
        }).then(function successCallback(response) {
          AuthTokenService.setRole(response.data.usuario.role)
          AuthTokenService.setToken(response.data.token)
          if(response.data.usuario.role == "professor"){
            $location.path('/student/classes');
          }else if(response.data.usuario.role == "professor"){
            $location.path('/teacher/classes');
          }
          console.log(response)
          }, function errorCallback(response) {
            // called asynchronously if an error occurs
            // or server returns response with an error status.
          });
            
      return true;
    },
    logout: function () {
        AuthTokenService.reset();
        $location.path('/');
    },
    register: function (data) {
      $http.post("api/signup", data);
    },
  };
});
