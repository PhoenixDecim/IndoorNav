using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class LogAssertTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void LogAssertSimplePasses()
        {
            // Use the Assert class to test conditions
            //Expect a regular log message
            LogAssert.Expect(LogType.Log, "Log message");
            //A log message is expected so without the following line
            //the test would fail
            Debug.Log("Log message");
            //An error log is printed
            Debug.LogError("Error message");
            //Without expecting an error log, the test would fail
            LogAssert.Expect(LogType.Error, "Error message");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        /*[UnityTest]
        public IEnumerator LogAssertWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }*/
    }
}
