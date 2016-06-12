"use strict";

angular.module("app-darkstar").controller("ModalController",["$scope", "$filter","close",
    function ($scope, $filter, close) {


        var dateInIsoFormat = function (date)
        {
            return $filter("date")(new Date(date), "YYYY-MM-DD");
        };

        $scope.User = {
            Name: "",
            Surname:"",
            UserName: "",
            Email: "",
            PhoneNumber: "",
            StartDate: new Date(),
            EndDate: new Date(),
            Role: null,
            IsActive: false
        };

        $scope.close = function (result) {
            if (result === 'Ok') {
                close($scope.User, 500);
            }
            else {
                close(result, 500);
            }
         // close, but give 500ms for bootstrap to animate
    };

    $scope.save = function (userData)
    {

    }


}]);