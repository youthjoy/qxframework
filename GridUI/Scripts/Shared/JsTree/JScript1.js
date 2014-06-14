/// <reference path="../jquery-1.4.1-vsdoc.js" />

$(document).ready(function() {
    $("#Tree")
		.jstree({
           "plugins": ["themes", "json_data", "ui", "crrm", "cookies", "dnd", "search", "types", "hotkeys", "contextmenu", "unique"],
		    "json_data": {
		        "ajax": {
		            "url": "Home/GetData/",
		            "data": function(n) {
		                return {
		                    "operation": "get_children",
		                    "id": n.attr ? n.attr("id").replace("node_", "") : 1
		                };
		            }
		        }
		    },
		    "themes" : {
		        "theme": "default",
		        "url": "Content/themes/default/style.css",
		        "dots": false,
	            "icons" : false
	        },
		    "search": {
		        "ajax": {
		        "url": "Home/GetData/",
		            "data": function(str) {
		                return {
		                    "operation": "search",
		                    "search_str": str
		                };
		            }
		        }
		    },
		    "types": {
		        "max_depth": -2,
		        "max_children": -2,
		        "valid_children": ["drive"],
		        "types": {
		            "default": {
	                "valid_children": "none",
		                "icon": {
		                    "image": "./file.png"
		                }
		            },
		            "folder": {
		                "valid_children": ["default", "folder"],
		                "icon": {
		                    "image": "./folder.png"
		                }
		            },
		            "drive": {
		                "valid_children": ["default", "folder"],
		                "icon": {
		                    "image": "./root.png"
		                },
		                "start_drag": false,
		                "move_node": false,
		                "delete_node": false,
		                "remove": false
		            }
		        }
		    },
		    "ui": {
		        "initially_select": ["node_4"],
		         "select_limit" : 1,
	            "select_multiple_modifier" : "alt",
	            "selected_parent_close" : "select_parent"	            
		    }		    
		})
		.bind("create.jstree", function(e, data) {
		    $.post(
				"Home/GetData/",
				{
				    "operation": "create_node",
				    "id": data.rslt.parent.attr("id").replace("node_", ""),
				    "position": data.rslt.position,
				    "title": data.rslt.name,
				    "type": data.rslt.obj.attr("rel")
				},
				function(r) {
				    if (r.status) {
				        $(data.rslt.obj).attr("id", "node_" + r.id);
				    }
				    else {
				        $.jstree.rollback(data.rlbk);
				    }
				}
			);
		})
		.bind("remove.jstree", function(e, data) {
		    data.rslt.obj.each(function() {
		        $.ajax({
		            async: false,
		            type: 'POST',
		            url: "Home/GetData/",
		            data: {
		                "operation": "remove_node",
		                "id": this.id.replace("node_", "")
		            },
		            success: function(r) {
		                if (!r.status) {
		                    data.inst.refresh();
		                }
		            }
		        });
		    });
		})
		.bind("rename.jstree", function(e, data) {
		    $.post(
				"Home/GetData/",
				{
				    "operation": "rename_node",
				    "id": data.rslt.obj.attr("id").replace("node_", ""),
				    "title": data.rslt.new_name
				},
				function(r) {
				    if (!r.status) {
				        $.jstree.rollback(data.rlbk);
				    }
				}
			);
		})
		.bind("move_node.jstree", function(e, data) {
		    data.rslt.o.each(function(i) {
		        $.ajax({
		            async: false,
		            type: 'POST',
		            url: "Home/GetData/",
		            data: {
		                "operation": "move_node",
		                "id": $(this).attr("id").replace("node_", ""),
		                "ref": data.rslt.np.attr("id").replace("node_", ""),
		                "position": data.rslt.cp + i,
		                "title": data.rslt.name,
		                "copy": data.rslt.cy ? 1 : 0
		            },
		            success: function(r) {
		                if (!r.status) {
		                    $.jstree.rollback(data.rlbk);
		                }
		                else {
		                    $(data.rslt.oc).attr("id", "node_" + r.id);
		                    if (data.rslt.cy && $(data.rslt.oc).children("UL").length) {
		                        data.inst.refresh(data.inst._get_parent(data.rslt.oc));
		                    }
		                }
		                $("#analyze").click();
		            }
		        });
		    });
		});

});


