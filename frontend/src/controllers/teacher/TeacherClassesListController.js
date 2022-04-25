app.controller("TeacherClassesListCtrl", function ($scope, $route, getTeacherClasses, AuthTokenService, ClassModel) {
  var me = $scope; 

  me.classes = getTeacherClasses;

  me.classesTable = {
    rows: me.classes.map((obj) => ({...obj, link: `teacher/class/${obj.id}`})),
    colNames: {
      name: "Turma",
      members: "Inscritos",
      assignments: "Avaliações",
    },
    colOrder: ["name", "members", "assignments"],
    showHeader: true,
    search: { show: true },
  };

  me.newClassName = "";

  me.NewClass = async() => {
    var data = {nome: me.newClassName, usuarioId: AuthTokenService.getUserId()}
    try{
      response = await ClassModel.create(data);
      alert(response.msg)
    }catch(err){
      alert(err.err)
    }
    $route.reload();
  };

});