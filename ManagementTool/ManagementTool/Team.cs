﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Team
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<User> Members { get; set; }

        public Team(string name)
        {
            Name = name;
        }

        public void DeleteMember(User user)
        {
           for(int i = 0; i < Members.Count; i++)
                if (Members[i] == user)
                    Members.Remove(user);
        }
    }
}