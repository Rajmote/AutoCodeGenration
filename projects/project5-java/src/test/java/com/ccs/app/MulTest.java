package com.ccs.app;

import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertTrue;

public class MulTest {

    @Test
    public void addOppTest() {
        Mul m = new Mul();
        assertEquals(200, m.mul(10, 20));
    }

}
