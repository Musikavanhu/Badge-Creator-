namespace CatWorx.BadgeMaker
{
  class Employee
  {
  public string FirstName;
  public string LastName;
  public int Id;
  public string PhotoUrl;
  public Employee(string FirstName, string LastName, int id,string photoUrl){
      FirstName = FirstName;
      LastName = LastName;
      Id = id;
      PhotoUrl = photoUrl;
  }
  public string GetName(){
      return FirstName + "" + LastName;
  }
  public int GetId(){
      return Id;
  }
  public string GetPhotoUrl(){
      return PhotoUrl;
  }
  }
}