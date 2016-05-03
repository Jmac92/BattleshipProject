using System;
using NUnit.Framework;

namespace MyGame
{
	[TestFixture]
	public class TestHitTile
	{
		[Test]
		public void TestHitTileNoShip ()
		{
			BattleShipsGame testGame = new BattleShipsGame ();
			Player testPlayer = new Player (testGame);

			AttackResult actual = testPlayer.PlayerGrid.HitTile (0, 0);
			Assert.AreEqual ("missed", actual.Text, "yolo");
		}

		[Test]
		public void TestHitTileHitShip ()
		{
			BattleShipsGame testGame = new BattleShipsGame ();
			Player testPlayer = new Player (testGame);

			testPlayer.PlayerGrid.MoveShip (0, 0, ShipName.Submarine, Direction.LeftRight);

			AttackResult actual = testPlayer.PlayerGrid.HitTile (0, 0);
			Assert.AreEqual ("hit something!", actual.Text, "yolo");
		}

		[Test]
		public void TestHitTileDestroyShip ()
		{
			BattleShipsGame testGame = new BattleShipsGame ();
			Player testPlayer = new Player (testGame);

			testPlayer.PlayerGrid.MoveShip (0, 0, ShipName.Tug, Direction.LeftRight);

			AttackResult actual = testPlayer.PlayerGrid.HitTile (0, 0);
			Assert.AreEqual ("destroyed the enemy's", actual.Text, "yolo");
		}
	}
}

