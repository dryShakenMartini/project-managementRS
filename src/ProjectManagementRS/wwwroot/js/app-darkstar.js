"use strict";

angular.module("app-darkstar", ["ui.router", "ui.grid"])
    .config([
        "$stateProvider", "$urlRouterProvider", "$locationProvider",
        function($stateProvider, $urlRouterProvider, $locationProvider) {

            var baseUrl = $("base").first().attr("href");

            $locationProvider.hashPrefix("#").html5Mode(true);

            $stateProvider.state("home", {
                    templateUrl: baseUrl + "Application/Home",
                    url: "/home"
                })
                .state("users", {
                    templateUrl: baseUrl + "Application/Users",
                    url: "/users"
                })
                .state("projects", {
                    templateUrl: baseUrl + "Application/Projects",
                    url: "/projects"
                })
                .state("time", {
                    templateUrl: baseUrl + "Application/Time",
                    url: "/timesheet"
                })
              .state("register", {
                  templateUrl: baseUrl + "UserAccount/UserRegistration",
                  url: "/register"
              })
            .state("login", {
                templateUrl: baseUrl + "UserAccount/LogIn",
                url: "/login"
            });


            $urlRouterProvider.otherwise("/register");

        }
    ]);

angular.module("app-darkstar").run(["$rootScope", "$log",
    function($rootScope, $log) {
        $log.warn("gets here");

        $rootScope.$on("$stateChangeStart",
            function(event, toState, toParams, fromState, fromParams, options) {
                // event.preventDefault();
                // transitionTo() promise will be rejected with 
                // a 'transition prevented' error
            });

        $rootScope.$on("$stateNotFound",
            function(event, unfoundState, fromState, fromParams) {
                console.log(unfoundState.to);
                console.log(unfoundState.toParams);
                console.log(unfoundState.options);
            });

        $rootScope.$on("$stateChangeSuccess",
            function(event, toState, toParams, fromState, fromParams) {
                $log.warn("State changed once");
            });

        $rootScope.$on("$viewContentLoaded", function() {
            $log.warn("gets here rada");
        });
    }
]);