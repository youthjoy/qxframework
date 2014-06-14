//点击叶子节点才触发事件
    $("#dept").bind('click.jstree', function(event) {
        var eventNodeName = event.target.nodeName;
        if (eventNodeName == 'INS') {
            return;
        } else if (eventNodeName == 'A') {
            var $subject = $(event.target).parent();
            if ($subject.find('ul').length > 0) {
            
                // $('#show').html("<font color='red' size='2em'>请选择叶子节点</font>");
            } else {
                //$('#show').html('<b>选择了</b>：' + $subject.text());
                ShowMsg($(event.target).attr('id'));
            }
        }
    })
    
    
    