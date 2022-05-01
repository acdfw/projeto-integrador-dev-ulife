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
      
      return studentClasses;
    },
    subscribe: function () {
      return true;
    },
  };
});
