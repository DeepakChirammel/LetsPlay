using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class LetsPlayTests
    {
        [OneTimeSetUp]
        public void LoadScene()
        {
            SceneManager.LoadScene("LetsPlay");
        }

        [UnityTest]
        public IEnumerator ShouldCalculateSumInstantly([Values(12, 97)] int a, [Values(13, 23)] int b)
        {
            GameObject.Find("InputFieldA").GetComponent<InputField>().text = a.ToString();
            GameObject.Find("InputFieldB").GetComponent<InputField>().text = b.ToString();
            yield return null;
            Assert.AreEqual((a + b).ToString(), GameObject.Find("SumText").GetComponent<Text>().text);
        }
    }
}