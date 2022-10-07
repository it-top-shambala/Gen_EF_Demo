namespace Gen_EF_Demo.EF;

public class Manager : Person
{
    public string Department { get; set; }
    public List<Worker> Workers { get; set; }
}