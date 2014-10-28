'use strict';

dynamicFormApp.factory('questionRepository', function ($resource) {
    var questions = [
        {
            Name: "Question1",
            Label: "Please answer my question 1",
            Type: "Text",
            Value: ""
        },
        {
            Name: "Question2",
            Label: "Please select for my question 2",
            Type: "Select",
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

    var form = $resource('/api/form/:id');

    return {
        getQuestions: function (id) {
            return form.get();
        }
    };
});
