//////////////////////////////////////////////////////////////////////////

//通用上传组件
//调用方法：Comm_Upload.Init(divId,keyId,callback);
//参数：divId:需要绑定的标签,keyId:数据库字段,callback:回调
//Date:2010-12-22

var Comm_Upload = {

    _KeyId: null,
    Init: function(divId, keyId, callback) {

        var html = "<div id='CompentUpload'> ";
        html = html + "<input id='" + keyId + "' name='" + keyId + "' type='hidden'  value='' />";
        html = html + " <p id='uploadp'> ";
        html = html + " <span id='attachName' class='floatLeft'></span><input type='button' id='attachdel' value='删除' />";
        html = html + "  ";
        html = html + " <a href='#' onclick=$('#uploadlayer').dialog('open')>上传</a>";
        html = html + " </p> ";
        html = html + " <div id='uploadlayer' style='display: none'>";
        html = html + " <input type='file' name='uploadify' id='uploadify' /> ";
        html = html + " <input type='button' name='OK' value='上传' onclick=$('#uploadify').uploadifyUpload()> ";
        html = html + " <input type='button' name='cancle' onclick=$('#uploadify').uploadifyClearQueue() value='取消上传' /> ";
        html = html + " <div id='fileQueue'> ";
        html = html + " </div></div></div> ";

        $("#" + divId).html(html);
        _KeyId = keyId;
        $(document).ready(function() {
            //初始化层
            $('#uploadlayer').dialog({ autoOpen: false, width: 420, minWidth: 400, title: '文件上传' });
            //初始化上传
            $("#uploadify").uploadify({
                'uploader': '/Content/uploadfiy/uploadify.swf',
                'script': '/Comm/Upload',
                'cancelImg': '/Content/uploadfiy/cancel.png',
                'queueID': 'fileQueue',
                'auto': false,
                'multi': false,
                'onComplete': function(event, queueID, fileObj, response, data) {
                    Comm_Upload.UploadSuccess(event, queueID, fileObj, response, data);
                    var result = response != "" ? true : false;
                    callback(result);
                }
            });

            $('#attachdel').bind("click", function() {
                //与服务器交互删除文件
                $.ajax({
                    url: '/Comm/Delete',
                    type: 'post',
                    data: { fileName: $("#attachName").html() },
                    success: function(result) {
                        if (result != 'success') {
                            ShowMsg("删除失败");
                        } else {
                            ShowMsg("删除成功");
                            $('#attachName').html("");
                        }
                    }
                });

                //$('#attachdel').hide();
            });
        });

    },

    UploadSuccess: function(event, queueID, fileObj, response, data) {
        if (response != "") {
            $('#attachName').html("<a href='#'>" + response + "</a>");
            $("#" + Comm_Upload._KeyId).val(response);
            //$("input[name=" + Comm_Upload._KeyId + "]").val(response);
            $('#attachdel').html('<img src=/Content/uploadfiy/cancel.png/>');
            $('#attachdel').show();
        } else {
            ShowMsg("上传失败！");
        }
    }
}