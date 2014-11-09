'use strict';

dynamicFormApp.controller('EditStructureController', function EditStructureController($scope, $http, $location, formRepository, questionRepository, statisticRepository) {
    $scope.formId = $location.search().id;
    $scope.questionTypes = statisticRepository.questionTypes;
    questionRepository.form.get({ id: $scope.formId }).$promise.then(function (data) {
        $scope.form = refreshData(data);
    });

    $scope.addQuestion = function () {
        if ($scope.newType !== null && $scope.newType !== "" && $scope.newType !== undefined) {
            $scope.form.Questions.push({ Type: $scope.newType, Options: [] });
            $scope.newType = "";
        }
    }

    $scope.editQuestionFuncs = {
        addOption: function (options, newOption) { addOption(options, newOption) },
        orderUp: function (question) { orderUp(question) },
        orderDown: function (question) { orderDown(question) }
    };

    $scope.saveFormStructure = function (form) {
        $http.post('/api/formstructure/', form).
                success(function (data, status, headers, config) {
                    $location.url($location.path('/FormList/'));
                });
    }

    var addOption = function (options, newOption) {
        options.push({
            Label: newOption.Label
        });
        newOption.Label = "";
    }

    var orderUp = function (question) {
        var questionIndex = $scope.form.Questions.indexOf(question);
        if (questionIndex != 0) {
            switchQuestionPosition($scope.form.Questions[questionIndex], $scope.form.Questions[questionIndex - 1]);
        }
    }

    var orderDown = function (question) {
        var questionIndex = $scope.form.Questions.indexOf(question);
        if (questionIndex + 1 != $scope.form.Questions.length) {
            switchQuestionPosition($scope.form.Questions[questionIndex], $scope.form.Questions[questionIndex + 1]);
        }
    }

    var refreshData = function (form) {
        $.each(form.Questions, function (index, value) {
            form.Questions[index].Order = index + 1;
        });
        return form;
    }

    var switchQuestionPosition = function (question1, question2){
        var question1Index = $scope.form.Questions.indexOf(question1);
        var question2Index = $scope.form.Questions.indexOf(question2);
        var q1Order = question1.Order;
        var q2Order = question2.Order;

        $scope.form.Questions[question1Index] = question2;
        $scope.form.Questions[question1Index].Order = q1Order
        $scope.form.Questions[question2Index] = question1;
        $scope.form.Questions[question2Index].Order = q2Order
    }
});
