using AutoMapper;
using FluentValidation.Results;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Application.Exceptions;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Manufacturers.Commands.UpdateManufacturer;

public class UpdateManufacturerCommandHandler : IRequestHandler<UpdateManufacturerCommand>
{
    private readonly IManufacturerRepository manufacturerRepository;
    private readonly IMapper mapper;

    public UpdateManufacturerCommandHandler(IManufacturerRepository manufacturerRepository, IMapper mapper)
    {
        this.manufacturerRepository = manufacturerRepository;
        this.mapper = mapper;
    }

    public async Task Handle(UpdateManufacturerCommand request, CancellationToken cancellationToken)
    {
        var manufacturerToUpdate = await manufacturerRepository.GetByIdAsync(request.Id);

        if (manufacturerToUpdate is null)
        {
            throw new NotFoundException("Manufacturer", request.Id);
        }

        var validator = new UpdateManufacturerCommandValidator();
        ValidationResult validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        mapper.Map(request, manufacturerToUpdate, typeof(UpdateManufacturerCommand), typeof(Manufacturer));
        await manufacturerRepository.UpdateAsync(manufacturerToUpdate); // TODO: Need to add validation, the asset cannot be null if you want to update it
    }
}
