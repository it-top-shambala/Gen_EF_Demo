using Gen_EF_Demo.EF;

var db = new Db();
var worker = new Worker()
{
    Name = "A",
    Birth = DateTime.Now,
    Position = "12",
    IsActive = true
};

var manager = new Manager()
{
    Name = "B",
    Birth = DateTime.Now,
    Department = "21",
    Workers = new List<Worker>() {worker}
};

var person = new Person()
{
    Name = "DD",
    Birth = DateTime.Now
};

db.TableWorkers.Add(worker);
db.TableManagers.Add(manager);
//db.TablePersons.Add(person);
db.SaveChanges();