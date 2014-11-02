'use strict';

var dynamicFormApp = angular.module('dynamicFormApp', ['ngResource', 'ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/Form',
            {
                templateUrl: '/Scripts/Templates/Form.html',
                controller: 'FormController'
            })
        $routeProvider.otherwise({ redirectTo: '/Form' });
        $locationProvider.html5Mode(true);
    });

