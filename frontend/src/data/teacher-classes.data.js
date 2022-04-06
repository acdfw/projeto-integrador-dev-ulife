var tableTeacherClasses = {
  rows: [
    {
      turma: "Turma A",
      inscritos: "10",
      link: "teacher/class/A"
    },
    {
      turma: "Turma B",
      inscritos: "5",
      link: "teacher/class/B"
    },
    {
      turma: "Turma D",
      inscritos: "7",
      link: "teacher/class/D"
    },
    {
      turma: "Turma F",
      inscritos: "8",
      link: "teacher/class/F"
    },
  ],
  colNames: { turma: "Turma", inscritos: "Inscritos" },
  colOrder: ["turma", "inscritos"],
  showHeader: true,
  search: { show: false },
};


TeacherClassesContent = {
  title: "Suas turmas",
  subtitles: [""],
  tables: [tableTeacherClasses],
};
