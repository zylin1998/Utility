using System.Collections;
using System.Collections.Generic;
using Loyufei;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ObjectExtensionTest
{
    [Test]
    public void ObjectExtensionTestSimplePasses()
    {
        var a1 = new A();
        var a2 = a1;

        Assert.IsTrue(a1.Equals(a2));
        Assert.IsFalse(a2.IsDefault());

        a2 = null;
        Assert.IsTrue(a2.IsDefault());
    }

    public class A { }

    public class B { }
}
