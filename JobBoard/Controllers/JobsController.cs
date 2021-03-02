using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;
using System;

namespace JobBoard.Controllers
{
  public class JobsController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      Console.WriteLine(JobOpening.GetAll().Count);
      List<JobOpening> allJobs = JobOpening.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/createjob")]
    public ActionResult CreateJobForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult PostNewJob(string title, string description, string name, string email, int phoneNumber)
    {
      Contact newContact = new Contact(name, email, phoneNumber);
      JobOpening newJob = new JobOpening(title, description, newContact);
      return RedirectToAction("Index");
    }
  }
}