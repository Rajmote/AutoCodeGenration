import { assert } from "chai";
import add_two_numbers from '../../src/lib/addition'

describe("Addition tests", () => {
    it("Should return 6 when 4 is added to 2", () => {
        const result = add_two_numbers(4, 2)
        assert.equal(result, 6)
    })

    it("Should not return 8 when 5 and 5 are added", () => {
        const result = add_two_numbers(5, 2)
        assert.notEqual(result, 8)
    })
})
