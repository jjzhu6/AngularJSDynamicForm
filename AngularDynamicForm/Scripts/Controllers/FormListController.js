'use strict';

dynamicFormApp.controller('FormListController', function FormListController($scope, questionRepository) {
        questionRepository.form.getList().$promise.then(function (data) {
            $scope.forms = data;
        }); 
                 
    }
);
