using System;
using NUnit.Framework;

namespace MyGame
{
	[TestFixture]
	public class TestTileStates
	{
		[Test]
		public void TestTileStateMiss ()
		{
			BattleShipsGame testGame = new BattleShipsGame ();
			Player testPlayer = new Player (testGame);
			Tile testTile = new Tile(0, 0, null);

			testTile.Shoot();
		
			Assert.AreEqual (TileView.Miss, testTile.View, "Tile should be in the 'miss' state.");
		}

		[Test]
		public void TestTileStateSea ()
		{
			BattleShipsGame testGame = new BattleShipsGame ();
			Player testPlayer = new Player (testGame);
			Tile testTile = new Tile(0, 0, null);

			Assert.AreEqual (TileView.Sea, testTile.View, "Tile should be in the 'sea' state.");
		}

		[Test]
		public void TestTileStateShip ()
		{
			BattleShipsGame testGame = new BattleShipsGame ();
			Player testPlayer = new Player (testGame);
			Tile testTile = new Tile(0, 0, null);
			Ship testShip = new Ship(ShipName.Tug);

			testTile.Ship = testShip;

			Assert.AreEqual (TileView.Ship, testTile.View, "Tile should be in the 'ship' state.");
		}

		[Test]
		public void TestTileStateHit ()
		{
			BattleShipsGame testGame = new BattleShipsGame ();
			Player testPlayer = new Player (testGame);
			Tile testTile = new Tile(0, 0, null);
			Ship testShip = new Ship(ShipName.Tug);

			testTile.Ship = testShip;
			testTile.Shoot();

			Assert.AreEqual (TileView.Hit, testTile.View, "Tile should be in the 'hit' state.");
		}
	}
}