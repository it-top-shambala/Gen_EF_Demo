using Gen_EF_Demo.EF;

var db = new Db();

var res = db.TableWorkers.First(w => w.IsActive == false);
Console.WriteLine(res.Name);

var query = from worker in db.TableWorkers 
    where worker.IsActive == false
    select new {Name = worker.Name, Position = worker.Position};

var r = query.ToList();

foreach (var w in query)
{
    Console.WriteLine($"{w.Name}: {w.Position}");
}

var query_2 = from worker in db.TableWorkers
    where worker.IsActive == true && worker.Manager.Name == "B"
    select worker;
    
foreach (var w in query_2)
{
    Console.WriteLine($"{w.Name}: {w.Manager.Name}");
} 