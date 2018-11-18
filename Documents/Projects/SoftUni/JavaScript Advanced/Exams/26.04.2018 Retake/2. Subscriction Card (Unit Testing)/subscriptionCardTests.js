const assert = require("chai").assert;
const SubscriptionCard = require("./subscriptionCard");

describe("SubscriptionCard tests", () => {
    describe("Constructor tests", () => {
        it('should be initialized correctly', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');

            assert.equal(card.firstName, "Pesho");
            assert.equal(card.lastName, "Petrov");
            assert.equal(card.SSN, "00000000");
        });
    });

    describe("Function isBlocked() tests", () => {
        it('should return true', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');

            card.block();

            assert.equal(card.isBlocked, true);
        });

        it('should return false', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');

            card.block();
            card.unblock();

            assert.equal(card.isBlocked, false);
        });

        it('should return false', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');

            assert.equal(card.isBlocked, false);
        });
    });

    describe("Function addSubscription() tests", () => {
        it('should return valid subscriptions', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');

            assert.equal(card._subscriptions.length, 0);
            assert.equal(card._subscriptions[0], undefined);
        });

        it('Add correctly subscription', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));

            assert.equal(card._subscriptions[0].line, "120");
            assert.equal(card._subscriptions[0].startDate, (new Date('2018-04-22').toString()));
            assert.equal(card._subscriptions[0].endDate, (new Date('2018-05-21')).toString());
        });

        it('Add correctly subscription', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-21'));
            card.addSubscription("*", new Date('2013-04-22'), new Date('2013-05-21'));

            assert.equal(card._subscriptions[0].line, "120");
            assert.equal(card._subscriptions[0].startDate, (new Date('2018-04-22').toString()));
            assert.equal(card._subscriptions[0].endDate, (new Date('2018-05-21')).toString());
            assert.equal(card._subscriptions[1].line, "*");
            assert.equal(card._subscriptions[1].startDate, (new Date('2013-04-22').toString()));
            assert.equal(card._subscriptions[1].endDate, (new Date('2013-05-21')).toString());
        });
    });

    describe("Finction isValid() tests", () => {
        it('should return false', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');

            card.block();

            assert.equal(card.isValid(), false);
        });

        it('should return false', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');

            assert.equal(card.isValid('120', new Date('2018-04-22')), false);
        });

        it('should return true', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-22'), new Date('2018-05-23'));

            assert.equal(card.isValid('120', new Date('2018-04-22')), true);
        });

        it('should return false', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-25'), new Date('2018-05-23'));

            assert.equal(card.isValid('120', new Date('2018-04-22')), false);
        });

        it('should return false', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('120', new Date('2018-04-19'), new Date('2018-04-21'));

            assert.equal(card.isValid('120', new Date('2018-04-22')), false);
        });

        it("Blocked card", function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('*', new Date('2018-04-22'), new Date('2018-05-21'));

            card.block();

            assert.equal(card.isValid('120', new Date('2018-04-24')), false);
        });

        it("On end date", function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.addSubscription('*', new Date('2018-04-22'), new Date('2018-05-21'));
            assert.equal(card.isValid('12112323', new Date('2018-05-21')), true);
        })
    });

    describe("Should not set the values", () => {
        it('should not change', function () {
            const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
            card.firstName = 'Test';
            card.lastName = 'Test';
            card.SSN = 'Test';
            assert.equal(card.firstName, 'Pesho');
            assert.equal(card.lastName, 'Petrov');
            assert.equal(card.SSN, '00000000');
        });
    });
});