using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Refactoring.TennisGames.Solution
{
    public interface ITennisGame
    {
        void WonPoint(string playerName);
        string GetScore();

    }
}
