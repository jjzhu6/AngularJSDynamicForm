'use strict';

dynamicFormApp.controller('EditStructureController', function EditStructureController($scope, $location, formRepository, questionRepository) {
        $scope.formId = $location.search().id;
        $scope.form = questionRepository.form.get({ id: $scope.formId });

        $scope.editQuestionFuncs = {
            addOption: function (options, newOption) {
                options.push({
                    Label: newOption.Label
                });
                newOption.Label = "";
            }
        };
    }
);
