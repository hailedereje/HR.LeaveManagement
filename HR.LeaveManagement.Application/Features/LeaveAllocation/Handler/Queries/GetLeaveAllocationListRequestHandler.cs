using AutoMapper;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.Features.LeaveAllocation.Request.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Handler.Queries
{
    public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDTO>>
    {
        private readonly ILeaveAllocationRepository _leavingsRepository;
        private readonly IMapper _mapper;
        public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository leaveAllocationRepository ,IMapper mapper)
        {
            _mapper = mapper;
            _leavingsRepository = leaveAllocationRepository;

        }
        public async Task<List<LeaveAllocationDTO>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocations =await _leavingsRepository.GetLeaveAllocationsDetails();
            return _mapper.Map<List<LeaveAllocationDTO>>(leaveAllocations);
        }
    }
}
