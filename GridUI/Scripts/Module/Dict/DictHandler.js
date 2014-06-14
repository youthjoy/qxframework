var Dict_DictHandler =
{
    thisTree: null,
    AddDict: function() {

        Dict_DictHandler.thisTree.jstree("create", null, "last", { "attr": { "rel": "folder"} }, Dict_DictHandler.AfterAdd, true);

    },
    AfterAdd: function() {


    },
    EditDict: function() {

    },
    BeforeEdit: function() {

    },
    DelDict: function() {

    },
    CurSelNode: null,
    Init: function() {

        Dict_DictHandler.thisTree = $("#DictList");
        //树控件初始化(事件)
        //NODE-->type(Create_node)   REF_NODE 添加的节点
        Dict_DictHandler.thisTree.bind("create.jstree", function(e, data) {
            if (Dict_DictHandler.CurSelNode != null) {
                var parentCode = Dict_DictHandler.CurSelNode.attr("id");
                $.ajax({
                    type: "post",
                    url: "/Dict/CreateNode",
                    data: { parentCode: parentCode },

                    success: function(data, textStatus) {
                       
                    }
                });

                var id = data.rslt.parent.attr("id").replace("node_", "");
                data.rslt.name = "test";
                ShowMsg(id + "," + data.rslt.name);
            }

        });

        $("#Add_folder").click(function() {
            Dict_DictHandler.AddDict();
        });

        $("Edit_folder").click(function() {
            Dict_DictHandler.EditDict();
        });

        $("#Del_folder").click(function() {
            Dict_DictHandler.DelDict();
        });



        //数据控件事件绑定
        $("#DictList").bind('click.jstree', function(event) {
            var eventNodeName = event.target.nodeName;
            if (eventNodeName == 'INS') {
                return;
            } else if (eventNodeName == 'A') {
                var $subject = $(event.target);
                Dict_DictHandler.CurSelNode = $subject;
            }
        });
    }
}