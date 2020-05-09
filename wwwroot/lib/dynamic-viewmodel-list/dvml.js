dvml = (function () {

    'use strict';

    function add(containerId, actionUrl) {
        var container = $('#' + containerId);
        
        $.ajax({
            url: actionUrl,
            type: "GET",
            cache: false,
            success: function (html) {
                container.append(html);
            }
        });
    };

    function remove(itemId) {
        $('#' + itemId).remove();
    };

    return {
        add: add,
        remove: remove
    };
})();