using ManaWorksCandidate.Application.Dtos.Educations;
using ManaWorksCandidate.Domain.Entities;
using MediatorLib.Requests;

namespace ManaWorksCandidate.Application.Commands.EducationTypes;

public record CreateEducationTypeCommand(CreateEducationTypeDto EducationType) : IRequest<EducationType>;
