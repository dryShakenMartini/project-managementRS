"use strict";

angular.module("app-darkstar").factory("ModalDialogService",
    ["$document", "$compile", "$controller", "$http", "$rootScope", "$q", "$timeout",
    function ($document, $compile, $controller, $http, $rootScope, $q, $timeout) {
        var body = $document.find("body");
        var self = this;
        var getTemplate = function (template, templateUrl) {
            var deferred = $q.defer();
                if (template) {
                    deferred.resolve(template);
                } else if (templateUrl) {
                    $http({ method: "GET", url: templateUrl, cache: true })
                    .then(function (result) {
                        deferred.resolve(result.data);
                    })
                    .catch(function (error) {
                        deferred.reject(error);
                    });
                } else {
                    deferred.reject("No template or templateUrl has been specified.");
                }
                return deferred.promise;
        };
        var showModal = function (options) {
            var deferred = $q.defer();
            var controller = options.controller;
            if (!controller) {
                    deferred.reject("No controller has been specified.");
                    return deferred.promise;
            }
            getTemplate(options.template, options.templateUrl)
                .then(function (template) {
                    var modalScope = $rootScope.$new();
                    var closeDeferred = $q.defer();
                    var inputs = {
                        $scope: modalScope,
                        close: function (result, delay) {
                            if (delay === undefined || delay === null) delay = 0;
                            $timeout(function () {
                                closeDeferred.resolve(result);
                            }, delay);
                        }
                    };
                    if (options.inputs) {
                        for (var inputName in options.inputs) {
                            inputs[inputName] = options.inputs[inputName];
                        }
                    }

                    var modalController = $controller(controller, inputs);
                    var modalElementTemplate = angular.element(template);
                    var linkFn = $compile(modalElementTemplate);
                    var modalElement = linkFn(modalScope);

                    body.append(modalElement);

                    var modal = {
                        controller: modalController,
                        scope: modalScope,
                        element: modalElement,
                        close: closeDeferred.promise
                    };
                    modal.close.then(function (result) {
                        modalScope.$destroy();
                    //    modalElement.remove();
                    });

                    deferred.resolve(modal);
                });
                return deferred.promise;  
        };

        return {
            showModal: showModal
        };
    }
]);