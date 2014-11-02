'use strict';

dynamicFormApp.controller('FormController', function TestFormController($scope, $location, questionRepository) {
        $scope.formId = $location.search().id;
        $scope.questionTypePath = "/Scripts/Templates/QuestionTypes/";

        questionRepository.form.get({ id: $scope.formId }).$promise.then(function (data) {
            $scope.questions = data.Questions;
        });                
    }
);
