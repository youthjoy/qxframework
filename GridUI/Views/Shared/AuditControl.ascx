<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>

<div id="AuditLayer" style="display:none">
    <div style="width:100%">
    <%=Html.SysComm_JqGrid("VerifyProcess_RecordsModule", "AuditHistory", "/Audit/AuditHistroy", true)%>
    </div>
    <div id="AuditMsgBody" style="width:100%"> 
      <span>审核意见:</span> <textarea cols="5" rows="4" id="AuditBakMsg" name="AuditBakMsg" style="width:100%"></textarea>
    </div>
    <div>下一审核人:<span id="NextAuditUser"></span> 部门:<span id="NextAuditDept"> </span></div>
    <input type="hidden" id="ModuleName" name="ModuleName"/>
    <input type="hidden" id="NodeCode" name="NodeCode"/>
    <input type="hidden" id="RecordId" name="RecordId"/>
    <input type="hidden" id="Agree" name="Agree"/>  
    <input type="hidden" id="AuditType" name="AuditType" />
</div>

<script type="text/javascript">
    $(document).ready(function() {
        $("#AuditLayer").dialog({ autoOpen: false, title: '通用审核', width: 600, modal: false, buttons: {
            "同意": function() {
                AuditInstance._Agree();
                $(this).dialog("close");
            },
            "拒绝": function() {
                AuditInstance._ReJect();
                $(this).dialog("close");
            },
            "关闭": function() {
                $(this).dialog("close");
            }
        }
        });
    });

    var AuditInstance = {

        _callback: null,

        Audit: function(Agree, callback) {
            //参数：当前模块(表名)，当前单据编码
            //传入数据：备注信息，操作按钮
            //传出参数：审核是否成功，下一节点部门名称
            $.ajax({
                url: '/Audit/Audit',
                type: 'post',
                data: {
                    verfiykey: $('#ModuleName').val(),
                    NodeCode: $('#NodeCode').val(),
                    recordid: $('#RecordId').val(),
                    suggest: $('#AuditBakMsg').val(),
                    agree: Agree,
                    type:$('#AuditType').val()              
                },
                success: function(data) {
                    callback(data);
                }
            });

        },
        Init: function(ModuleName, NodeCode, RecordId, callback,AuditType) {
            $('#ModuleName').val(ModuleName);
            $('#NodeCode').val(NodeCode);
            $('#RecordId').val(RecordId);
            $('#AuditType').val(AuditType);
            $("#AuditLayer").dialog('open');
            AuditInstance._callback = callback;
            $.ajax({
                url: '/Audit/NextAuditUser',
                type:'post',
                dataType:'json',
                data: {
                    verfiykey: $('#ModuleName').val(),
                    NodeCode: $('#NodeCode').val(),
                },
                cache:false,
                success:function (data) {
                    $("#NextAuditUser").html(data.VU_User);
                    $("#NextAuditDept").html(data.VU_Dept);
                }
            });
            
            //获取审核历史 
            $("#AuditHistorygrid").setGridParam({ postData: { "verfiykey":ModuleName,"DataCode":RecordId } }).trigger("reloadGrid");     
            $("#AuditHistorypager").remove();           
        },
        _Agree: function() {
            AuditInstance.Audit('true', function(data) {
                AuditInstance._callback(data);
            });
        },
        _ReJect: function() {
            AuditInstance.Audit('false', function(data) {
                AuditInstance._callback(data);
            });
        }

    }
    
</script>