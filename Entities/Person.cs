using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekSeat.Entities
{
    public class Person
    {
        public Person()
        {

        }

        public Person(int deathAge, int deathYear)
        {
            DeathAge = deathAge;
            DeathYear = deathYear;
        }

        [Required]
        public int DeathAge { get; set; }

        [Required]
        public int DeathYear { get; set; }

        public int YearOfKilled 
        { 
            get
            {
                return DeathYear - DeathAge;
            }
        }

        //Fibonacci
        public int KilledPeopleByYear  
        {
            get 
            {
                if (YearOfKilled <= 0) return YearOfKilled;

                List<int> sequence = new List<int>() { 0, 1 };
                
                int firstNumber = 0, secondNumber = 1, nextNumber = 0;

                if (YearOfKilled <= 0)
                    return firstNumber;

                for (int i = 2; i <= YearOfKilled; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                    sequence.Add(secondNumber);
                }

                int result = 0;
                foreach (int value in sequence)
                    result += value;

                return result;
            }
        }

        public bool IsValid
        {
            get
            {
                return KilledPeopleByYear >= 0;
            }
        }
    }
}
