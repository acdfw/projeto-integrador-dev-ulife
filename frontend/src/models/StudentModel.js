app.factory("StudentModel", function ($http) {
  return {
    getTeacherStudentsByClassId: async function (id) {
      return new Promise((resolve, reject) => {
        $http({
          method: "GET",
          url: `${API_URL}/Turma/${id}/alunos-matriculados`,
        }).then(function successCallback(response) {
          let teacherStudentsByClass = response.data.map((obj) => ({
            id: obj.matricula,
            name: obj.nomeAluno
          }));
          resolve(teacherStudentsByClass);
        });
      });
    },
  };
});
