app.factory("StudentClassModel", function ($http) {
  return {
    getClassById: function (id) {
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

      let studentClass = {
        id: "asdhaskjdhjkad",
        title: "Turma A",
        teacherName: "Ricardo",
        assignments: [
          {
            id: "bdgsdfgfd",
            title: "A1",
            grade: "9.0",
          },
          {
            id: "sgfgsdfg",
            title: "A2",
            grade: null,
          },
          {
            id: "twtertA",
            title: "A3",
            grade: null,
          },
        ],
      };

      return studentClass;
    },
    getClasses: function () {
      let studentClasses = [
        {
          id: "ajhksdhaskjdhkajsd",
          className: "Turma A",
          teacherName: "Ricardo",
          registration: "hdjkahdkjahsdkja",
          assignments: [
            {
              id: "jakjdhjkashda",
              title: "A1",
              grade: "9.0",
            },
            {
              id: "gdfgdfgdfg",
              title: "A2",
              grade: null,
            },
            {
              id: "htrhggfhgge",
              title: "A3",
              grade: null,
            },
          ],
        },
        {
          id: "fsdfsdfsdfsdf",
          className: "Turma B",
          teacherName: "Ricardo",
          registration: "ferstvtrgrbvd",
          assignments: [
            {
              id: "dfgdgtger",
              title: "A1",
              grade: "9.0",
            },
            {
              id: "dgdfgdgdfg",
              title: "A2",
              grade: "8.5",
            },
            {
              id: "dhdfhdgdgddg",
              title: "A3",
              grade: null,
              assignments: null
            },
          ],
        },
        {
          id: "sdftgerdfgvd",
          className: "Turma C",
          teacherName: "João",
          registration: null,
          assignments: null
        },
        {
          id: "sfsdsdcasfdsc",
          className: "Turma D",
          teacherName: "Carlos",
          registration: null,
          assignments: null
        },
        {
          id: "sfsdsdcasfdsc",
          className: "Turma E",
          teacherName: "Manoel",
          registration: null,
          assignments: null
        },
      ];

      return studentClasses;
    },
    subscribeClass: function () {
      return true;
    },
  };
});
