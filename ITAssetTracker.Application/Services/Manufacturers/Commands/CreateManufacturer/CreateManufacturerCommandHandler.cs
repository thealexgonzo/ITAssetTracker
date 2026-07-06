using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Manufacturers.Commands.CreateManufacturer;

public class CreateManufacturerCommandHandler : IRequestHandler<CreateManufacturerCommand, int>
{
    private readonly IManufacturerRepository manufacturerRepository;
    private readonly IMapper mapper;

    public CreateManufacturerCommandHandler(IManufacturerRepository manufacturerRepository, IMapper mapper)
    {
        this.manufacturerRepository = manufacturerRepository;
        this.mapper = mapper;
    }
    public async Task<int> Handle(CreateManufacturerCommand request, CancellationToken cancellationToken)
    {
        // Map
        var manufacturer = mapper.Map<Manufacturer>(request);

        // Validate
        var validator = new CreateManufacturerCommandValidator();
        ValidationResult validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        // Act
        manufacturer = await manufacturerRepository.AddAsync(manufacturer);

        // Return 
        return manufacturer.Id;
    }
}
