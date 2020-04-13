using System.Collections.Generic;
using ComplaintsApp.API.Dtos;
using ComplaintsApp.API.Models;

namespace ComplaintsApp.API.Data
{
    public interface IComplaintRepoistory
    {
         List<Complaint> FetchComplaint();
         Complaint FetchComplaint(string Id);
         Complaint LogComplaint(Complaint complaintDto);
    }
}