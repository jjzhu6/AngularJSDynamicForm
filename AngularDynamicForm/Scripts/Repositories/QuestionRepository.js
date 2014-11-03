'use strict';

dynamicFormApp.factory('questionRepository', function ($resource) {
    var form = $resource('/api/form/:id', null, {
        getList: { isArray: true },
        getResponseList: { isArray: true },
        getSavedForm: { isArray: false }
    });

    return {
        form: form        
    };
});
