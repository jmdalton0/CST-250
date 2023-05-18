using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    public class Hero
    {
        private String name;
        private DateTime birthDate;
        private DateTime discoveryDate;
        private List<String> powers;
        private List<String> locations;
        private String vehicle;
        private int experience;
        private int bravery;
        private int durability;
        private int intelligence;
        private int leadership;
        private Color primaryColor;
        private Color secondColor;

        public Hero()
        {
            this.name = "Hero";
            this.powers = new List<String>();
            this.locations = new List<String>();
            this.vehicle = "none";
        }

        public String getName()
        {
            return name;
        }

        public DateTime getBirthDate()
        {
            return birthDate;
        }

        public DateTime getDiscoveryDate()
        {
            return discoveryDate;
        }

        public List<String> getPowers()
        {
            return powers;
        }

        public List<String> getLocations()
        {
            return locations;
        }

        public String getVehicle()
        {
            return vehicle;
        }

        public int getExperience()
        {
            return experience;
        }

        public int getBravery()
        {
            return bravery;
        }

        public int getDurability()
        {
            return durability;
        }

        public int getIntelligence()
        {
            return intelligence;
        }

        public int getLeadership()
        {
            return leadership;
        }

        public Color getPrimaryColor()
        {
            return primaryColor;
        }

        public Color getSecondColor()
        {
            return secondColor;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }

        public void setDiscoverDate(DateTime discoverDate)
        {
            this.discoveryDate = discoverDate;
        }

        public void addPower(String power)
        {
            this.powers.Add(power);
        }

        public void addLocation(String location)
        {
            this.locations.Add(location);
        }

        public void setVehicle(String vehicle)
        {
            this.vehicle = vehicle;
        }

        public void setExperience(int experience)
        {
            this.experience = experience;
        }

        public void setBravery(int bravery)
        {
            this.bravery = bravery;
        }

        public void setDurability(int durability)
        {
            this.durability = durability;
        }

        public void setIntelligence(int intelligence)
        {
            this.intelligence = intelligence;
        }

        public void setLeadership(int leadership)
        {
            this.leadership = leadership;
        }

        public void setPrimaryColor(Color primaryColor)
        {
            this.primaryColor = primaryColor;
        }

        public void setSecondColor(Color secondColor)
        {
            this.secondColor = secondColor;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + name);
            sb.AppendLine("Birthday: " + birthDate.ToString());
            sb.AppendLine("Discovered Powers on: " + discoveryDate.ToString());
            sb.Append("Powers: ");
            foreach (String power in powers)
            {
                sb.Append(power + ", ");
            }
            sb.AppendLine();
            sb.Append("Locations: ");
            foreach (String location in locations)
            {
                sb.Append(location + ", ");
            }
            sb.AppendLine();
            sb.AppendLine("Vehicle: " + vehicle);
            sb.AppendLine("Experience: " + experience.ToString());
            sb.AppendLine("Bravery: " + bravery.ToString());
            sb.AppendLine("Durability: " + durability.ToString());
            sb.AppendLine("Intelligence: " + intelligence.ToString());
            sb.AppendLine("Leadership: " + leadership.ToString());
            sb.AppendLine("Primary Color: " + primaryColor.ToString());
            sb.AppendLine("Second Color: " + secondColor.ToString());
            return sb.ToString();
        }
    }
}
