app.factory("AssignmentModel", function ($http) {
  return {
    getTeacherAssignmentById: function (id) {
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
      assignment = {
        id: "hshadajsdhajd",
        name: "A1",
        class: { id: "dasdakdsl", name: "Turma A" },
        questionnaire: {id: "dadsasdasd", name: "prova teste", questions: examQuestions},
        studentsResults: [
          {
            id: 'fasfdfafs',
            student: {
              id: 'fsldflkasdlk',
              name: 'João'
            },
            grade: '10.0'
          },
          {
            id: 'fasfdfafs',
            student: {
              id: 'fsldflkasdlk',
              name: 'Hélio'
            },
            grade: '10.0'
          },
          {
            id: 'fasfdfafs',
            student: {
              id: 'fsldflkasdlk',
              name: 'Matheus'
            },
            grade: '9.0'
          },
          {
            id: 'fasfdfafs',
            student: {
              id: 'fsldflkasdlk',
              name: 'Gilberto'
            },
            grade: '5.0'
          },
          {
            id: 'fasfdfafs',
            student: {
              id: 'fsldflkasdlk',
              name: 'Marcelo'
            },
            grade: '7.5'
          },
          {
            id: 'fasfdfafs',
            student: {
              id: 'fsldflkasdlk',
              name: 'Gabriela'
            },
            grade: '8.5'
          },
          {
            id: 'fasfdfafs',
            student: {
              id: 'fsldflkasdlk',
              name: 'Fernanda'
            },
            grade: '7.5'
          },
          {
            id: 'fasfdfafs',
            student: {
              id: 'fsldflkasdlk',
              name: 'Daniel'
            },
            grade: null
          },
          {
            id: 'fasfdfafs',
            student: {
              id: 'fsldflkasdlk',
              name: 'Geralda'
            },
            grade: null
          },
          {
            id: 'fasfdfafs',
            student: {
              id: 'fsldflkasdlk',
              name: 'Amanda'
            },
            grade: null
          }
        ]
      };

      return assignment;
    },
    getTeacherAssignments: function () {

      teacherAssignments = [
        {
          id: "hshadajsdhajd",
          name: "A1",
          class: { id: "dasdakdsl", name: "Turma A" },
          questionnaire: {id: "dadsasdasd", name: "P_123143", questions: examQuestions},
          done: [
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'João'
              },
              grade: '10.0'
            },
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'João'
              },
              grade: '10.0'
            },
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'Matheus'
              },
              grade: '9.0'
            },
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'Gilberto'
              },
              grade: '5.0'
            },
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'Marcelo'
              },
              grade: '7.5'
            }
          ]
        },
        {
          id: "hshadajsdhajd",
          name: "A2",
          class: { id: "dasdakdsl", name: "Turma A" },
          questionnaire: {id: "dadsasdasd", name: "P_5234324", questions: examQuestions},
          done: [
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'João'
              },
              grade: '10.0'
            },
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'Matheus'
              },
              grade: '9.0'
            },
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'Gilberto'
              },
              grade: '5.0'
            },
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'Marcelo'
              },
              grade: '7.5'
            }
          ]
        },
        {
          id: "hshadajsdhajd",
          name: "A1",
          class: { id: "dasdakdsl", name: "Turma B" },
          questionnaire: {id: "dadsasdasd", name: "P_4132748", questions: examQuestions},
          done: [
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'João'
              },
              grade: '10.0'
            },
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'João'
              },
              grade: '10.0'
            },
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'Matheus'
              },
              grade: '9.0'
            },
          ]
        },
        {
          id: "hshadajsdhajd",
          name: "A1",
          class: { id: "dasdakdsl", name: "Turma C" },
          questionnaire: {id: "dadsasdasd", name: "P_231413", questions: examQuestions},
          done: [
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'João'
              },
              grade: '10.0'
            },
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'João'
              },
              grade: '10.0'
            },
            {
              id: 'fasfdfafs',
              student: {
                id: 'fsldflkasdlk',
                name: 'Matheus'
              },
              grade: '9.0'
            },        
          ]
        }
      ]

      return teacherAssignments;
    },
    create: function () {
      return true;
    },
    getStudentAssignmentById: function (id) {
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

      assignment = {
        id: "hshadajsdhajd",
        name: "A1",
        class: { id: "dasdakdsl", name: "Turma A" },
        teacher: { id: "dasdakdsl", name: "Ricardo" },
        questionnaire: {id: "dadsasdasd", name: "prova teste", questions: examQuestions},
        studentResult: {
          id: null,
          grade: null
        }
      };

      return assignment;
    },
    getStudentAssignments: function () {

      assignments = [
        {
          id: "hshadajsdhajd",
          name: "A1",
          class: { id: "dasdakdsl", name: "Turma A" },
          teacher: { id: "dasdakdsl", name: "Ricardo" },
          questionnaire: {id: "dadsasdasd", name: "prova teste", questions: examQuestions},
          studentResult: {
            id: 'sdvcdjfwejkc',
            grade: '9.5'
          }
        },
        {
          id: "hshadajsdhajd",
          name: "A2",
          class: { id: "dasdakdsl", name: "Turma A" },
          teacher: { id: "dasdakdsl", name: "Ricardo" },
          questionnaire: {id: "dadsasdasd", name: "prova teste", questions: examQuestions},
          studentResult: {
            id: 'fjsdkfnkjscd',
            grade: '10.0'
          }
        },
        {
          id: "hshadajsdhajd",
          name: "A3",
          class: { id: "dasdakdsl", name: "Turma A" },
          teacher: { id: "dasdakdsl", name: "Ricardo" },
          questionnaire: {id: "dadsasdasd", name: "prova teste", questions: examQuestions},
          studentResult: null
        },
        {
          id: "hshadajsdhajd",
          name: "A1",
          class: { id: "dasdakdsl", name: "Turma B" },
          teacher: { id: "dasdakdsl", name: "Matheus" },
          questionnaire: {id: "dadsasdasd", name: "prova teste", questions: examQuestions},
          studentResult: {
            id: 'fsdfgsfddsgv',
            grade: '8.5'
          } 
        },
        {
          id: "hshadajsdhajd",
          name: "A2",
          class: { id: "dasdakdsl", name: "Turma B" },
          teacher: { id: "dasdakdsl", name: "Matheus" },
          questionnaire: {id: "dadsasdasd", name: "prova teste", questions: examQuestions},
          studentResult: {
            id: 'dasdasfdvc xs',
            grade: '9.0'
          }
        },
        {
          id: "hshadajsdhajd",
          name: "A3",
          class: { id: "dasdakdsl", name: "Turma B" },
          teacher: { id: "dasdakdsl", name: "Matheus" },
          questionnaire: {id: "dadsasdasd", name: "prova teste", questions: examQuestions},
          studentResult: null
        },
        {
          id: "hshadajsdhajd",
          name: "A1",
          class: { id: "dasdakdsl", name: "Turma C" },
          teacher: { id: "dasdakdsl", name: "João" },
          questionnaire: {id: "dadsasdasd", name: "prova teste", questions: examQuestions},
          studentResult: null
        },
      ]

      return assignments;
    },
    getDoneAssignmentById: (id) => {
      assignment = {
        id: "hshadajsdhajd",
        name: "A1",
        class: { id: "dasdakdsl", name: "Turma A" },
        student: { id: "dasdakdsl", name: "Brunp" },
        teacher: { id: "dasdakdsl", name: "Ricardo" },
        questionnaire: {id: "dadsasdasd", name: "prova teste", questions: examQuestions},
        studentResult: {
          id: 'sdvcdjfwejkc',
          grade: '9.5',
          questions: [
            {
              id: 'dkjasheknewqdasd',
              studentAnswer: 'daskfmkldfklsadlksamd',
              correctAnswer: 'daskfmkldfklsadlksamd'
            },
            {
              id: 'dasffwefsawdfsadsf',
              studentAnswer: 'dasdasdgrefsdfsgdf',
              correctAnswer: 'gsgfdhdfgfdtertjhr'
            },
            {
              id: 'gfsdcsdgrtweger',
              studentAnswer: 'gsgfdhdfgfdtertjhr',
              correctAnswer: 'fsgsfdgterteergdfg'
            },
            {
              id: 'asdgsaewrqefdqwf',
              studentAnswer: 'fsgsfdgterteergdfg',
              correctAnswer: 'fsgsfdgterteergdfg'
            },
            {
              id: 'gsadwerewqgfdsbfdgh',
              studentAnswer: 'gsgfdhdfgfdtertjhr',
              correctAnswer: 'gsgfdhdfgfdtertjhr'
            },
            {
              id: 'sfgtrewthdgsbsdgfhb',
              studentAnswer: 'nfgtrygfdshetrwgdsf',
              correctAnswer: 'nfgtrygfdshetrwgdsf'
            },
            {
              id: 'bregvdcxvsert',
              studentAnswer: null,
              correctAnswer: 'dasdasdgrefsdfsgdf'
            },
            {
              id: 'dvgergdgfhtyhtyb',
              studentAnswer: 'nfgtrygfdshetrwgdsf',
              correctAnswer: 'nfgtrygfdshetrwgdsf'
            },
            {
              id: 'bgsvthwnhrj',
              studentAnswer: 'dasdasdgrefsdfsgdf',
              correctAnswer: 'fsgsfdgterteergdfg'
            },
            {
              id: 'vefrhytkrtjyhnhr',
              studentAnswer: 'daskfmkldfklsadlksamd',
              correctAnswer: 'gsgfdhdfgfdtertjhr'
            },
          ]
        }        
      }
      return assignment;
    },
    submit: function (obj) {
      console.log(obj)
    },
  };
});
