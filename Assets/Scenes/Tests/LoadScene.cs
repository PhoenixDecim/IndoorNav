using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class LoadScene
    {
        // A Test behaves as an ordinary method
        [Test]
        public void LoadSceneByName() {
            SceneManager.LoadScene("Login");
            Debug.Log("Scene found");
            LogAssert.Expect(LogType.Log, "Scene found");
        }
            

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        /*[UnityTest]
        public IEnumerator LoadSceneWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
        }*/
    }
}
