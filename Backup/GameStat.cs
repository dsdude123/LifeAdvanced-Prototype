using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeAdvanced
{
    class GameStat
    {
        private int value;
        private int max;
        private int min;

        public GameStat(int v, int max, int min)
        {
            if (v > min && v < max)
            {
                this.value = v;
                this.max = max;
                this.min = min;
            }
            else if (v == min || v == max)
            {
                this.value = v;
                this.max = max;
                this.min = min;

            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void add(int n)
        {
            if ((this.value + n) < this.max || (this.value + n) == this.max)
            {
                this.value += n;
            }
        }

        public void subtract(int n)
        {
            if ((this.value - n) > this.min || (this.value - n) == this.min)
            {
                this.value += n;
            }
        }

        public void set(int n)
        {
            if (n > min && n < max)
            {
                this.value = n;
            }
            else if (n == min || n == max)
            {
                this.value = n;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int get()
        {
            return this.value;
        }
    }
}
