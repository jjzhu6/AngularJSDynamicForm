'use strict';

dynamicFormApp.controller('EditStructureController', function EditStructureController($scope, $location, formRepository) {
        $scope.formId = $location.search().id;


    }
);
