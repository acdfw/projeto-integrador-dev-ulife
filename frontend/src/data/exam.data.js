exam = {
  id: 'fasjkdhajkshjkndasjhd',
  title: 'prova de teste',
  questions: questions,
}

exams = [
  {
    id: 'eqwdjlaklmckzc',
    title: 'prova de teste 1',
    numQuestions: '10',
    link: "teacher/exam/dasdasd"

  },
  {
    id: 'ggfhdgretfdsgrt',
    title: 'prova de teste 2',
    numQuestions: '15',
    link: "teacher/exam/dasdasd"
  },
  {
    id: 'hgfbvsfgergfdsg',
    title: 'prova de teste 3',
    numQuestions: '12',
    link: "teacher/exam/dasdasd"
  },
  {
    id: 'sdbdnbyregbhdf',
    title: 'prova de teste 4',
    numQuestions: '20',
    link: "teacher/exam/dasdasd"
  },
]

var tableTeacherAssignments = {
  rows: exams,
  colNames: { title: "Titulo", numQuestions: "Número de Questões", id: "Identificador" },
  colOrder: ["id", "title", "numQuestions"],
  showHeader: false,
  search: { show: true },
};


TeacherExamsContent = {
  title: "Suas Provas",
  subtitles: [""],
  tables: [tableTeacherAssignments],
};