﻿
class Operations
{
    public static int add(int a, int b)
    {
        return a + b;
    }

    public static int subtract(int a, int b)
    {
        return a - b;
    }

    public static int multiply(int a, int b)
    {
        return a *= b;
    }

    public static int divide(int a, int b)
    {
        return b==0?1000000000 : a / b;
    }
}
