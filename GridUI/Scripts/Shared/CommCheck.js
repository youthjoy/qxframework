
//通用检查
var Comm_Check = {

    //库存检查
    Storage: function(obj, Mcode,_StroageCode, callback) {
        var elementObj = $("#" + obj);
        var elementMCode = $("#" + Mcode);
        var val = elementObj.val();
        try{
            $.ajax({
                url: '/CommCheck/Stroage',
                dataType: 'json',
                type: 'post',
                async: false,
                data: { MCode: elementMCode.val(), Num: val ,StroageCode:_StroageCode},
                success: function(data) {
                if (data != undefined) {
                        if (data.Result) {

                        } else {
                            ShowMsg(data.Msg);
                        }
                    }                    
                    callback(data);
                },
                error:function(e) {
                    
                }
                
            })
        }catch(e) {
            
        }
        
    }

}


