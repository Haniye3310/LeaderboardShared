using System;

namespace LeaderboardShared
{
    interface ILeaderboardData
    {
        // to do
        public int ID { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
