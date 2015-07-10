/// <reference path="../../Scripts/angular.js" />
/// <reference path="../../Scripts/angular-resource.js" />
/// <reference path="../../Scripts/angular-mocks.js" />
/// <reference path="../../App/Controllers/agentListController.js" />


describe("Agent list", function () {

    beforeEach(module("onlineChatSupport"));

    var agentListController, scope;

    beforeEach(inject(function ($rootScope, $controller) {

        scope = $rootScope.$new();

        agentListController = $controller("agentListController", {
            $scope: scope
        });

    }));


    it("should insert class property into agent", function () {

        var agent = new Object();
        agent.Status = "available";

        scope.statusFilter(agent);

        expect(typeof agent.class).not.toBe("undefined");
    });

    it("should set class as on-call when agent status is on call", function () {

        var agent = new Object();
        agent.Status = "on call";

        scope.statusFilter(agent);

        expect(agent.class).toBe("on-call");
    });

    it("should set class as null when agent status is not available", function () {

        var agent = new Object();

        scope.statusFilter(agent);

        expect(agent.class).toBe("");
    });

});
