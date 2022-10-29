public class Person
{
  public int Age { get; set; }
  public string Name { get; set; }
  public string Surname { get; set; }
public string GetInfo()
{
return $"May name is {Name} {Surname} age : {Age}";
}
}