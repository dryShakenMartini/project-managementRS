"use strict";

angular.module("app-darkstar").controller("darkstar.UsersController", ["$scope","$http",
    function($scope, $http) {
        var vm = this;
        $scope.gridOptions = {
            enableColumnResizing: true,
        };
        
        $http({ method: "GET", url: "http://localhost:8000/api/users/columns" })
        .then(function (response) {
            $scope.gridOptions.columnDefs = response.data;
        }, function (response) {
            $scope.gridOptions.columnDefs = [];
        });

        $http({ method: "GET", url: "http://localhost:8000/api/users" })
        .then(function (response) {
            $scope.gridOptions.data = response.data;
        },function (response) {
            $scope.gridOptions.data = [];
        });

        vm.name = "Rada";

    }
]);