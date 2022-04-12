app.factory("StudentAssignmentModel", function ($http) {
  return {
    getAssignmentById: function (id) {
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

      return true;
    },
    getAssignments: function () {

      studentAssignments = [
        {
          id: 'hdkahdakjds',
          class_id: 'ajhksdhaskjdhkajsd',
          title: 'A1',
          teacherName
        }
      ]


      return true;
    },
    createAssignment: function () {
      return true;
    },
    submitAssignment: function () {
      return true;
    }
  };
});
