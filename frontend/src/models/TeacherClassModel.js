app.factory("TeacherClassModel", function ($http) {
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

      let teacherClass = {            
        id: 'asdhaskjdhjkad',
        title: 'Turma A',
        assignments : [
          {
            id: "bdgsdfgfd",
            title: "A1",
          },
          {
            id: "sgfgsdfg",
            title: "A2",
          },
          {
            id: "twtertA",
            title: "A3",
          },
          {
            id: "bgdfgsdfg",
            title: "A4",
          },
        ],
        students: [
          {
            id: "A102B3",
            name: "João",
          },
          {
            id: "A10GH4",
            name: "Maria",
          },
          {
            id: "A234DR",
            name: "Pedro",
          },
          {
            id: "SDA343",
            name: "José",
          },
          {
            id: "2133SA",
            name: "Augusto",
          },
          {
            id: "AS2343",
            name: "Fernanda",
          },
          {
            id: "FD3423",
            name: "Gabriela",
          },
        ],
      }

      return teacherClass;
    },
    getClasses: function () {

      let teacherClasses = [
        {
          id: 'ajhksdhaskjdhkajsd',
          turma: "Turma A",
          inscritos: "10",
        },
        {
          id: 'fsdfsdfsdfsdf',
          turma: "Turma B",
          inscritos: "5",
        },
        {
          id: 'sdftgerdfgvd',
          turma: "Turma D",
          inscritos: "7",
        },
        {
          id: 'gfgsdtgrevgdsfsg',
          turma: "Turma F",
          inscritos: "8",
        },
      ];

      return teacherClasses;
    },
    createClass: function () {
      return true;
    }
  };
});
