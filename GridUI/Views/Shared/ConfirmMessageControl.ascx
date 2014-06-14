<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div id="ConfirmMessage" title="信息提问">
    <p id="ConfirmMessageBody" class="msgbody"">
    </p>
</div>

<script type="text/javascript">
    $(document).ready(function() {
    $('#ConfirmMessage').dialog({
    autoOpen: false,
    width: 300,
    modal: true,
         buttons:
{ "取消": function() { $(this).dialog('close'); mDialogCallback(false); }, "确定": function()
{ $(this).dialog('close'); mDialogCallback(true); }
}
        });

    });

    var mDialogCallback;

    function ShowMsg(msg, callback) {
        if (callback == null) {
            $('#ShowMsgMessageBody').html(msg);
            $('#ShowMsgMessage').dialog('open');
        } else {
            mDialogCallback = callback; $('#ConfirmMessageBody').html(msg);
            $('#ConfirmMessage').dialog('open');
        }
    };

</script>

