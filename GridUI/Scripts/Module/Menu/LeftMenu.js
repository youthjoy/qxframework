/* 左边菜单树*/

function ClickTable(obj) {
    var _obj = $("#min_" + obj.id);
    _obj.toggle();
}

function showsubmenu(sid) {
    whichEl = eval("submenu" + sid);
    imgmenu = eval("imgmenu" + sid);
    if (whichEl.style.display == "none") {
        eval("submenu" + sid + ".style.display=\"\";");
        imgmenu.background = "/Content/images/main_25.gif";
    }
    else {
        eval("submenu" + sid + ".style.display=\"none\";");
        imgmenu.background = "/Content/images/main_36.gif";
    }
}