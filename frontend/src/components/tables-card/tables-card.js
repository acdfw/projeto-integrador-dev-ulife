app.directive("tablesCard", function () {
  return {    
    replace: true,
    scope: {
      content: "=",
    },
    templateUrl: "components/tables-card/tables-card.html",
    controller: function ($scope) {
      
    },
  };
});
