using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperModel
{
    public class Score : IComparable
    {
        public string name { get; set; }
        public TimeSpan time { get; set; }
        public Level level { get; set; }

        public Score()
        {
            this.name = string.Empty;
            this.time = TimeSpan.Zero;
            this.level = Level.easy;
        }

        public Score(string name, TimeSpan time, Level level)
        {
            this.name = name;
            this.time = time;
            this.level = level;
        }

        public string toString()
        {
            return name + "\t\t" + time.ToString("mm\\:ss");
        }

        public int CompareTo(object o)
        {
            if (o == null) return 1;
            try
            {
                Score other = (Score)o;
                if (this.level < other.level)
                {
                    return -1;
                }
                else if (this.level > other.level)
                {
                    return 1;
                }
                else
                {
                    if (this.time < other.time)
                    {
                        return -1;
                    }
                    else if (this.time > other.time)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException("Object is not a Score");
            }
        }
    }
}
