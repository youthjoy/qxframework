<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<script src="/Content/fckeditor/fckeditor.js" type="text/javascript"></script>
<script type="text/javascript">
    window.onload = function() {
        var oFCKeditor = new FCKeditor('content');
        oFCKeditor.BasePath = "/Content/fckeditor/";
        oFCKeditor.Height = 300;
        oFCKeditor.ReplaceTextarea();
    }

    function InsertContent() {
        var oEditor = FCKeditorAPI.GetInstance('content');
        var sample = document.getElementById("sample").value;
        oEditor.InsertHtml(sample);
    }

    function ShowContent() {
        var oEditor = FCKeditorAPI.GetInstance('content');
        alert(oEditor.GetHTML());
    }

    function ClearContent() {
        var oEditor = FCKeditorAPI.GetInstance('content');
        oEditor.SetHTML("");
    }
    </script>
    
    <div>
 
        <textarea id="content" cols="30" rows="10"></textarea>
       
    </div>