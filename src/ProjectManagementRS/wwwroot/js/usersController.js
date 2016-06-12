"use strict";

angular.module("app-darkstar").controller("rigel.UsersController", ["$scope", "$http", "ModalDialogService",
    function ($scope, $http, ModalDialogService) {
        var vm = this;
        $scope.gridOptions = {
            enableColumnResizing: true,
        };

        $scope.gridOptions.onRegisterApi = function (gridApi) {
            $scope.myGridApi = gridApi;
        };

        $scope.data = {};

        var baseUrl = $("base").first().attr("href");

        $http({ method: "GET", url: "http://localhost:8000/api/users/columns" })
        .then(function (response) {
            $scope.gridOptions.columnDefs = response.data;
        }, function (response) {
            $scope.gridOptions.columnDefs = [];
        });


        var getUsers = function () {
            $http({ method: "GET", url: "http://localhost:8000/api/users" })
            .then(function (response) {
                $scope.gridOptions.data = response.data;
            }, function (response) {
                $scope.gridOptions.data = [];
            });
        };

        vm.addUser = function () {
            ModalDialogService.showModal({
                templateUrl: baseUrl + "Application/UserDialog",
                controller: "ModalController"
            }).then(function (modal) {

                modal.element.modal();
                modal.close.then(function (result) {
                    $http({ method: "POST", url: "http://localhost:8000/api/users", data: result });
                    $scope.gridOptions.data = [];
                    getUsers();
                });
            });
        };
        vm.name = "Rada";
        getUsers();
    }
]);