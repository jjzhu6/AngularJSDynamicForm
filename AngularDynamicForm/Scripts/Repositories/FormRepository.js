'use strict';

dynamicFormApp.factory('formRepository', function ($resource) {
    var form = $resource('/api/formstructure/:id', null, {
        post: {method: 'POST'}
    });

    return {
        form: form        
    };
});
