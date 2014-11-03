'use strict';

dynamicFormApp.controller('ResponseListController', function ResponseListController($scope, $location, questionRepository) {
    $scope.formId = $location.search().id;

    questionRepository.form.getResponseList({ formId: $scope.formId }).$promise.then(function (data) {
            $scope.responses = data;
    }); 
});
