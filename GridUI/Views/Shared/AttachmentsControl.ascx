<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<div id="fileupload<%=ViewData["CID"]!=null?ViewData["CID"]:"" %>">
    <noscript>
        <p>
            Please enable JavaScript to use file uploader.</p>
        <!-- or put a simple form for upload here -->
    </noscript>
</div>

<script src="/Scripts/Shared/fileuploader.js" type="text/javascript"></script>

<script type="text/javascript">
    var <%=ViewData["CID"]!=null?ViewData["CID"]:"" %>Uploader;
    function <%=ViewData["CID"]!=null?ViewData["CID"]:"" %>CreateUploader() {
         <%=ViewData["CID"]!=null?ViewData["CID"]:"" %>Uploader = new qq.FileUploader({
            element: document.getElementById('fileupload<%=ViewData["CID"]!=null?ViewData["CID"]:"" %>'),
            action: '<%=ViewData["UploadUrl"] %>',
            debug: true,
            onSubmit: function(id, fileName){
               <%if(ViewData["SetParamCallback"]!=null){ %>
              
                  if ($.isFunction(window.<%=ViewData["SetParamCallback"] %>))
                   {
                      return  <%=ViewData["SetParamCallback"] %>(<%=ViewData["CID"]!=null?ViewData["CID"]:"" %>Uploader);
                   } 

               <%} %>
               
               return true;
               
            },
            onComplete: function(id, fileName, responseJSON) {
               if (responseJSON.result == "success") {
                   <%=Model.ToString() %>(id,responseJSON.path);
                    alert("文件上传成功！");
                }
                else {
                    alert(responseJSON.message);
                }
            }
        });
    }

    $(document).ready(function() {

        <%=ViewData["CID"]!=null?ViewData["CID"]:"" %>CreateUploader();

        <%=ViewData["CID"]!=null?ViewData["CID"]:"" %>Uploader.setParams({
            typeParam: '<%=ViewData["FileType"] %>'
        });
    });

    // in your app create uploader as soon as the DOM is ready
    // don't wait for the window to load  
</script>

