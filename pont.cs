using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pontok
{
    public class Pont
    {
        private int x;
        private int y;
        private static Random random = new Random();

        public Pont()
        {
            this.x = 0;
            this.y = 0;
        }

        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Pont(int n)
        {
            this.x = random.Next(-n, n + 1);
            this.y = random.Next(-n, n + 1);
        }

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        public double Tavolsag()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y);
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
