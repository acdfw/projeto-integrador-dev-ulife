app.factory("AssignmentModel", function ($http) {
  return {
    getTeacherAssignments: function (id) {
      return new Promise((resolve, reject) => {
        $http({
          method: "GET",
          url: `${API_URL}/Professor/${id}/turmas/avaliacoes`,
        }).then(function successCallback(response) {
          let assignments = response.data.map((obj) => ({
            id: obj.idAvaliacao,
            name: obj.nomeAvaliacao,
            class: { id: obj.idTurma, name: obj.nomeTurma },
            questionnaire: { name: obj.nomeProva },
            done: obj.qtdRealizadas,
          }));
          resolve(assignments);
        });
      });
    },
    create: function (data) {
      return new Promise((resolve, reject) => {
        $http({
          method: "POST",
          url: `${API_URL}/Avaliacao`,
          data: data,
        })
          .then((response) => {
            resolve({ msg: response.data });
          })
          .catch((err) => {
            reject({ msg: err.data });
          });
      });
    },
    getStudentAssignmentById: function (id) {
      assignment = {
        id: "hshadajsdhajd",
        name: "A1",
        class: { id: "dasdakdsl", name: "Turma A" },
        teacher: { id: "dasdakdsl", name: "Ricardo" },
        questionnaire: {
          id: "dadsasdasd",
          name: "prova teste",
          questions: examQuestions,
        },
        studentResult: {
          id: null,
          grade: null,
        },
      };

      return assignment;
    },
    getStudentAssignments: function () {
      return new Promise((resolve, reject) => {
        $http({
          method: "GET",
          url: `${API_URL}/Aluno/${id}/turma/avaliacoes`,
        }).then(function successCallback(response) {
          let assignments = response.data.map((obj) => ({
            id: obj.idAvaliacao,
            name: obj.nomeAvaliacao,
            class: { id: obj.idTurma, name: obj.nomeTurma },
            teacher: { id: obj.id, name: obj.nomeProfessor },
            studentResult: obj.nota
              ? { id: obj.avaliacaoMatriculaId, grade: obj.nota }
              : null,
          }));
          resolve(assignments);
        });
      });
    },
    getDoneAssignmentById: (id) => {
      assignment = {
        id: "hshadajsdhajd",
        name: "A1",
        class: { id: "dasdakdsl", name: "Turma A" },
        student: { id: "dasdakdsl", name: "Bruno" },
        teacher: { id: "dasdakdsl", name: "Ricardo" },
        questionnaire: {
          id: "dadsasdasd",
          name: "prova teste",
          questions: examQuestions,
        },
        studentResult: {
          id: "sdvcdjfwejkc",
          grade: "9.5",
          questions: [
            {
              id: "dkjasheknewqdasd",
              studentAnswer: "daskfmkldfklsadlksamd",
              correctAnswer: "daskfmkldfklsadlksamd",
            },
            {
              id: "dasffwefsawdfsadsf",
              studentAnswer: "dasdasdgrefsdfsgdf",
              correctAnswer: "gsgfdhdfgfdtertjhr",
            },
            {
              id: "gfsdcsdgrtweger",
              studentAnswer: "gsgfdhdfgfdtertjhr",
              correctAnswer: "fsgsfdgterteergdfg",
            },
            {
              id: "asdgsaewrqefdqwf",
              studentAnswer: "fsgsfdgterteergdfg",
              correctAnswer: "fsgsfdgterteergdfg",
            },
            {
              id: "gsadwerewqgfdsbfdgh",
              studentAnswer: "gsgfdhdfgfdtertjhr",
              correctAnswer: "gsgfdhdfgfdtertjhr",
            },
            {
              id: "sfgtrewthdgsbsdgfhb",
              studentAnswer: "nfgtrygfdshetrwgdsf",
              correctAnswer: "nfgtrygfdshetrwgdsf",
            },
            {
              id: "bregvdcxvsert",
              studentAnswer: null,
              correctAnswer: "dasdasdgrefsdfsgdf",
            },
            {
              id: "dvgergdgfhtyhtyb",
              studentAnswer: "nfgtrygfdshetrwgdsf",
              correctAnswer: "nfgtrygfdshetrwgdsf",
            },
            {
              id: "bgsvthwnhrj",
              studentAnswer: "dasdasdgrefsdfsgdf",
              correctAnswer: "fsgsfdgterteergdfg",
            },
            {
              id: "vefrhytkrtjyhnhr",
              studentAnswer: "daskfmkldfklsadlksamd",
              correctAnswer: "gsgfdhdfgfdtertjhr",
            },
          ],
        },
      };
      return assignment;
    },
    submit: function (obj) {
      console.log(obj);
    },
    getTeacherAssignmentsByClassId: async function (id) {
      return new Promise((resolve, reject) => {
        $http({
          method: "GET",
          url: `${API_URL}/Turma/${id}/avaliacoes`,
        }).then(function successCallback(response) {
          let teacherAssignmentsByClass = response.data.map((obj) => ({
            id: obj.identificador,
            name: obj.nomeAvaliacao,
          }));
          resolve(teacherAssignmentsByClass);
        });
      });
    },
    getTeacherAssignmentById: function (id) {
      return new Promise((resolve, reject) => {
        $http({
          method: "GET",
          url: `${API_URL}/Avaliacao/${id}/prova/questoes`,
        }).then(function successCallback(response) {
          let obj = response.data;
          let assignment = {
            name: obj.nomeAvaliacao,
            class: { name: obj.nomeTurma },
            questionnaire: {
              name: obj.nomeProva,
              questions: obj.questoes.map((question) => ({
                id: question.id,
                title: question.nomeQuestao,
                statement: question.enunciado,
                options: question.alternativas.map((opt) => ({
                  id: opt.id,
                  statement: opt.texto,
                })),
              })),
            },
          };
          resolve(assignment);
        });
      });
    },
    getTeacherGradesByAssignmentId: function (id) {
      return new Promise((resolve, reject) => {
        $http({
          method: "GET",
          url: `${API_URL}/Avaliacao/${id}/alunos-matriculados-notas`,
        }).then(function successCallback(response) {
          let studentsResults = response.data.map((obj) => ({
            id: obj.matricula,
            name: obj.nomeAluno,
            grade: obj.nota,
          }));
          resolve(studentsResults);
        });
      });
    },
  };
});
