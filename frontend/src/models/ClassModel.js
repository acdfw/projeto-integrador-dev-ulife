app.factory("ClassModel", function ($http) {
  return {
    getTeacherClassById: function (id) {
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
        name: 'Turma A',
        assignments : [
          {
            id: "bdgsdfgfd",
            name: "A1",
          },
          {
            id: "sgfgsdfg",
            name: "A2",
          },
          {
            id: "twtertA",
            name: "A3",
          },
          {
            id: "bgdfgsdfg",
            name: "A4",
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
    getTeacherClasses: function () {

      let teacherClasses = [
        {
          id: 'ajhksdhaskjdhkajsd',
          name: "Turma A",
          assignments : [
            {
              id: "bdgsdfgfd",
              name: "A1",
            },
            {
              id: "sgfgsdfg",
              name: "A2",
            },
            {
              id: "twtertA",
              name: "A3",
            },
            {
              id: "bgdfgsdfg",
              name: "A4",
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
            }
          ],
        },
        {
          id: 'fsdfsdfsdfsdf',
          name: "Turma B",
          assignments : [
            {
              id: "bdgsdfgfd",
              name: "A1",
            },
            {
              id: "sgfgsdfg",
              name: "A2",
            },
            {
              id: "twtertA",
              name: "A3",
            },
            {
              id: "bgdfgsdfg",
              name: "A4",
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
        },
        {
          id: 'sdftgerdfgvd',
          name: "Turma D",
          assignments : [
            {
              id: "bdgsdfgfd",
              name: "A1",
            }
          ],
          students: [
            {
              id: "2133SA",
              name: "Augusto",
            },
            {
              id: "AS2343",
              name: "Fernanda",
            },          
          ],
        },
        {
          id: 'gfgsdtgrevgdsfsg',
          name: "Turma F",
          assignments : [
            {
              id: "bdgsdfgfd",
              name: "A1",
            },
            {
              id: "sgfgsdfg",
              name: "A2",
            }
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
            }
          ],
        },
      ];

      return teacherClasses;
    },

    create: function (name) {
      console.log(name)      
    },

    getStudentClassById: function (id) {
     
      let studentClass = {
        id: "asdhaskjdhjkad",
        name: "Turma A",
        teacherName: {
          id: 'dahjkshdkjad',
          name: "Ricardo"
        },
        assignments: [
          {
            id: "bdgsdfgfd",
            name: "A1",
            grade: "9.0",
          },
          {
            id: "sgfgsdfg",
            name: "A2",
            grade: null,
          },
          {
            id: "twtertA",
            name: "A3",
            grade: null,
          },
        ],
      };

      return studentClass;
    },
    getStudentClasses: function () {
      let studentClasses = [
        {
          id: "ajhksdhaskjdhkajsd",
          name: "Turma A",
          teacher: {
            id: 'dahjkshdkjad',
            name: "Ricardo"
          },
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
          name: "Turma B",
          teacher: {
            id: 'dahjkshdkjad',
            name: "Marcos"
          },
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
            },
          ],
        },
        {
          id: "sdftgerdfgvd",
          name: "Turma C",
          teacher: {
            id: 'dahjkshdkjad',
            name: "Marcos"
          },
          assignments: [
            {
              id: "dfgdgtger",
              title: "A1",
              grade: null,
            },
            {
              id: "dgdfgdgdfg",
              title: "A2",
              grade: null,
            },
            {
              id: "dhdfhdgdgddg",
              title: "A3",
              grade: null,
            },
          ],
        },
        {
          id: "sfsdsdcasfdsc",
          name: "Turma D",
          teacher: {
            id: 'dahjkshdkjad',
            name: "Claudio"
          },
          assignments: [
            {
              id: "dfgdgtger",
              title: "A1",
              grade: null,
            },
            {
              id: "dgdfgdgdfg",
              title: "A2",
              grade: null,
            },
            {
              id: "dhdfhdgdgddg",
              title: "A3",
              grade: null,
            },
          ],
        },
        {
          id: "sfsdsdcasfdsc",
          name: "Turma E",
          teacher: {
            id: 'dahjkshdkjad',
            name: "Carlos"
          },
          assignments: [
            {
              id: "dfgdgtger",
              title: "A1",
              grade: null,
            },
            {
              id: "dgdfgdgdfg",
              title: "A2",
              grade: null,
            },
            {
              id: "dhdfhdgdgddg",
              title: "A3",
              grade: null,
            },
          ],
        },
      ];

      return studentClasses;
    },
    subscribe: function () {
      return true;
    },
  };
});
