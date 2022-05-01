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
      if (response.status === 401) {
        $location.path('/401');
      }
      if (response.status === 403) {
        $location.path('/403');
      }

      return $q.reject(response);
    }
  }
})