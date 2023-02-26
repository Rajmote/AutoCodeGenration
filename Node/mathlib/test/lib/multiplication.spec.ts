import {assert} from 'chai'
import multiply_two_number from '../../src/lib/multiply'

describe("Multiplication tests", () => {
    it("Should return 10 if 2 and 5 are multiplies", () => {
        let result = multiply_two_number(2, 5);
        assert.equal(result, 10)
    })
    it("Should return 10 if 1 and 10 are multiplies", () => {
        let result = multiply_two_number(1, 10);
        assert.equal(result, 10)
    })
    it("Should return 0 if 18 and 0 are multiplies", () => {
        let result = multiply_two_number(18, 0);
        assert.equal(result, 0)
    })
})