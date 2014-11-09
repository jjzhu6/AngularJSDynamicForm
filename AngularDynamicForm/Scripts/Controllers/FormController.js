'use strict';

dynamicFormApp.controller('FormController', function FormController($scope, $route, $location, questionRepository) {
    $scope.formId = $location.search().id;

    questionRepository.form.get({ id: $scope.formId }).$promise.then(function (data) {
        $scope.form = data;
    });
        
    questionRepository.form.getResponseList({ formId: $scope.formId }).$promise.then(function (data) {
        $scope.responsesCount = data.length;
        $scope.responseText = "(See " + $scope.responsesCount + " Response/s)";
    });

    $scope.save = function (form, formName) {
        form = serializeResponse(form);
        if (formName.$valid) {
            questionRepository.form.save(form).$promise.then(function () {
                $route.reload();
            });
        }
    }

    var serializeResponse = function (form) {
        $.each(form.Questions, function () {
            this.Value = JSON.stringify(this.Value);
        });
        return form;
    }
});
