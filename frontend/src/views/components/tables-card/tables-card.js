angular.module("website").directive("tablesCard", function () {
  return {    
    replace: true,
    scope: {
      content: "=",
    },
    templateUrl: "views/components/tables-card/tables-card.html",
    controller: function ($scope) {
      
    },
  };
});
