using AutoMapper;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Profiles
{
    public  class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest,LeaveRequestDTO>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDTO>().ReverseMap();
            CreateMap<LeaveType,LeaveTypeDTO>().ReverseMap();
            CreateMap<LeaveAllocation,LeaveAllocationDTO>().ReverseMap();
        }
    }
}
