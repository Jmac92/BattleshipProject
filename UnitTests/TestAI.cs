using NUnit.Framework;
using System;

namespace MyGame
{
	[Test]
	public class TestAISetting
	{
		[Test ()]
		public void TestMedium ()
		{
			BattleShipsGame testAI = new BattleShipGame ();
			AI = new AIMediumPlayer(testAI)
			
			TestAISetting actual = AIOption.Medium();		

			Assert.IsTrue(true,AIOption.Medium);
			
		}
	}


		[Test ()]
		public void TestMedium ()
		{
			BattleShipsGame testAI = new BattleShipGame ();
			AI = new AIHardPlayer(testAI)

				TestAISetting actual = AIOption.Hard();		

			Assert.IsTrue(true,AIOption.Hard);

		}
}

