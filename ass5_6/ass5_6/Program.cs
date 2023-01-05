
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpAssignment5._5
{

    public class Player
    {
        public string Name;
        public int run;

        public Player(string Name, int run)
        {
            this.Name = Name;
            this.run = run;
        }
    }
    class Team : IEnumerable
    {
        public Player[] player;

        public Team(Player[] playerArray)
        {
            player = new Player[playerArray.Length];
            for (int i = 0; i < playerArray.Length; i++)
            {
                player[i] = playerArray[i];
            }
        }


        //Get enumerator method implementation
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public TeamEnum GetEnumerator()
        {
            return new TeamEnum(player);
        }
    }
    //implementation of IEnumerator
    public class TeamEnum : IEnumerator
    {
        private Player[] player;
        public int pos = -1;

        public TeamEnum(Player[] p)
        {
            player = p;
        }
        public bool MoveNext()
        {
            pos++;
            return (pos < player.Length);
        }

        public void Reset()
        {
            pos = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Player Current
        {
            get
            {
                try
                {
                    return player[pos];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Player[] uInfo = new Player[3]{
 new Player("Suresh", 100),
 new Player("Virat", 90),
 new Player("Dhoni", 80)
 };
            Team t = new Team(uInfo);
            foreach (var Res in t)
            {
                Console.WriteLine(Res.Name + ", " + Res.run);
            }
            Console.ReadLine();
        }
    }
}

