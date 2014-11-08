'use strict';

dynamicFormApp.directive('editQuestionView', function () {
    var typePath = "/Scripts/Templates/EditQuestionTypes/";
    return {
        restrict: "E",
        replace: true,
        template: "<div class='edit-question' ng-include=\"'" + typePath + "' + question.Type + '.html'\"></div>",
        scope: {
            question: "=",
            funcs: "="
        }
    };
});
