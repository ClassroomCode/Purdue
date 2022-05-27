using OopDemo;

var people = new List<Person>();

var p1 = new Person();
p1.FirstName = "Bill";
p1.LastName = "Gates";
people.Add(p1);

var p2 = new Person();
p2.FirstName = "Steve";
p2.LastName = "Jobs";
people.Add(p2);

foreach (var p in people) {
    Console.WriteLine(p.FullName());
}

