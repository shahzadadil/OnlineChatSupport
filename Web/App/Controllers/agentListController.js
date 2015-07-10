angular.module("onlineChatSupport", ["ngResource"])
  .constant("agentListUrl", "/api/Agent")
  .config(function ($httpProvider) {
      $httpProvider.defaults.withCredentials = true;
  })
  .controller("agentListController", function ($scope, $filter, $resource, agentListUrl) {

      $scope.agentsResource = $resource(agentListUrl);

      $scope.listAgents = function () {

          $scope.agents = $scope.agentsResource.query();
      };

      $scope.statusFilter = function (agent) {

          if (typeof agent.Status == "undefined" || agent.Status == null || agent.Status == "") {
              agent.class = "";
              return true;
          }

          if (agent.Status == 'on call') {
              agent.class = "on-call";
          } else if (agent.Status == 'available') {
              agent.class = "available";
          } else if (agent.Status == 'offline') {
              agent.class = "offline";
          } else if (agent.Status == 'inactive') {
              agent.class = "inactive";
          }

          return true;
      };

      $scope.listAgents();
  });