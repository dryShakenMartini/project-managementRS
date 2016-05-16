"use strict";

angular.module("app-darkstar").controller("ModalController",["$scope", "close",
    function ($scope, close) {

        $scope.User = {
            Name: "",
            Surname:"",
            UserName: "",
            Email: "",
            PhoneNumber: "",
            StartDate: null,
            EndDate: null,
            Role: null
        };

        $scope.close = function (result) {
            if (result == 'Ok') {
                close($scope.User, 500);
            }
            else {
                close(result, 500)
            }
         // close, but give 500ms for bootstrap to animate
    };

    $scope.save = function (userData)
    {

    }


}]);