app.factory('authInterceptor', function ($location, AuthTokenService, $q) {
  return {
    request: function(config) {
      config.headers = config.headers || {};

      if (AuthTokenService.getToken()) {
        config.headers['Authorization'] = 'Bearer ' + AuthTokenService.getToken();
      }

      return config;
    },

    responseError: function(response) {
      if (response.status === 401 || response.status === 403) {
          AuthTokenService.logout();
        $location.path('/');
      }

      return $q.reject(response);
    }
  }
})