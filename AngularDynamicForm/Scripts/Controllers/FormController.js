'use strict';

dynamicFormApp.controller('FormController', function FormController($scope, $location, questionRepository) {
        $scope.formId = $location.search().id;
        $scope.questionTypePath = "/Scripts/Templates/QuestionTypes/";

        questionRepository.form.get({ id: $scope.formId }).$promise.then(function (data) {
            $scope.form = data;
        });

        $scope.save = function (form, formName) {
            if (formName.$valid) {
                questionRepository.form.save(form);
            }
        }
    }
);
