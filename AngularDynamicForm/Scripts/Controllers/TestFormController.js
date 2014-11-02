'use strict';

dynamicFormApp.controller('TestFormController',
    function TestFormController($scope, questionRepository) {
        $scope.questionTypePath = "/Scripts/Templates/QuestionTypes/";

        questionRepository.form.get({ id: 1 }).$promise.then(function (data) {
            $scope.questions = data.Questions;
        });                
    }
);
