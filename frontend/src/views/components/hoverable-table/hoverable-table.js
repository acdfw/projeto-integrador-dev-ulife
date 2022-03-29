angular.module("website").directive("hoverableTable", function () {
  return {
    replace: true,
    scope: {
      content: "=",
    },
    templateUrl: "views/components/hoverable-table/hoverable-table.html",
    controller: function ($scope) {
      var me = $scope;

      me.actualPage = 0;
      
      me.resultsPerPage = !me.content.pagination ? 5 : me.content.pagination;

      me.nextPage = function () {
        if (me.resultsPerPage * (me.actualPage + 1) < me.content.rows.length) {
          me.actualPage += 1;
        }
      };

      me.previousPage = function () {
        if (me.resultsPerPage * (me.actualPage - 1) > -1) {
          me.actualPage -= 1;
        }
      };

      me.updateOrdenation = function (col) {
        me.content.orderBy = col;
      };

      me.rows = me.content.rows;

      me.filterTable = function (search) {
        var tempRows = me.content.rows;
        tempRows = tempRows.filter((row) =>
          row[me.content.search.sourceColumn]
            .toUpperCase()
            .includes(search.toUpperCase())
        );
        me.rows = tempRows;
        me.actualPage = 0;
      };
    },
  };
});
