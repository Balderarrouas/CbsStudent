using System.ComponentModel.DataAnnotations;


namespace CbsStudent.Models
{

public class Profile
{
    [Key]
public int ProfileId { get; set; }

public string Name { get; set; }
public string About { get; set; }
public string MyProperty { get; set; }

public string Email { get; set; }


public List<Event> Events { get; set; }





}





}