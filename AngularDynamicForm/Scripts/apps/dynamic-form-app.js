'use strict';

var dynamicFormApp = angular.module('dynamicFormApp', ['ngResource', 'ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/TestForm',
            {
                templateUrl: '/Scripts/Templates/TestForm.html',
                controller: 'TestFormController'
            })
        $routeProvider.otherwise({ redirectTo: '/TestForm' });
        $locationProvider.html5Mode(true);
    });

