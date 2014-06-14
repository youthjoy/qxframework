/// <reference path="../../jquery-1.4.1-vsdoc.js" />
Doc_Operation =
{
    Init: function(type) {
        debugger;
        if (type != undefined && type == "edit") {
            Doc_Operation.InitEdit();
        }
        else {
            Doc_Operation.InitCreate();
        }
    },
    InitEdit: function() {


    },
    InitCreate: function() {

    },
    InitGender: function() {

    }
}