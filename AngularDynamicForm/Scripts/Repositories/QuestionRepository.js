'use strict';

dynamicFormApp.factory('questionRepository', function ($resource) {
    var form = $resource('/api/form/:id');

    return {
        form: form        
    };
});
