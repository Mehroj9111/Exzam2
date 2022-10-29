var ListOfPeople = new List<Person>();
System.Console.Write("How many person do you want to add :");
var n = Convert.ToInt32(System.Console.ReadLine());
for (int i = 1; i <= n ; i++)
{
    var p = new Person();
    System.Console.WriteLine($"Person {i}:");

    System.Console.Write("Name: ");
    p.Name = System.Console.ReadLine();
    System.Console.Write("Surname: ");
    p.Surname = System.Console.ReadLine();
    System.Console.Write("Age: ");
    p.Age = Convert.ToInt32(System.Console.ReadLine());
    ListOfPeople.Add(p);
}
foreach (var person in ListOfPeople)
{
 System.Console.WriteLine(person.GetInfo());   
}