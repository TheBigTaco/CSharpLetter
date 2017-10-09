namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _vacation;
    private string _souvenir;
    private string _sender;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetVacation()
    {
      return _vacation;
    }

    public void SetVacation(string newVacation)
    {
      _vacation = newVacation;
    }

    public string GetSouvenir()
    {
      return _souvenir;
    }

    public void SetSouvenir(string newSouvenir)
    {
      _souvenir = newSouvenir;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }
  }
  public class Madlibs
  {
    private string _name;
    private string _animal;
    private string _food;
    private string _adjective;
    private string _verb;
    private string _noun;

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetAnimal()
    {
      return _animal;
    }

    public void SetAnimal(string newAnimal)
    {
      _animal = newAnimal;
    }
    public string GetFood()
    {
      return _food;
    }

    public void SetFood(string newFood)
    {
      _food = newFood;
    }
    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }
    public string GetVerb()
    {
      return _verb;
    }

    public void SetVerb(string newVerb)
    {
      _verb = newVerb;
    }
    public string GetNoun()
    {
      return _noun;
    }

    public void SetNoun(string newNoun)
    {
      _noun = newNoun;
    }
  }
}
