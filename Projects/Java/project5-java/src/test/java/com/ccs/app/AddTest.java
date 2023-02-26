package com.ccs.app;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class AddTest {

    @Test
    public void addOppTest() {
        Add a = new Add();
        assertEquals(30, a.add(10, 20));
    }

}
