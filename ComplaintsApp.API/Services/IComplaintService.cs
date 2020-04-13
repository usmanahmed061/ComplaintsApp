using System.Collections.Generic;
using ComplaintsApp.API.Dtos;
using ComplaintsApp.API.Models;

namespace ComplaintsApp.API.Services
{
    public interface IComplaintService
    {
         List<Complaint> FetchComplaint();
         Complaint GetComplaintById(string id);
         Complaint LogComplaint(LogComplaintDto complaintDto);
    }
}