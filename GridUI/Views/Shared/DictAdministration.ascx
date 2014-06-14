<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
       
<%=Html.ReferControl("WH_ContractModule","WH_Contract")%>
<%=Html.ReferControl("WH_SupplierModule", "WH_Supplier")%>
<%=Html.ReferControl("Plant_DecorationsModule", "Plant_Decorations")%>
<%=Html.ReferControl("Plant_RecordModule", "Plant_Record")%>
<%=Html.ReferControl("Asset_InfomationModule", "Asset_Infomation",false)%>
<script type="text/javascript">
    $(document).ready(function() {
        //制造商
        $("#AInfo_CCode").bind("click", function() {
            WH_ContractModuleWH_ContractOpenRefer('WH_ContractModule', 'WH_Contract', function(data) {
                $("#AInfo_CCode").val(data.Contract_Code);
            });
        });

        //供应商编码
        $("#AInfo_SCode").bind("click", function() {
            WH_SupplierModuleWH_SupplierOpenRefer('WH_SupplierModule', 'WH_Supplier', function(data) {
                $("#AInfo_SCode").val(data.WHS_CustCode);
            });
        });

        //植物摆放位置
        $("#PR_Position").bind("click", function() {
        Plant_DecorationsModulePlant_DecorationsOpenRefer('Plant_DecorationsModule', 'Plant_Decorations', function(data) {
        $("#PR_Company").val(data.PD_Company);
        $("#PR_Dept").val(data.PD_Dept);
                $("#PR_Position").val(data.PD_Position);
                $("#PR_Floor").val(data.PD_Floor);
            });
        });

        //原品名
        $("#PCR_OldName").bind("click", function() {
            Plant_RecordModulePlant_RecordOpenRefer('Plant_RecordModule', 'Plant_Record', function(data) {
            $("#PR_Position").val(data.PR_Position);
                $("#PCR_OldName").val(data.PR_Category);
                $("#PDR_Amount").val(data.PR_Amount);
                $("#PDR_Count").val(data.PR_Amount);

                $("#PCR_Company").val(data.PR_Company);
                $("#PCR_Dept").val(data.PR_Dept);
            });
        });

        //更换品名

//        $("#PCR_NewName").bind("click", function() {
//        Plant_RecordModulePlant_RecordOpenRefer('Plant_RecordModule', 'Plant_Record', function(data) {
//       
//                $("#PCR_NewName").val(data.PR_Category);

//            });
//        });
        
        
        //植物损坏

        $("#PDR_PlantName").bind("click", function() {
            Plant_RecordModulePlant_RecordOpenRefer('Plant_RecordModule', 'Plant_Record', function(data) {
            $("#PR_Position").val(data.PR_Position);
            $("#PDR_PlantName").val(data.PR_Category);
            //$("#PDR_Amount").val(data.PR_Amount);
           // $("#PDR_Count").val(data.PR_Amount);
            $("#PDR_Price").val(data.PR_Price);
            
            $("#PDR_Company").val(data.PR_Company);
            $("#PDR_Dept").val(data.PR_Dept);
            });
        });

        //损坏植物位置

//        $("#PR_Position").bind("click", function() {
//            Plant_DecorationsModulePlant_DecorationsOpenRefer('Plant_DecorationsModule', 'Plant_Decorations', function(data) {
//            $("#PR_Position").val(data.PD_Position);
//            $("#PR_Floor").val(data.PD_Floor);
//            });
//        });
    });
</script>

  <%=Html.ReferControl("HR_StuffModule", "HR_Stuff",false)%>
 

    <script type="text/javascript">
        $(document).ready(function() {
            //考勤
            $("#TS_StuffName").click(function() {
            HR_StuffModuleHR_StuffOpenReferWithFilter("", 
            function(data) {
                $("#TS_StuffCode").val(data.Stuff_Code);
                $("#TS_StuffName").val(data.Stuff_Name);
            });
            })

            //电话记录
            $("#TeleRecord_Operator").click(function() {
            HR_StuffModuleHR_StuffOpenReferWithFilter("", 
            function(data) {
                $("#TeleRecord_OpTarget").val(data.Stuff_DepName);
                $("#TeleRecord_Operator").val(data.Stuff_Name);
            });
            })

            //职位变动
            $("#HM_EName").click(function() {
            HR_StuffModuleHR_StuffOpenReferWithFilter("", 
            function(data) {
                $("#HM_ECode").val(data.Stuff_Code);
                $("#HM_EName").val(data.Stuff_Name);
            });


            })


            //奖惩管理
            $("#AA_EName").click(function() {
            HR_StuffModuleHR_StuffOpenReferWithFilter("", 
            function(data) {
                $("#AA_ECde").val(data.Stuff_Code);
                $("#AA_EName").val(data.Stuff_Name);
            });
            })


            //考评管理
            $("#Eva_StuffName").click(function() {
            HR_StuffModuleHR_StuffOpenReferWithFilter("", 
            function(data) {
                $("#Eva_StuffCode").val(data.Stuff_Code);
                $("#Eva_StuffName").val(data.Stuff_Name);
            });
            })


            //工作服Clothing
            $("#WRecipients_Model").click(function() {
            Asset_InfomationModuleAsset_InfomationOpenReferWithFilter(" AInfo_iType='Clothing'",
            function(data) {
                $("#WRecipients_Model").val(data.AInfo_Spec);

            });
            })


            //TODO:外联单位跟进人$("#tmpDeptCode").val()
            $("#OI_Contactor").click(function() {

            HR_StuffModuleHR_StuffOpenReferWithFilter(" Stuff_DepCode in (select dept_code from HR_Department where Dept_PCode='" + $("#tmpDeptCode").val() + "' or Dept_Code='" + $("#tmpDeptCode").val() + "')", function(data) {
                    $("#OI_Telephone").val(data.Stuff_Mobile);
                    $("#OI_Dept").val(data.Stuff_DepName);
                    $("#OI_Contactor").val(data.Stuff_Name);
                });
            });


            //印章提交人
            $("#GMSE_Owner").click(function() {
            //ShowMsg("ok");
            HR_StuffModuleHR_StuffOpenReferWithFilter("", 
            function(data) {
                $("#GMSE_Tel").val(data.Stuff_Mobile);
                $("#GMSE_Owner").val(data.Stuff_Name);
            });
            });
        });
       
    </script>
    
    <script type="text/javascript">
        $(document).ready(function() {
        //食堂信息
        $("#CHR_CanteenItemCode").click(function() {
                Bse_CanteenItemModuleBse_CanteenItemOpenRefer('Bse_CanteenItemModule', 'Bse_CanteenItem',
            function(data) {
                $("#CHR_CanteenItemCode").val(data.CanteenItem_Code);
                $("#CHR_Company").val(data.CanteenItem_Company);
                $("#CHR_Dept").val(data.CanteenItem_Department);

            });
            })

        });
</script>

<%=Html.ReferControl("Bse_CanteenItemModule", "Bse_CanteenItem")%>  

