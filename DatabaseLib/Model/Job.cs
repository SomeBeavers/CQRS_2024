﻿namespace DatabaseLib.Model;

public class Job
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Title  { get; set; } = null!;
    public int    Salary { get; set; }

    public virtual ICollection<Animal>?      Animals      { get; set; }
    public virtual ICollection<JobDrawback>? JobDrawbacks { get; set; }

    public override string ToString()
    {
        return $"Job : Id = {Id} Title = {Title}";
    }
}
