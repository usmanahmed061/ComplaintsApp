using System;
using ComplaintsApp.API.Dtos;
using ComplaintsApp.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComplaintsApp.API.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ComplaintController : ControllerBase
    {
        private readonly IComplaintService _service;
        public ComplaintController(IComplaintService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetComplaintLog()
        {
            var complaintList = _service.FetchComplaint();
            
            if(complaintList == null)
                return BadRequest();

            if(complaintList.Count == 0)
                return NoContent();

            return Ok(complaintList);
        }

        [HttpGet("{id}", Name = "GetComplaintById")]
        public IActionResult GetComplaintById(string Id)
        {
            var complaint = _service.GetComplaintById(Id);
            
            if(complaint == null)
                return NoContent();

            return Ok(complaint);
        }

        [HttpPost]
        public IActionResult LogComplaint(LogComplaintDto complaintDto)
        {
            var complaint = _service.LogComplaint(complaintDto);

            if(complaint == null)  
                return BadRequest("Something went wrong");      

            return CreatedAtRoute("GetComplaintById", new { Id = complaint.Id  }, true);
        }

    }
}