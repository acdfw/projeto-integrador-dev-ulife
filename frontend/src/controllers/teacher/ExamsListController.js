app.controller("ExamsListCtrl", function ($scope, ExamModel) {
  var me = $scope;

  var exams = ExamModel.getExams();

  exams = exams.map(obj=> ({ ...obj, link: `teacher/exam/${obj.id}`}))
  
  var tableTeacherExams = {
    rows: exams,
    colNames: { title: "Titulo", numQuestions: "Número de Questões", id: "Identificador" },
    colOrder: ["id", "title", "numQuestions"],
    showHeader: true,
    search: { show: true },
  };  
  
  me.content = {
    title: "Suas Provas",
    subtitles: [""],
    tables: [tableTeacherExams],
  };

});
