using System.Collections.Generic;
using ComplaintsApp.API.Data;
using ComplaintsApp.API.Dtos;
using ComplaintsApp.API.Models;

namespace ComplaintsApp.API.Services
{
    public class ComplaintService : IComplaintService
    {
        private readonly IComplaintRepoistory _repo;
        public ComplaintService(IComplaintRepoistory repo)
        {
            _repo = repo;
        }
        public List<Complaint> FetchComplaint()
        {
            var complaintList = _repo.FetchComplaint();
            
            // We can do other domain/business related operations here.

            return complaintList;
        }

        public Complaint GetComplaintById(string id)
        {
            var complaint = _repo.FetchComplaint(id);
            
            // We can do other domain/business related operations here.

            return complaint;
        }

        public Complaint LogComplaint(LogComplaintDto complaintDto)
        {
            // Below we can use AutoMapper for mapping objects
            var complain = new Complaint  {
                Subject = complaintDto.Subject,
                Detail = complaintDto.Detail,
                CreatedBy =  complaintDto.CreatedBy
            };

            return _repo.LogComplaint(complain);
        }
    }
}