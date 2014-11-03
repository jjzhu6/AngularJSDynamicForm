'use strict';

dynamicFormApp.controller('SavedFormController', function SavedFormController($scope, $location, questionRepository) {
    $scope.formId = $location.search().formId;
    $scope.respondentId = $location.search().respondentId;
    $scope.questionTypePath = "/Scripts/Templates/QuestionTypes/";

    questionRepository.form.getSavedForm({ formId: $scope.formId, respondentId: $scope.respondentId }).$promise.then(function (data) {
        $scope.form = data;
    });
});
