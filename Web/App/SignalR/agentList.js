$(function () {

    var hub = $.connection.customerHub;

    hub.client.updateAgentStatus = function (agentStatus) {

        agentStatus.class = $.App.Agents.getStatusClass(agentStatus.Status);
        var agentContainer = $("div#agent_" + agentStatus.AgentId);

        agentContainer
            .find("div.status-graphic")
            .attr("class", "")
            .addClass("col-lg-1 status-graphic")
            .addClass(agentStatus.class);

        agentContainer
            .find("div.agent-status")
            .text(agentStatus.Status);
    };

    $.connection.hub.start();
});