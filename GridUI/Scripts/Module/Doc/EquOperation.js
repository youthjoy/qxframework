/// <reference path="../../jquery-1.4.1-vsdoc.js" />
Doc_Operation =
{
    Init: function(type) {
        $("#tabs").tabs({ select: function(event, ui) {


            switch (ui.index) {
                case 1:
                    //财务
                    Doc_Shared_GridControl.Init("/Equ/MRecordList?id=" + $("#EquInfo_Code").val(), "mr");
                    break;
      
            }

        }
        });
        if (type != undefined && type == "edit") {
            Equ_Operation.InitEdit();
        }
        else {
            Equ_Operation.InitCreate();
        }
    },
    InitEdit: function() {


    },
    InitCreate: function() {

    },
    InitGender: function() {

    }
}