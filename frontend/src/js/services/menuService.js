app.factory("MenuService", function (AuthTokenService) {
  return {
    getMenu: function () {
      switch (AuthTokenService.getRole()) {
        case "T":
          return [
            { text: "Turmas", link: "#/teacher/classes" },
            { text: "Avaliações", link: "#/teacher/assignments" },
            { text: "Questionários", link: "#/teacher/questionnaires" },
            { text: "Questões", link: "#/teacher/questions" },
            { text: "Sair", link: "#/logout" },
          ];
        case "S":
          return [
            { text: "Turmas", link: "#/student/classes" },
            { text: "Avaliações", link: "#/student/assignments" },
            { text: "Notas", link: "#/student/assignments" },
            { text: "Sair", link: "#/logout" },
          ];
        default:
          return [
            { text: "Home", link: "#/" },
            { text: "Equipe", link: "#/equipe" },
            { text: "Sobre", link: "#/sobre" },
          ];
      }
    },
  };
});
