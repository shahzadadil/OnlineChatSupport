$(function () {

    var hub = $.connection.agentHub;

    $(document).on("change", "select.agent-status", function() {

        var agentId = $(this).parents("div.chat-box").attr("data-agent-id");
        var status = $(this).val();
        var data = {AgentId: agentId, Status: status};
        hub.server.updateStatus(data);

    });

    $.connection.hub.start();
});