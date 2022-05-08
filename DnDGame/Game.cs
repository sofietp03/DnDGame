using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGame
{
    internal class Game
    {

        Skills skills = new Skills();
        Character Character = new Character();



        public Game()
        {
            while (true)
            {
                Menu();
            }
       



        }

        public void Menu()
        {
            
            Console.WriteLine("press 1 for roll for skills");
            Console.WriteLine("press 2 for create character");


            switch (Console.ReadKey(true).Key)
            {

                case ConsoleKey.D1:
                    Console.WriteLine("");
                    RollSkills();
                    ShowSkills();
                    pickCharacterType();

                    break;

                    case ConsoleKey.D2:
               
                 

                        break;

            }


        }
        public int RollSkills()
        {
            Random random = new Random();
            int Roll = 0;

            for (int i = 0; i < 3; i++)
            {
                int dice = random.Next(1, 7);
                Console.Write(dice+ " ");
                Roll += dice;
            }
            return Roll;
        }

             
        public void ShowSkills()
        {
            
            do
            {
                Console.Clear();
                skills.Strength = RollSkills();

                Console.WriteLine(" Strength " + skills.Strength);

                skills.Intelligence = RollSkills();

                Console.WriteLine(" Intelligence " + skills.Intelligence);

                skills.Wisdom = RollSkills();

                Console.WriteLine(" Wisdom " + skills.Wisdom);

                skills.Dexterity = RollSkills();

                Console.WriteLine(" Dexterity " + skills.Dexterity);

                skills.Constitution = RollSkills();

                Console.WriteLine(" Constitution " + skills.Constitution);

                skills.Charisma = RollSkills();

                Console.WriteLine(" Charima " + skills.Charisma);

                Console.WriteLine("\nAny key for Reroll or X for Exit");

            } while (Console.ReadKey(true).Key != ConsoleKey.X);
            Console.Clear();
           
        }


        public void pickCharacterType()
        {

            
            Console.WriteLine("Choose your Character type: ");
            foreach (var characterType in Enum.GetValues(typeof(Characters)))
            {
                Console.WriteLine( (int) characterType + " " + characterType.ToString());
            }           
            Character.Characters = (Characters)(int)Console.ReadKey().Key - 48;

            Console.WriteLine(Character.Characters);


            while (Character.Name == null || Character.Name == "")
            {
                Console.Write("Pick a name: ");
                Character.Name = Console.ReadLine();


            }

            

        }

        



       
            
    }
}
