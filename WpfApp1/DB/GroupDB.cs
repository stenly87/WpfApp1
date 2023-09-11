using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.DB
{
    static class GroupDB
    {
        public static List<Group> Groups;

        static GroupDB()
        {
            Groups = new List<Group>();
            Groups.Add(new Group {Name = "1135"});
        }
    }
}
