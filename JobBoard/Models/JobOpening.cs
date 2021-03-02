using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; }
    public string Description { get; }
    private Contact _contactInfo;

    private static List<JobOpening> _jobList = new List<JobOpening> { };

    public JobOpening(string title, string description, Contact contactInfo)
    {
      Title = title;
      Description = description;
      _contactInfo = contactInfo;
      _jobList.Add(this);
    }

    public Contact GetJobPostingContact()
    {
      return _contactInfo;
    }
    
    public static List<JobOpening> GetAll()
    {
      return _jobList;
    }
  }
}