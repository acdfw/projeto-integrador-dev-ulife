var teacherClasses = [
  {
    id: "ajhksdhaskjdhkajsd",
    name: "Turma A",
    assignments: [
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
    ],
  },
  {
    id: "fsdfsdfsdfsdf",
    name: "Turma B",
    assignments: [
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
    id: "sdftgerdfgvd",
    name: "Turma D",
    assignments: [
      {
        id: "bdgsdfgfd",
        name: "A1",
      },
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
    id: "gfgsdtgrevgdsfsg",
    name: "Turma F",
    assignments: [
      {
        id: "bdgsdfgfd",
        name: "A1",
      },
      {
        id: "sgfgsdfg",
        name: "A2",
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
    ],
  },
];

var teacherClass = {
  id: "asdhaskjdhjkad",
  name: "Turma A",
  assignments: [
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
};

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

let exams = [
  {
    id: "eqwdjlaklmckzc",
    name: "prova de teste 1",
    questions: examQuestions,
  },
  {
    id: "ggfhdgretfdsgrt",
    name: "prova de teste 2",
    questions: examQuestions,
  },
  {
    id: "hgfbvsfgergfdsg",
    name: "prova de teste 3",
    questions: examQuestions,
  },
  {
    id: "sdbdnbyregbhdf",
    name: "prova de teste 4",
    questions: examQuestions,
  },
];

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