using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewTestScript 
{
    [Test]
    public void TestAnotherStaticFunction() 
    {
        int a = NewBehaviorScript.FunctionUnderTest(1);
        int b = 1;

        // Use the Assert class to test conditions.
        Assert.IsTrue(a == b);
    }
}
