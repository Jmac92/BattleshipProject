using NUnit.Framework;
using System;

namespace ksdjfhg
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestCase ()
		{
			Player[] _players = new Player[3];

			int _playerIndex = 0;
			int otherPlayer = (_playerIndex + 1) % 2;

			_playerIndex = otherPlayer;

			Assert.AreEqual (1 , _playerIndex);
		}
	}
}

