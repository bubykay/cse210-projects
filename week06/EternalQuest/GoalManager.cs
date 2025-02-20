using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
  private int _menuOption;
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
  }

  public void Start()
  {
    while (true)
    {
      Console.WriteLine($"\nYou have {_score} points.");

      Console.WriteLine(@"Menu Options:
    1. Create new goal
    2. List goals
    3. Save goals
    4. Load goals
    5. Record events
    6. Quit");

      Console.Write("Select a choice from the menu: ");

      if (!int.TryParse(Console.ReadLine(), out _menuOption))
      {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
      }

      if (_menuOption == 6) // Exit condition
      {
        break;
      }

      switch (_menuOption)
      {
        case 1:
          CreateGoal();
          break;
        case 2:
          ListGoalDescriptions();
          break;
        case 3:
          SaveGoals();
          break;
        case 4:
          LoadGoals();
          break;
        case 5:
          RecordEvent();
          break;
        default:
          Console.WriteLine("Invalid option. Please select a valid menu option.");
          break;
      }
    }
  }

  private void CreateGoal()
  {
    Console.WriteLine("\nThe types of goals are:");
    Console.WriteLine("    1. Simple goal");
    Console.WriteLine("    2. Eternal goal");
    Console.WriteLine("    3. Checklist goal");
    Console.Write("Which type of goal? ");

    if (!int.TryParse(Console.ReadLine(), out int goalType))
    {
      Console.WriteLine("Invalid input. Please enter a number.");
      return;
    }

    Console.Write("What is the name of your goal? ");
    string goalName = Console.ReadLine();

    Console.Write("What is a short description of it? ");
    string goalDescription = Console.ReadLine();

    Console.Write("What amount of points do you associate with this goal? ");
    if (!int.TryParse(Console.ReadLine(), out int goalPoints))
    {
      Console.WriteLine("Invalid input. Please enter a valid number.");
      return;
    }

    switch (goalType)
    {
      case 1:
        _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        break;
      case 2:
        _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        break;
      case 3:
        Console.Write("How many times does this goal need to be completed? ");
        if (!int.TryParse(Console.ReadLine(), out int targetCount))
        {
          Console.WriteLine("Invalid input. Please enter a valid number.");
          return;
        }
        Console.Write("What is the bonus for completing this goal? ");
        if (!int.TryParse(Console.ReadLine(), out int bonusPoints))
        {
          Console.WriteLine("Invalid input. Please enter a valid number.");
          return;
        }

        _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, targetCount, bonusPoints));
        break;
      default:
        Console.WriteLine("Invalid goal type.");
        break;
    }
  }

  private void SaveGoals()
  {
    if (_goals.Count == 0)
    {
      Console.WriteLine("No goals to save.");
      return;
    }

    Console.Write("Enter the file name to save goals: ");
    string fileName = Console.ReadLine();

    try
    {
      using (StreamWriter writer = new StreamWriter(fileName))
      {
        writer.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
          writer.WriteLine(goal.GetStringRepresentation());
        }
      }
      Console.WriteLine("Goals saved successfully.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error saving file: {ex.Message}");
    }
  }

  public void RecordEvent()
  {
    if (_goals.Count == 0)
    {
      Console.WriteLine("No goals have been created.");
      return;
    }

    Console.WriteLine("The goals are:");
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
    }

    Console.Write("Which goal did you accomplish? ");
    if (!int.TryParse(Console.ReadLine(), out int goalAccomplished) || goalAccomplished < 1 || goalAccomplished > _goals.Count)
    {
      Console.WriteLine("Invalid input. Please enter a valid goal number.");
      return;
    }

    _goals[goalAccomplished - 1].RecordEvent();

    int pointsEarned = _goals[goalAccomplished - 1].GetGoalPoint;
    _score += pointsEarned;

    Console.WriteLine($"\nCongratulations! You've earned {pointsEarned} points.");
    Console.WriteLine($"You now have {_score} points.\n");

  }
  public void ListGoalDescriptions()
  {
    if (_goals.Count == 0)
    {
      Console.WriteLine("No goals have been created.");
      return;
    }

    Console.WriteLine("\nYour Goals:");
    foreach (Goal goal in _goals)
    {
      Console.WriteLine(goal.GetDetailsString());
    }
  }

  public void TestList()
  {
    if (_goals.Count == 0)
    {
      Console.WriteLine("No goals have been created.");
      return;
    }

    Console.WriteLine("\nYour Goals:");
    foreach (Goal goal in _goals)
    {
      Console.WriteLine(goal.GetStringRepresentation());
    }
  }

  private void LoadGoals()
  {
    Console.Write("Enter the file name to load goals: ");
    string fileName = Console.ReadLine();

    if (!File.Exists(fileName))
    {
      Console.WriteLine("File not found.");
      return;
    }

    try
    {
      using (StreamReader reader = new StreamReader(fileName))
      {
        _score = int.Parse(reader.ReadLine());
        _goals.Clear();

        string line;
        while ((line = reader.ReadLine()) != null)
        {
          string[] parts = line.Split('|');
          string goalType = parts[0];
          string goalName = parts[1];
          string goalDescription = parts[2];
          int goalPoints = int.Parse(parts[3]);

          switch (goalType)
          {
            case "SimpleGoal":
              _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
              break;
            case "EternalGoal":
              _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
              break;
            case "ChecklistGoal":
              int bonusPoints = int.Parse(parts[4]);
              int targetCount = int.Parse(parts[5]);
              _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, targetCount, bonusPoints));
              break;
            default:
              Console.WriteLine("Unknown goal type in file.");
              break;
          }
        }
      }
      Console.WriteLine("Goals loaded successfully.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error loading file: {ex.Message}");
    }
  }
}
