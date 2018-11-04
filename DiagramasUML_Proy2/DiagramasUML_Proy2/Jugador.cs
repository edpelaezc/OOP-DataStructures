using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramasUML_Proy2
{
    class Jugador:Persona
    {
        private int id;
        private string conference;
        private string team;
        private string position;
        private int power;
        private string skill;
        private int height;
        private int scoredPoints;
        private int stolenBalls;
        private int rebounds;
        private int plugs;
        private int votes;       

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getConference()
        {
            return conference;
        }
        public void setConference(string conference)
        {
            this.conference = conference;
        }
        public string getTeam()
        {
            return team;
        }
        public void setTeam(string team)
        {
            this.team = team;
        }
        public string getPosition()
        {
            return position;
        }
        public void setPosition(string position)
        {
            this.position = position;
        }
        public int getPower()
        {
            return power;
        }
        public void setPower(int power)
        {
            this.power = power;
        }
        public string getSkill()
        {
            return skill;
        }
        public void setSkill(string skill)
        {
            this.skill = skill;
        }
        public int getHeight()
        {
            return height;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
        public int getScoredPoints()
        {
            return scoredPoints;
        }
        public void setScoredPoints(int scoredPoints)
        {
            this.scoredPoints = scoredPoints;
        }
        public int getStolenBalls()
        {
            return stolenBalls;
        }
        public void setStolenBalls(int stolenBalls)
        {
            this.stolenBalls = stolenBalls;
        }
        public int getRebounds()
        {
            return rebounds;
        }
        public void setRebounds(int rebounds)
        {
            this.rebounds = rebounds;
        }
        public int getPlugs()
        {
            return plugs;
        }
        public void setPlugs(int plugs)
        {
            this.plugs = plugs;
        }
        public int getVotes()
        {
            return votes;
        }
        public void setVotes(int votes)
        {
            this.votes = votes;
        }

        public string toString()
        {
            return "Jugador [id=" + id + ", conference=" + conference + ", team=" + team + ", position=" + position
                    + ", power=" + power + ", skill=" + skill + ", height=" + height + ", scoredPoints=" + scoredPoints
                    + ", stolenBalls=" + stolenBalls + ", rebounds=" + rebounds + ", plugs=" + plugs + ", votes=" + votes
                    + "]";
        }
    }
}
