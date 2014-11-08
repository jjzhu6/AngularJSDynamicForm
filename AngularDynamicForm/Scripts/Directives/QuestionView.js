'use strict';

dynamicFormApp.directive('questionView', function () {
    var typePath = "/Scripts/Templates/QuestionTypes/";
    return {
        restrict: "E",
        replace: true,
        template: "<div ng-include=\"'" + typePath + "' + question.Type + '.html'\"></div>",
        scope: {
            question: "="
        }
    };
});
