namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _vacation;
    private string _souvenir;

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
  }
}
