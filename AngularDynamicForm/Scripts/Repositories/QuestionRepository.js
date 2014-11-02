﻿'use strict';

dynamicFormApp.factory('questionRepository', function ($resource) {
    var form = $resource('/api/form/:id', null, {
        getList: { isArray: true }
    });

    return {
        form: form        
    };
});
