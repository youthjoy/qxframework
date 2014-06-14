<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Test
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script src="../../Scripts/Shared/JsTree/jquery.jstree.js" type="text/javascript"></script>

    <script src="../../Scripts/Shared/Dict.js" type="text/javascript"></script>
    

    <script src="../../Scripts/Shared/Dept.js" type="text/javascript"></script>
   
    <input type="text" id="test" value="22" />
    
    <input type="text" id="tt" value="33" />
    <script type="text/javascript">
        $(document).ready(function() {
            Common_Tree_Dict.Init("test", "GENDER", function(code, name) { ShowMsg(code + "," + name); $("#test").val(name); });
            //            Common_Tree_Dict.Init("tt", "TIMESHEET", function(code, name) { ShowMsg(code + "," + name); $("#tt").val(name); });
            Common_EmpTree_Dept.Init("tt", function(code, name) { ShowMsg(code+","+name); });
            //        $("#tree").jstree({ 
            //             'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
            //                "json_data": {
            //                    "ajax": {
            //                        "url": "/Dict/GetDictTreeData/GENDER"
            //                    }
            //                },
            //              
            //                'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': false, 'icons': true },
            //                'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }
            //            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
