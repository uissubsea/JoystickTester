﻿using JoystickInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoystickTest
{
    public class JoystickMock : IJoystick
    {
        private Random r;
        private int[] pov = { -1, 0, 45, 90, 125, 180, 225, 270, 315 };

        public JoystickMock()
        {
            r = new Random();
        }

        public int Throttle()
        {
            return r.Next(0, 251);
        }

        public int Pitch()
        {
            return r.Next(0, 251);
        }

        public int Roll()
        {
            return r.Next(0, 251);
        }

        public int Yaw()
        {
            return r.Next(0, 251);
        }

        public byte[] Buttons()
        {
            byte[] buttons = new byte[7];
            for (int i = 0; i < 7; i++)
            {
                int rnd = r.Next(0, 2);
                if(rnd > 0)
                    buttons[i] = 255;
                else
                    buttons[i] = 0;
            }
            return buttons;
        }

        public int PointOfView()
        {
            int randomPos = r.Next(0, 9);
            return pov[randomPos];
        }
    }
}