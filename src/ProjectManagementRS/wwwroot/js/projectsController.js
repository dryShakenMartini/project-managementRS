"use strict";

angular.module("app-darkstar").controller("rigel.ProjectsController", ["$scope", "$http",
    function ($scope, $http) {
        var vm = this;
        $scope.gridOptions = {
            enableColumnResizing: true,
            data: [],
            columnDefs: [],
        };

        $http({ method: "GET", url: "http://localhost:8000/api/projects/columns" })
            .then(function (response) {
         $scope.gridOptions.columnDefs = response.data;
            },function (response) {
                $scope.gridOptions.columnDefs = [];
            });

        $http({ method: "GET", url: "http://localhost:8000/api/projects" })
            .then(function (response) {
                $scope.gridOptions.data = response.data;
            }, function (response) {
            $scope.gridOptions.data = [];
        });
    }
]);