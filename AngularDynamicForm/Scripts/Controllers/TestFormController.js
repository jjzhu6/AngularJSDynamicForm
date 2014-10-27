'use strict';

dynamicFormApp.controller('TestFormController',
    function TestFormController($scope) {
        var questions = [
            {
                Name: "Question1",
                Label: "Please answer my question 1",
                Type: "Text",
                Include: "/Scripts/Templates/QuestionTypes/Text.html",
                Value: ""
            },
            {
                Name: "Question2",
                Label: "Please select for my question 2",
                Type: "Select",
                Include: "/Scripts/Templates/QuestionTypes/Select.html",
                Value: "",
                Options: [
                    {
                        Value: "Select1",
                        Label: "This is Select 1"
                    },
                    {
                        Value: "Select2",
                        Label: "This is Select 2"
                    },
                    {
                        Value: "Select3",
                        Label: "This is Select 3"
                    },
                    {
                        Value: "Select4",
                        Label: "This is Select 4"
                    }
                ]
            },
            {
                Name: "Question3",
                Label: "Please check my question 3",
                Type: "Radio",
                Include: "/Scripts/Templates/QuestionTypes/Radio.html",
                Value: "",
                Options: [
                    {
                        Value: "Radio1",
                        Label: "This is Radio 1"
                    },
                    {
                        Value: "Radio2",
                        Label: "This is Radio 2"
                    },
                    {
                        Value: "Radio3",
                        Label: "This is Radio 3"
                    },
                    {
                        Value: "Radio4",
                        Label: "This is Radio 4"
                    }
                ]
            }
        ];

        $scope.questions = questions;
    }
);
