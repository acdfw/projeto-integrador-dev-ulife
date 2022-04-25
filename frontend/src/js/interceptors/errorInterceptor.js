app.factory("errorInterceptor", function ($q, $location) {
  return {
    responseError: function (rejection) {
      if(rejection.status == 404) $location.path("/404")
      if(rejection.status == 401) $location.path("/404")
      return $q.reject(rejection);
    },
  };
});
