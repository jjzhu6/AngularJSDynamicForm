'use strict';

dynamicFormApp.controller('TestFormController',
    function TestFormController($scope, questionRepository) {
        $scope.questions = questionRepository.getQuestions();
        $scope.questionTypePath = "/Scripts/Templates/QuestionTypes/";
    }
);
