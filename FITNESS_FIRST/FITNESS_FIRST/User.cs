using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessFirst
{
    public class User
    {
        public int id;
        public string name;
        public string username;
        public string password;
        public int score;
        public int highscore;
        public string email;
        public char gender;

        public User(int id, string n, string un, string p, int s, int h, string e, char g)
        {
            this.id = id;
            username = un;
            password = p;
            name = n;
            email = e;
            gender = g;
            score = s;
            highscore = h;
        }
    }
}
