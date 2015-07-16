/// <reference path="../../Scripts/jquery-2.1.4.js" />
/// <reference path="../Framework/init.js" />
/// <reference path="../Framework/helper.js" />


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

          agent.class = $.App.Agents.getStatusClass(agent.Status);

          return true;
      };

      $scope.listAgents();
  });