<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div id="ShowMsgMessage" title="信息确认">
    <p id="ShowMsgMessageBody" class="msgbody">
    </p>
</div>
<div id="ConfirmMessage" title="信息提问">
    <p id="ConfirmMessageBody" class="msgbody"">
    </p>
</div>

<script type="text/javascript">

    $(document).ready(function() {

        $('#ShowMsgMessage').dialog({

            autoOpen: false,

            width: 300,

            modal: true,

            buttons: {

                "确定": function() {

                    $(this).dialog("close");

                }

            }

        });

        $('#ConfirmMessage').dialog({

            autoOpen: false,

            width: 300,

            modal: true,

            buttons: {
            
               "确定": function() {

                    $(this).dialog('close');

                    mDialogCallback(true);

                },

                "取消": function() {

                    $(this).dialog('close');

                    mDialogCallback(false);

                }              

            }

        });

    });

    var mDialogCallback;

    function ShowMsg(msg, callback) {

        if (callback == null) {

            $('#ShowMsgMessageBody').html(msg);

            $('#ShowMsgMessage').dialog('open');

        }

        else {

            mDialogCallback = callback;

            $('#ConfirmMessageBody').html(msg);

            $('#ConfirmMessage').dialog('open');

        }

    };

</script>

