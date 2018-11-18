const assert = require("chai").assert;
const expect=require("chai").expect;
const PaymentPackage = require("./paymentPackage");

describe("Payment Package tests", () => {
    describe("Constructor tests", () => {
        it('should throw an Error', function () {
            expect(() => new PaymentPackage()).to.throw();
            expect(() => new PaymentPackage(3,5,8)).to.throw();
        });
    });

    describe("Default obj value in obj",()=>{
       let package=new PaymentPackage('HR Services', 1500);

       assert.equal(package.name,)
    });
});