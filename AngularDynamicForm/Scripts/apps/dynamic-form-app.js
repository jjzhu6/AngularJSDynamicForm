'use strict';

var dynamicFormApp = angular.module('dynamicFormApp', ['ngResource', 'ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/FormList',
            {
                templateUrl: '/Scripts/Templates/FormList.html',
                controller: 'FormListController'
            })
        $routeProvider.when('/Form',
            {
                templateUrl: '/Scripts/Templates/Form.html',
                controller: 'FormController'
            })
        $routeProvider.when('/SavedForm',
            {
                templateUrl: '/Scripts/Templates/Form.html',
                controller: 'SavedFormController'
            })
        $routeProvider.when('/ResponseList',
            {
                templateUrl: '/Scripts/Templates/ResponseList.html',
                controller: 'ResponseListController'
            })
        $routeProvider.when('/EditStructure',
            {
                templateUrl: '/Scripts/Templates/EditStructure.html',
                controller: 'EditStructureController'
            })
        $routeProvider.otherwise({ redirectTo: '/FormList' });
        $locationProvider.html5Mode(true);
    });

