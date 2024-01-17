public class Resume
{
    public string _name; 
    public List<Job> _jobss = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        foreach (Job job in _jobss)
        {
            job.Display();
        }
        
    }
}