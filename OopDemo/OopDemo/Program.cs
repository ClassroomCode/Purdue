using OopDemo;

var st = new SubThing();

var people = new List<Person>() {
    new Customer { FirstName = "Bill", LastName = "Gates" },
    new Employee { FirstName ="Steve", LastName = "Jobs" }
};

foreach (var p in people) {
    Console.WriteLine(p.FullName);
}
Console.WriteLine("-----------");

var payables = new List<IPayable>() {
    new Employee { FirstName ="Steve", LastName = "Jobs" },
    new Vendor { Name = "Acme, Inc." }
};

foreach (var payable in payables) {
    payable.PayMoney();
}

