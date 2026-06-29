using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Departments.Commands.DeleteDepartment
{
    public class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand>
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public DeleteDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }

        public async Task Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var departmentToDelete = await departmentRepository.GetByIdAsync(request.Id);

            if (departmentToDelete is null)
            {
                throw new NotFoundException("Asset", request.Id);
            }

            await departmentRepository.DeleteAsync(departmentToDelete);
        }
    }
}
