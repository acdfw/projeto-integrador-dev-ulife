var tableClassExams = {
  rows: [
    {
      turma: "Turma A",
      avaliacao: "A1",
    },
    {
      turma: "Turma A",
      avaliacao: "A2",
    },
    {
      turma: "Turma B",
      avaliacao: "A1",
    },
    {
      turma: "Turma B",
      avaliacao: "A1",
    },
  ],
  colNames: { turma: "Turma", avaliacao: "Avaliação" },
  colOrder: ["turma", "avaliacao"],
  showHeader: true,
  search: { show: false },
};

var tableStudents = {
  rows: [
    {
      matricula: "A102B3",
      nome: "João",
    },
    {
      matricula: "A10GH4",
      nome: "Maria",
    },
    {
      matricula: "A234DR",
      nome: "Pedro",
    },
    {
      matricula: "SDA343",
      nome: "José",
    },
    {
      matricula: "2133SA",
      nome: "Augusto",
    },
    {
      matricula: "AS2343",
      nome: "Fernanda",
    },
    {
      matricula: "FD3423",
      nome: "Gabriela",
    },
  ],
  colNames: { matricula: "Matrícula", nome: "Nome" },
  colOrder: ["matricula", "nome"],
  showHeader: true,
  search: {
    show: true,
    text: "Pesquisar aluno por nome",
    placeholder: "nome do aluno",
    sourceColumn: "nome",
  },
};

classTeacherView = {
  title: "Turma",
  subtitles: ["Avaliações", "Alunos"],
  tables: [tableClassExams, tableStudents],
};
