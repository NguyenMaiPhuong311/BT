﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duan2
{
    internal class Robot : Player
    {
        List<int> chooses = new List<int> {1,2,3,4,5,6,7,8,9 };
        public Robot(char sign = 'O') : base(sign)
        {
            
        }
        public  int takeTurn()
        {
         Random rd = new Random();
            int index = rd.Next(0, chooses.Count-1);
            return chooses[index];
        }

        public void  removeChoose(int value)
        {
            chooses.Remove(value);
        }


    }
}
