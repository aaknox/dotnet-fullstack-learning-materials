namespace HelloWorld
{
    public enum Gender
    {
        Male, Female, Unsure
    }

    public class Saiyan
    {
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int PowerLevel { get; set; }
        public int DefenseLevel { get; set; }
        public string UltimateMove { get; set; }
        
        //fields
        // private Gender _gender;
        // public Gender Gender{
        //     get{
        //         return _gender;
        //     }
        //     set{
        //         _gender = value;
        //     }
        // }
        // private string _name; //this is a field

        // //this is the property associated to the respective field
        // public string Name{
        //     get{
        //         return _name;
        //     }

        //     set{
        //         _name = value;
        //     }
        // }

        // private string _ultimateMove;
        // public string UltimateMove{
        //     get{
        //         return _ultimateMove;
        //     }

        //     set{
        //         _ultimateMove = value;
        //     }
        // }
        // private int _powerLevel;
        // public int PowerLevel{
        //     get{
        //         return _powerLevel;
        //     }

        //     set{
        //         _powerLevel = value;
        //     }
        // }
        // private int _defenseLevel;
        // public int DefenseLevel{
        //     get{
        //         return _defenseLevel;
        //     }

        //     set{
        //         _defenseLevel = value;
        //     }
        // }

        //this is the constructor
        public Saiyan(Gender g, string n, string uM, int pL, int dL)
        {
            Gender = g;
            Name = n;
            UltimateMove = uM;
            PowerLevel = pL;
            DefenseLevel = dL;
        }

        public string GetPronoun()
        {
            switch(Gender)
            {
                case Gender.Female:
                    return "She";
                case Gender.Male:
                    return "He";
                case Gender.Unsure:
                    return "They";
                default:
                    return "They";
            }
        }

        public string Attack()
        {
            return Name + " attacks using " + UltimateMove;
        }

        public string Defend(int damage)
        {
            int remainingDamage = DefenseLevel - damage;
            if(remainingDamage <= 0){
                return Name + " defended the attack! [0 defense remaining.]";
            }else{
                return Name + " defended the attack! [ " + remainingDamage + " defense remaining.]";
            }
        }

        public string dragonRadarScan() 
        {
		    return this.GetPronoun() + " has a power level over " + PowerLevel + "!!!";
	    }

        public override string ToString()
        {
            return "Name: " + Name + ", powerLevel: " + PowerLevel + ", defenseLevel: " + DefenseLevel;
        }
    }
}