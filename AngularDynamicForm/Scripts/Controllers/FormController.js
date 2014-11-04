'use strict';

dynamicFormApp.controller('FormController', function FormController($scope, $location, questionRepository) {
        $scope.formId = $location.search().id;

        questionRepository.form.get({ id: $scope.formId }).$promise.then(function (data) {
            $scope.form = data;
        });
        
        $scope.responseText = "(See Responses)"

        $scope.save = function (form, formName) {
            if (formName.$valid) {
                questionRepository.form.save(form);
            }
        }
    }
);
