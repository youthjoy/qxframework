function jsInclude(modulesArray) {

    var pathtojsfiles = "/Scripts/Module/"; // need to be ajusted
    // set include to false if you do not want some modules to be included
    var combineIntoOne = false;
    var combinedInclude = new Array();
    //var combinedIncludeURL = "combine.php?type=javascript&files=";
    var minver = false;
    var modules = [

    ];

    $.extend(modules, modulesArray);
    
    var filename;
    for (var i = 0; i < modules.length; i++) {
        if (modules[i].include === true) {

            if (minver !== true) filename = pathtojsfiles + modules[i].incfile;
            else filename = pathtojsfiles + modules[i].minfile;
            if (combineIntoOne !== true) {
                if (jQuery.browser.safari || jQuery.browser.msie) {
                    jQuery.ajax({ url: filename, dataType: 'script', async: false, cache: true });
                } else {
                    IncludeJavaScript(filename);
                }
            } else {
                combinedInclude[combinedInclude.length] = filename;
            }
        }
    }

    function implode(glue, pieces) {
        return ((pieces instanceof Array) ? pieces.join(glue) : pieces);
    };

    function IncludeJavaScript(jsFile) {
    
        var oHead = document.getElementsByTagName('head')[0];
        var oScript = document.createElement('script');
        oScript.type = 'text/javascript';
        oScript.charset = 'utf-8';
        oScript.src = jsFile;
        oHead.appendChild(oScript);
    };
};