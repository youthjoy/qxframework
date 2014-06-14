//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////
//通用Session操作类
var Comm_Session = {

    ///设置Session
    SetValue: function(key, val) {
        $.ajax({
            url: '/SysSession/set',
            type: 'post',
            data: { 'key': key, 'val': val },
            success: function(data) {
                callback(data);
            }
        });
    },
    ///获取Session
    GetValue: function(key, callback) {

        $.ajax({
            url: '/SysSession/get',
            type: 'post',
            data: { 'key': key },
            success: function(data) {
                callback(data);
            }
        });
    },
    ///获取当前登录用户信息
    GetLoginUser: function(callback) {

        $.ajax({
        url: '/SysSession/GetLoginUser',
            type: 'post',
            success: function(data) {
                callback(data);
            }
        });
    },
    ///获取服务器当前日期
    GetCurrentDate: function(callback) {
        $.ajax({
        url: '/SysSession/GetCurrentDate',
            type: 'post',
            success: function(data) {callback(data);}
        });
    },
    ///获取服务器当前时间
    GetCurrentTime: function(callback) {
        $.ajax({
        url: '/SysSession/GetCurrentTime',
            type: 'post',
            success: function(data) {callback(data);}
        });
    }
}