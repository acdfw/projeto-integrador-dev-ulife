app.factory("ClassModel", function ($http, AuthTokenService) {
  return {
    getTeacherClassById: function (id) {
      return new Promise((resolve, reject) => {
        $http({
          method: "GET",
          url: `${API_URL}/Turma/${id}`,
        }).then(function successCallback(response) {
          obj = response.data
          let teacherClass = {
            id: obj.id,
            name: obj.nomeTurma
          };
          resolve(teacherClass);
        });
      });
    },
    getTeacherClasses: async function (id) {
      return new Promise((resolve, reject) => {
        $http({
          method: "GET",
          url: `${API_URL}/Professor/${id}/turmas-inscritos-avaliacoes`,
        }).then(function successCallback(response) {
          let teacherClasses = response.data.map((obj) => ({
            id: obj.idTurma,
            name: obj.nomeTurma,
            members: obj.quantidadeInscritos.toString(),
            assignments: obj.quantidadeAvaliacoes.toString(),
          }));
          resolve(teacherClasses);
        });
      });
    },

    create: function (data) {
      return new Promise((resolve, reject) => {
        $http({
          method: "POST",
          url: `${API_URL}/Turma`,
          data: data
        }).then(response => {
          resolve({msg: response.data})
        }).catch(err => {
          reject({msg: err.data})
        });
      });
    },

    getStudentClassById: function (id) {
      let studentClass = {
        id: "asdhaskjdhjkad",
        name: "Turma A",
        teacherName: {
          id: "dahjkshdkjad",
          name: "Ricardo",
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
            id: "dahjkshdkjad",
            name: "Ricardo",
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
            id: "dahjkshdkjad",
            name: "Marcos",
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
            id: "dahjkshdkjad",
            name: "Marcos",
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
            id: "dahjkshdkjad",
            name: "Claudio",
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
            id: "dahjkshdkjad",
            name: "Carlos",
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
