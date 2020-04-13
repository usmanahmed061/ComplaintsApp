using System;
using System.Collections.Generic;
using ComplaintsApp.API.Dtos;
using ComplaintsApp.API.Models;

namespace ComplaintsApp.API.Data
{
    public class ComplaintRepoistory : IComplaintRepoistory
    {
        public List<Complaint> FetchComplaint()
        {
            var complaint = new Complaint
            {
                Id = Guid.NewGuid(),
                Subject = "Subject",
                Detail = "Detail about complaint",
                IsResolved = false,
            };

            var complaintList = new List<Complaint> {
                complaint,
                complaint
            };

            return complaintList;
        }

        public Complaint FetchComplaint(string Id)
        {
            var complaint = new Complaint
            {
                Id = Guid.NewGuid(),
                Subject = "Subject",
                Detail = "Detail about complaint",
                IsResolved = false,
            };

            return complaint;
        }

        public Complaint LogComplaint(Complaint complaintDto)
        {

            // If the save is successfull 
            var complaint = new Complaint
            {
                Id = Guid.NewGuid()
            };
            
            // This if is to check if our complaint is successfully saved 
            if(complaint != null)
                return complaint;

            throw new Exception("Creating the log failed on save.");

        }
    }
}