using System;
using System.Collections;
using UnityEngine;
using Random = System.Random;

namespace DefaultNamespace
{
    public class CircleColor
    {
        private static Random random = new Random();

        public static int TURQAISE = 0;
        public static int PINK = 1;
        public static int YELLOW = 2;
        public static int BLUE = 3;

        public static int getRandomColor()
        {
            return random.Next( 4);
        }

        public static Color getColor(int colorNum)
        {
            if (colorNum == TURQAISE)
            {

                return new Color(0,255,255,255);
            }
            else if (colorNum == PINK)
            {
                return new Color(255,0,0,255);
            }
            else if (colorNum == YELLOW)
            {
                return new Color(255,255,0,255);
            }
            else
            {
                return new Color(0,0,255,255);
            }
        }

        public static String getColorName(int colorNum)
        {
            if (colorNum == TURQAISE)
            {
                return "Turquoise";
            }
            else if (colorNum == BLUE)
            {
                return "Blue";
            }
            else if (colorNum == YELLOW)
            {
                return "Yellow";
            }
            else
            {
                return "Pink";
            }
        }
    }
}