var tableTeacherClassExams = {
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
      turma: "Turma A",
      avaliacao: "A3",
    },
    {
      turma: "Turma A",
      avaliacao: "A4",
    },
  ],
  colNames: { turma: "Turma", avaliacao: "Avaliação" },
  colOrder: ["turma", "avaliacao"],
  showHeader: true,
  search: { show: false },
};

var tableTeacherClassStudents = {
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
    show: true
  }
};

TeacherClassAContent = {
  title: "Turma A",
  subtitles: ["Avaliações", "Alunos"],
  tables: [tableTeacherClassExams, tableTeacherClassStudents],
};
