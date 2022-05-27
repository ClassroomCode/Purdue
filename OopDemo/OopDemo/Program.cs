using OopDemo;

var people = new List<Person>() {
    new Person { FirstName = "Bill", LastName = "Gates" },
    new Employee { FirstName ="Steve", LastName = "Jobs" }
};

foreach (var p in people) {
    Console.WriteLine(p.FullName);
}

