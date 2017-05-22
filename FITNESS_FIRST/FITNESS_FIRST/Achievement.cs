using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessFirst
{
    public class Achievement
    {
        public int id;
        public int userid;
        public string title;
        public string desc;
        public string howtoget;
        public Image image;

        public Achievement(int id, int userid, string title, string desc, string howtoget, Image image)
        {
            this.id = id;
            this.userid = userid;
            this.title = title;
            this.desc = desc;
            this.howtoget = howtoget;
            this.image = image;
        }

        public Achievement(string title, string desc, string howtoget, Image image)
        {
            this.id = -1;
            this.userid = -1;
            this.title = title;
            this.desc = desc;
            this.howtoget = howtoget;
            this.image = image;
        }
    }
}
