const assert = require("chai").assert;
const expect=require("chai").expect;
const HolidayPackage = require("./solution");

describe("Holiday package test", () => {
    let holidayPackage;
    beforeEach(function () {
        holidayPackage = new HolidayPackage('Italy', 'Summer');
    });

    describe("Constructor tests", () => {
        it('should return default fault', function () {
            assert.equal(holidayPackage.insuranceIncluded,false);
        });
    });

    describe("showVacationers",()=>{
        it('should ', function () {
            assert.equal(holidayPackage.showVacationers(),"No vacationers are added yet");
        });
    });

    describe("addVacioner() tests",()=>{
        it('should throw an Rrror', function () {
        holidayPackage.addVacationer(5);

            expect(() => holidayPackage.addVacationer(5)).to.throw(Error);
        });
    });
});