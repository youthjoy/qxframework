
///`Power by QianBIn
/// $("#form").FormToJson();
//////////////////////////////////////////////////////////////////////////

$.fn.FormToJson = function() {
    //debugger;
    var s = decodeURIComponent(this.serialize(), true);
    var j = '';
    var k = s.split('&');
    $(k).each(function(i) {
        var o = k[i].split('=');
        if (i != k.length - 1) {
            j += '"' + o[0] + '":"' + o[1] + '",';
        } else {
            j += '"' + o[0] + '":"' + o[1] + '"';
        }
    })
    //如果时间中包含+号,自动处理掉
    if (j.length>0) {
       j = j.replace(/\+/g, ' ');
    } 
    return ('{' + j + '}');
}