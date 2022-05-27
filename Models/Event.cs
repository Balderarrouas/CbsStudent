using System.ComponentModel.DataAnnotations;


namespace CbsStudent.Models
{

public class Event{




[Key]
public int EventId { get; set; }
public string EventName { get; set; }
public string AboutEvent { get; set; }
public string Location { get; set; }


public int ProfileId { get; set; }
public Profile Profile { get; set; }

}
}