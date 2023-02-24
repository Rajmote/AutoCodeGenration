package com.ccs.app;

import org.junit.Test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertTrue;

public class SubTest {

    @Test
    public void addOppTest() {
        Sub s = new Sub();
        assertEquals(30, s.sub(50, 20));
    }

}
