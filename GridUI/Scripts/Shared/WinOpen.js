
//打开模态窗口
var Win = {
    
    //弹出窗口
Open: function(url, width, height) {
width = width == "" || width == undefined ? "800" : width;
        height = height == "" || height==undefined ? "500" : height;
        if (document.all) //IE 
        {
            feature = "dialogWidth:" + width + "px;dialogHeight:" + height + "px;status:no;help:no;z-look:yes;location:no";
            window.showModalDialog(url, null, feature);
        }
        else {
            //modelessDialog可以将modal换成dialog=yes 
            feature = "width=" + width + ",height=" + height + ",menubar=no,toolbar=no,location=no,";
            feature += "scrollbars=yes,status=no,modal=yes,top="+(screen.height)/4+",left="+(screen.width)/4+"";
            window.open(url, null, feature);
        }
    }

}