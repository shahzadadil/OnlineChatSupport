$(function () {

    var getClassFromStatus = function (status) {

        if (typeof status == "undefined" || status == null || status == "") {
            return "";
        }

        if (status == 'on call') {
            return "on-call";
        } else if (status == 'available') {
            return "available";
        } else if (status == 'offline') {
            return "offline";
        } else if (status == 'inactive') {
            return "inactive";
        } else {
            return "";
        }
    };

    $.App.Agents.getStatusClass = getClassFromStatus;

});