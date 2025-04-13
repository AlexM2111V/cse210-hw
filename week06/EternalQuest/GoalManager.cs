using System;
using System.Net;
using System.Threading.Channels;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = [];
    }

    public void Start()
    {
        string response = "";

        while ( response != "6" ){

            DisplayPlayerInfo();

            Console.WriteLine($"\nMenu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the menu: ");
            response =  Console.ReadLine();

            if ( response == "1" )
            {
                CreateGoal();            
            }
            else if ( response == "2")
            {
                ListGoalDetails();
            }
            else if ( response == "3")
            {
                SaveGoals();
            }
            else if ( response == "4")
            {
                LoadGoals();
            }
            else if ( response == "5")
            {
                RecordEvent();
            }
            else if ( response == "6")
            {
                return;
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }
    public void ListGoalNames()
    {
        if ( _goals.Count() == 0 )
        {
            Console.WriteLine("\nThere is no goals yet. Please create a goal or load a file.");
        }
        else
        {
            Console.WriteLine("\nThe goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
            }
        }
    }
    public void ListGoalDetails()
    {    
        if ( _goals.Count() == 0 )
        {
            Console.WriteLine("\nThere is no goals yet. Please create a goal.");
        }
        else
        {
            Console.WriteLine();    
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }        
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        _goals[goalNumber].RecordEvent();
        int goalPoints = _goals[goalNumber].GetPoints();

        if (_goals[goalNumber] is NegativeGoal negativeGoal)
        {
            Console.WriteLine($"\nOh no! You have lost {goalPoints} points!");
            int oldScore = _score;
            _score -= goalPoints;

            for (int i = oldScore; i >= _score; i--)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"\rYou now have {i} points!");
                Thread.Sleep(100);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        else
        {
            if (_goals[goalNumber] is ChecklistGoal checklistGoal && _goals[goalNumber].IsComplete())
            {
                goalPoints += checklistGoal.GetBonus();
            }

            Console.WriteLine($"\nCongratulations! You have earned {goalPoints} points!");
            int oldScore = _score;
            _score += goalPoints;

            for (int i = oldScore; i <= _score; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\rYou now have {i} points! 🎈🎊🎉");
                Thread.Sleep(100);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
    public void CreateGoal()
    {
        Goal newGoal = null;
        string goalType = "";

        while (goalType != "1" && goalType != "2" && goalType != "3" && goalType != "4")
        {
            Console.WriteLine("\nThe types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n4. Negative Goal");
            Console.Write("Which type of goal would you like to create? ");
            goalType = Console.ReadLine();
        }
        
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
            if ( goalType == "1")
            {
                newGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            }
            else if ( goalType =="2")
            {
                newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            }
            else if ( goalType == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
            }
            else if ( goalType =="4")
            {
                newGoal = new NegativeGoal(goalName, goalDescription, goalPoints);
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
            }
            _goals.Add(newGoal);        

    }

    public void SaveGoals()
    {
        Console.Write("\nWhat file do you want to save your goals to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("\nWhat is the name of the file? ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('~');

            if (parts.Length == 5)
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                bool completed = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, desc, points);
                if ( completed )
                {
                    goal.RecordEvent();
                }                
                _goals.Add(goal);
            }
            else if (parts.Length == 4)
            {
                Goal goal = null;
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);

                if ( parts[0] == "EternalGoal" )
                {
                    goal = new EternalGoal(name, desc, points);
                }
                else if ( parts[0] == "NegativeGoal" )
                {
                    goal = new NegativeGoal(name, desc, points);
                }
                _goals.Add(goal);
            }
            else if (parts.Length == 8)
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                bool completed = bool.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                int amountCompleted = int.Parse(parts[7]);

                ChecklistGoal goal = new ChecklistGoal(name, desc, points, target, bonus);

                goal.SetAmountCompleted(amountCompleted);
                _goals.Add(goal);
            }
        }
    }
}