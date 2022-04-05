app.factory("timestampInterceptor", function ($q) {
  return {
    request: function (config) {
      var { url } = config;
      if (url.indexOf("viw") > -1) return config;
      var timestamp = new Date().getTime();
      config.url = url + '?timestamp='+ timestamp;
      return config;
    },
  };
});
