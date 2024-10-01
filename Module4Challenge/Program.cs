using System;

class GuessingGame
{
    static void Main()
        {
            //Welcoming the user to the program
            Console.WriteLine("Welcome to the Guessing Game!");
            
            //Letting the user know the machine is thinking of a number 1-100
            Console.WriteLine("The machine is thinking of a number 1-100... can you guess the number? ");

            //Allows to generate a random number from 1-100
            Random random = new Random();
            //Defines that the targetNumber is between 1-100
            int targetNumber = random.Next(1, 101);
            //Variable to store the users guess
            int usersGuess = 0;
            
            do 
            {
                //Allows user to input their guess
                Console.Write("Enter your guess: ");

                //Converts string into an int and ensures a value in usersGuess
                if(int.TryParse(Console.ReadLine(), out usersGuess))
                {
                    //Depending on the users guess, the following messages will be displayed according to conditions
                    if(usersGuess > targetNumber)
                    {
                        Console.WriteLine("Your guess is too high! Try Again.");
                    }
                    else if(usersGuess < targetNumber)
                    {
                        Console.WriteLine("Your guess is too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("You won! You guessed the correct number!");

                    }

                } //end if loop
                
                //Determines the condition of when the loop will end
            } while (usersGuess != targetNumber); //end do-while loop
        } //end main method
} //end program class
