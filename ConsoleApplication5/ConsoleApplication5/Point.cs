﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{

    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point() { }

        public override bool Equals(object obj)
        {
            Point o = obj as Point;
            if (this.x == o.x && this.y == o.y) return true;
            return false;
        }
    }
}
