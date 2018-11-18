const assert = require("chai").assert;
const SubscriptionCard = require("./solution");

describe("SubscriptionCard tests", () => {
    let card;
    beforeEach(function () {
        card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
    });

    describe("Constructor tests", () => {
        it('should return correct results', function () {
            assert.equal(card.firstName, "Pesho");
            assert.equal(card.lastName, "Petrov");
            assert.equal(card.SSN, "00000000");
        });
    });

    describe("Function addSubscription() tests", () => {
        it('should add it', function () {
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            card.addSubscription('*', new Date('2018-05-25'), new Date('2018-06-24'));

            assert.equal(card._subscriptions[0].line, "120");
            assert.equal(card._subscriptions[0].startDate, new Date('2018-04-22').toString());
            assert.equal(card._subscriptions[0].endDate, new Date('2018-05-21').toString());
            assert.equal(card._subscriptions[1].line, "*");
            assert.equal(card._subscriptions[1].startDate, new Date('2018-05-25').toString());
            assert.equal(card._subscriptions[1].endDate, new Date('2018-06-24').toString());
        });
    });

    describe("Function isValid()", () => {
        it('should return false because tje vard is blocked', function () {
            card.block();

            assert.equal(card.isValid('120', new Date('2018-04-22')), false);
        });
    });
});