'use strict';

dynamicFormApp.controller('TestFormController',
    function TestFormController($scope, questionRepository) {
        questionRepository.getQuestions().$promise.then(function (data) {
            $scope.questions = data.Questions;
        });

        $scope.questionTypePath = "/Scripts/Templates/QuestionTypes/";
    }
);
