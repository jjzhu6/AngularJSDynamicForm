'use strict';

dynamicFormApp.factory('statisticRepository', function ($resource) {
    var questionTypes = $resource('/api/statistic/GetQuestionTypes', null, { get: { isArray: true }}).get();

    return {
        questionTypes: questionTypes
    };
});
