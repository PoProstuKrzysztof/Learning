List<IProject> projects = new List<IProject>();

Project project1 = new Project()
{
    Name = "project1",
    End = new DateTime(2023, 10, 23),
    Start = new DateTime(2023, 10, 20)
};

Project project2 = new Project()
{
    Name = "project2",
    End = new DateTime(2023, 9, 27),
    Start = new DateTime(2023, 9, 26)
};

Project project3 = new Project()
{
    Name = "project3",
    End = new DateTime(2023, 9, 25),
    Start = new DateTime(2023, 9, 10)
};

projects.Add(project1);
projects.Add(project3);

Console.WriteLine(IsProjectPossible(projects, project2));

bool IsProjectPossible(List<IProject> existing, IProject project)
{
    foreach (var p in existing)
    {
        if (p.Start < project.End && p.End > project.Start)
        {
            return false;
        }
        else
        {
            continue;
        }
    }

    return true;
}

public interface IProject
{
    string Name { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}

public class Project : IProject
{
    public Project()
    {
    }

    public string Name { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}