var Permission_Handler =
{
    thisTree: null,
    thisForm: null,
    CurSelNode: null,
    CurNode: null,
    hasNewNode: false,
    InitAddDictEvent: function() {
        if (Permission_Handler.CurSelNode != null) {
            Permission_Handler.thisTree.jstree("create", null, "last", { "attr": { "rel": "folder"} }, function() { }, true);
        }
        else {
            ShowMsg("请选择要添加的子节点");
        }

    }, //初始化添加数据
    InitAddDict: function(obj) {
        Permission_Handler.BindForm(obj);

    }, //绑定表单数据
    BindForm: function(jsonData) {
        for (var d in jsonData) {
            var $obj = $("#" + d)
            if ($obj.length != 0) {
                $obj.val(jsonData[d]);
            }
        }
    }, //
    AfterOperation: function(data) {
        if (data.result == "success") {
            var SearchNode = data.target.Dept_Code;
            if (Permission_Handler.hasNewNode) {
                SearchNode = "temp_" + SearchNode;
            }
            Permission_Handler.thisTree.jstree("set_text", $("#" + SearchNode), data.target.Dept_Name);
            Permission_Handler.thisForm[0].reset();
            Permission_Handler.hasNewNode = false;
            ShowMsg("提交信息成功！");

        }
    }, //编辑事件初始化
    InitEditDictEvent: function() {
        //        ShowMsg(Permission_Handler.CurSelNode.attr("id"));
        if (Permission_Handler.CurSelNode != null) {
            var code = Permission_Handler.CurSelNode.attr("id");
            Permission_Handler.GetEditData(code);

        }
    },
    GetEditData: function(code) {
        $.ajax({
            type: "post",
            url: "/Permission/GetNode",
            data: { nodeCode: code, nodeKey: Itype },
            success: function(re, textStatus) {
                if (re != null && re.result == "success") {
                    Permission_Handler.InitEditDict(re.data);
                    //                        Permission_Handler.BindForm(re);
                }
                else {
                    ShowMsg("获取数据失败!");
                }
            }
        });
    },
    //初始化编辑数据
    InitEditDict: function(re) {
        Permission_Handler.BindForm(re);
    }, //删除树控件节点事件
    DelDictEvent: function() {
        Permission_Handler.thisTree.jstree("remove");
    },
    Save: function() {
        if (!Permission_Handler.thisForm.validate().form()) {
            return false;
        }
        //$(".err_display").removeClass();
        if ($("#Dept_Code").val() == "" || $("#Dept_Code").val() == null) {
            ShowMsg("数据有误");
            return;
        }
        Permission_Handler.thisForm.submit();

    },
    Cancel: function() {
        location = location;
    },
    NewNodeCode: null,
    //是否允许多层级
    IsLevel: false,
    Init: function(isLevel) {
        if (isLevel != undefined || isLevel != 0) {
            Permission_Handler.IsLevel = true;
        }

        //树控件
        Permission_Handler.thisTree = $("#DictList");
        //表单控件
        Permission_Handler.thisForm = $("#dictform");

        $("#Dept_Code").change(function() {
            if (Permission_Handler.NewNodeCode != null) {
                var val = $(this).val();
                var $dict = $("#" + Permission_Handler.NewNodeCode);
                $dict.attr("id", val);
                Permission_Handler.NewNodeCode = val;
                //                var node = Permission_Handler.thisTree.jstree("_get_node", Permission_Handler.NewNodeCode);

                //                var node1 = Permission_Handler.thisTree.jstree("_get_node",$("#"+ Permission_Handler.NewNodeCode));
                //                $obj = $("#" + );
                //                $obj.attr("id", val);
                //                Permission_Handler.NewNodeCode = val;

            }
            //            ._get_node ( node , allow_multiple )
        });

        //树控件初始化(事件)
        //NODE-->type(Create_node)   REF_NODE 添加的节点

        Permission_Handler.thisTree.bind("create.jstree", function(e, data) {
            if (Permission_Handler.CurSelNode != null) {

                if (Permission_Handler.hasNewNode) {
                    $.jstree.rollback(data.rlbk);
                    ShowMsg("请先提交新建项！");
                    return;
                }

                var node = Permission_Handler.CurSelNode;

                //                var node = $.jstree._focused()._get_node();

                var parentCode = $(node).attr("id");
                
                $.ajax({
                    type: "post",
                    url: "/Permission/CreateNode",
                    dataType: "json",
                    data: { parentCode: parentCode, itype: Itype },
                    success: function(re, textStatus) {
                        if (re.result == "success") {
                            $(data.rslt.obj).find("a").attr("id", "temp_" + re.data.Dept_Code);
                            Permission_Handler.NewNodeCode = re.data.Dept_Code;
                            Permission_Handler.InitAddDict(re);
                            Permission_Handler.hasNewNode = true;
                            $("#Dept_ID").val('');
                            $("#Dept_Code").val(re.data.Dept_Code);
                            $("#Dept_PCode").val(parentCode);
                            $("#Dept_Name").val("");
                            $("#Dept_Addr").val("");
                            Permission_Handler.CurNode = "temp_" + re.data.Dept_Code;
                        }
                        else {
                            $.jstree.rollback(data.rlbk);
                            ShowMsg("该类别不允许添加多层级选项!");
                        }
                    }
                });
            }

        });
        Permission_Handler.thisTree.bind("loaded.jstree", function(event, data) {
            Permission_Handler.thisTree.jstree("open_all");
        });


        Permission_Handler.thisTree.bind("dblclick_node.jstree", function(event, data) {
            //var id = data.rslt.obj[0].childNodes[1].id;
            //Permission_Handler.GetEditData(id);
        });

        Permission_Handler.thisTree.bind("remove.jstree", function(e, data) {

            data.rslt.obj.each(function(item) {
                //                ShowMsg($(this).find("a").attr("id"));
                $.ajax({
                    type: 'POST',
                    url: "/Permission/DeleteNode/",
                    data: { code: $(this).find("a").attr("id"), type: Itype },
                    success: function(r) {
                        if (r.result == "success") {
                            ShowMsg("删除成功");
                            Permission_Handler.hasNewNode = false;
                            //data.inst.refresh();
                        } else {
                            //data.inst.rollback();
                            //$.jstree.rollback();
                            ShowMsg(r.msg);
                            $.jstree.rollback(data.rlbk);
                        }
                        //window.location.reload();
                    }
                });
            });
        });

        //        Permission_Handler.thisTree.bind("rename.jstree", function(e, data) {
        //        })


        //数据控件事件绑定
        $("#DictList").bind('click.jstree', function(event) {
            var eventNodeName = event.target.nodeName;
            if (eventNodeName == 'INS') {
                return;
            } else if (eventNodeName == 'A') {
                var $subject = $(event.target);
                Permission_Handler.CurSelNode = $subject;
                var id = $subject.attr("id");

                if (Permission_Handler.hasNewNode) {
                    //alert(id);
                    //alert(Permission_Handler.CurNode);
                    if (id == Permission_Handler.CurNode) {
                        //编辑
                        Permission_Handler.GetEditData(id);
                    } else {
                        ShowMsg("请先编辑提交新建项");
                    }

                } else {
                    Permission_Handler.GetEditData(id);
                }

            }
        });


        $("#Add_folder").click(function() {

            Permission_Handler.InitAddDictEvent();
        });

        $("#Edit_folder").click(function() {
            Permission_Handler.InitEditDictEvent();
        });

        $("#Del_folder").click(function() {
            ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                if (yes) {
                    Permission_Handler.DelDictEvent();
                }
            });
        });

        //表单初始化option
        var options = {
            success: function(data) { Permission_Handler.AfterOperation(data); },  // post-submit callback
            width: 800,
            timeout: 3000
        };

        // bind form using 'ajaxForm'
        Permission_Handler.thisForm.ajaxForm(options);
    }
}