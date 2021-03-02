namespace JobBoard.Models
{
  public class Contact
  {
    private string _name;
    private string _email;
    private int _phoneNumber;

    public Contact(string name, string email, int phoneNumber)
    {
      _name = name;
      _email = email;
      _phoneNumber = phoneNumber;
    }

    public string GetName()
    {
      return _name;
    }

    public string GetEmail()
    {
      return _email;
    }
    public int GetPhoneNumber()
    {
      return _phoneNumber;
    }
  }
}