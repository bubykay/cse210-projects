using System.Security;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
  private int _menuOption;
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = [];
    _score = 0;
  }

  public void Start()
  {

    while (true)
    {
      if (_menuOption == 5)
      {
        break;
      }
      Console.WriteLine($"You have {_score} point");
      Console.Write(@"Menu Option
  1. Create new goal
  2. List goals
  3. Save goals
  4. Load goals
  5. Record events
  6. Quit
Select a choice from the menu ");
      _menuOption = int.Parse(Console.ReadLine());
      if (_menuOption == 1)
      {
        Console.Write(@"The types of goals are;
    1. Simple goal
    2. Eternal goal
    3. Checklist goal
  Which type of goal ");
        int goalType = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What amount of point you associated with this goal? ");
        int goalPoint = int.Parse(Console.ReadLine());
        _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoint));
      }
      else if (_menuOption == 2)
      {
        ListGoalDescription();
      }
      else if (_menuOption == 3)
      {
        Console.Write("What is the file name of the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
          foreach (Goal goal in _goals)
          {
            writer.WriteLine(goal.GetStringRepresentation());
          }
        }
      }
    }




  }

  public void ListGoalNames()
  {
    foreach (Goal goal in _goals)
    {
      Console.WriteLine(goal.GetGoalName());
    }
  }

  public void ListGoalDescription()
  {
    foreach (Goal goal in _goals)
    {
      Console.WriteLine(goal.GetStringRepresentation());
    }
  }


}