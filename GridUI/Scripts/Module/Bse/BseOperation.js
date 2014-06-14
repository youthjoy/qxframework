/// <reference path="../../jquery-1.4.1-vsdoc.js" />
BseOperation =
{
    Init: function(type) {
        $("#tabs").tabs();
        if (type != undefined && type == "edit") {
            BseOperation.InitEdit();
        }
        else {
            BseOperation.InitCreate();
        }
    },
    InitEdit: function() {
    },
    InitCreate: function() {
    },
    InitGender: function() {
    }
}