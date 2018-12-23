# Unity3dTestSample

Bare reproduction of a problem that I'm having with test functionality in Unity3d. 

This project contains two key files:  

\Assets\Scenes\NewBehaviourScript.cs

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour 
{
	/// <summary>
	/// the stupidest function in the world, 
	/// used to verify tests.
	/// </summary>
	public static int FunctionUnderTest(int a)
	{
		return a;
	}
}
```

and 

\Assets\TestS\NewTestScript.cs

```
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
```

the line :

```
        int a = NewBehaviorScript.FunctionUnderTest(1);
```

is causing the compilation error:

```
Assets/TestS/NewTestScript.cs(11,17): error CS0103: The name `NewBehaviorScript' does not exist in the current context
```

Can this be resolved?