'use strict';

dynamicFormApp.factory('formRepository', function ($resource) {
    var form = $resource('/api/formstructure/:id', null, {
    });

    return {
        form: form        
    };
});
