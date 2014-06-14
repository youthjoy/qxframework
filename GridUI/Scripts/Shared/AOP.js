Aspects = function() { };
Aspects.prototype = {
    before: function(target, method, advice) {
        var original = target[method];
        target[method] = function() {
            (advice)();
            original.apply(target, arguments);
        }
        return target
    },
    after: function(target, method, advice) {
        var original = target[method];
        target[method] = function() {
            original.apply(target, arguments);
            (advice)();
        }
        return target
    },
    around: function(target, method, advice) {
        var original = target[method];
        target[method] = function() {
            (advice)();
            original.apply(target, arguments);
            (advice)();
        }
        return target
    }
}