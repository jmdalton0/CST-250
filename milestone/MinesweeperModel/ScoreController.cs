using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperModel
{
    public class ScoreController
    {
        private const string PATH = @"C:\Users\jmdal\Projects\CST250\milestone\db\save.txt";

        private List<Score> scores;

        public ScoreController()
        {
            scores = new List<Score>();
            load();
        }

        private void load()
        {
            List<string> lines = new List<string>();
            try
            {
                lines = File.ReadAllLines(PATH).ToList();
            }
            catch (Exception e)
            {
            }

            foreach (string line in lines)
            {
                string[] entries = line.Split('|');
                Score toLoad = new Score();
                toLoad.name = entries[0];
                toLoad.time = TimeSpan.Parse(entries[1]);
                if (entries[2].Equals("difficult")) {
                    toLoad.level = Level.difficult;
                }
                else if (entries[2].Equals("medium"))
                {
                    toLoad.level = Level.medium;
                }
                else
                {
                    toLoad.level = Level.easy;
                }
                scores.Add(toLoad);
            }
        }

        public void save(Score score)
        {
            scores.Add(score);
            List<string> lines = new List<string>();
            for (int i = 0; i < scores.Count; i++)
            {
                Score toSave = scores[i];
                lines.Add(toSave.name + "|" + toSave.time.ToString() + "|" + toSave.level.ToString());
            }
            File.Create(PATH).Close();
            File.WriteAllLines(PATH, lines);
        }

        public List<Score> filterScores(Level level)
        {
            var filtered =
                from score in scores
                where score.level == level
                orderby score
                select score;
            return filtered.Take(5).ToList();
        }
    }
}
