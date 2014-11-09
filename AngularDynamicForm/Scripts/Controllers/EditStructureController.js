'use strict';

dynamicFormApp.controller('EditStructureController', function EditStructureController($scope, $http, $location, formRepository, questionRepository, statisticRepository) {
    $scope.formId = $location.search().id;
    $scope.questionTypes = statisticRepository.questionTypes;
    $scope.form = questionRepository.form.get({ id: $scope.formId });

    $scope.addQuestion = function () {
        if ($scope.newType !== null && $scope.newType !== "" && $scope.newType !== undefined) {
            $scope.form.Questions.push({ Type: $scope.newType, Options: [] });
            $scope.newType = "";
        }
    }

    $scope.editQuestionFuncs = {
        addOption: function (options, newOption) {
            options.push({
                Label: newOption.Label
            });
            newOption.Label = "";
        }
    };

    $scope.saveFormStructure = function (form) {
        $http.post('/api/formstructure/', form).
                success(function (data, status, headers, config) {
                    $location.path('/FormList/');
                });
    }
});
