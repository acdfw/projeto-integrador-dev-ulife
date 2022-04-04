app.factory("UserModel", function ($http, AuthTokenService) {
  return {
    login: function (data) {
      // $http({
      //     method: 'GET',
      //     url: '/someUrl'
      //   }).then(function successCallback(response) {
      //       // this callback will be called asynchronously
      //       // when the response is available
      //     }, function errorCallback(response) {
      //       // called asynchronously if an error occurs
      //       // or server returns response with an error status.
      //     });

      AuthTokenService.setToken(data);
      AuthTokenService.setRole(data);
      return true;
    },
    logout: function () {
        AuthTokenService.reset();

    },
    register: function (data) {
      $http.post("api/signup", data);
    },
  };
});
