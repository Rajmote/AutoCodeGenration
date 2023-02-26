package com.ccs.app;

import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertTrue;

public class DivTest {

    @Test
    public void divOppTest() {
        Div d = new Div();
        assertEquals(2.0d, d.div(20, 10), 0.01);
    }

}
