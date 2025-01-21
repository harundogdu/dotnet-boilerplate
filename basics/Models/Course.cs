using System;

namespace basics.Models;

public class Course
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Image { get; set; }
    public string? Description { get; set; }
    public string[]? Tags { get; set; }
    public bool IsActive { get; set; }
    public bool IsHome { get; set; }
    public bool IsNew { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public int RegisteredUsersCount { get; set; }
}
