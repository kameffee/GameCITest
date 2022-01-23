using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

namespace GameCITest.Tests.PlayMode
{
    public class PlayerMoveTest
    {
        [UnityTest]
        public IEnumerator PlayerMove()
        {
            var player = new GameObject("Player");
            player.transform.position += new Vector3(0, 2, 0);

            yield return null;

            Assert.That(player.transform.position.y, Is.EqualTo(2));
        }
    }
}
