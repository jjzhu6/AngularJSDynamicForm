'use strict';

dynamicFormApp.controller('FormListController', function FormListController($scope, $http, $location, questionRepository, formRepository) {
        questionRepository.form.getList().$promise.then(function (data) {
            $scope.forms = data;
        });
        
        $scope.newForm = function (formName) {
            $http.post('/api/formstructure/', { Name: formName }).
                success(function(data, status, headers, config) {
                    $location.path('/EditStructure/').search('id', data);
                });
        };
    }
);
