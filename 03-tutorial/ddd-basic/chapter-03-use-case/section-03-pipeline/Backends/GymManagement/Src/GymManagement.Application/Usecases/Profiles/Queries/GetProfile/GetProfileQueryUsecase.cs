﻿using DddGym.Framework.BaseTypes.Application.Cqrs;
using ErrorOr;
using GymManagement.Application.Abstractions.Repositories;
using GymManagement.Application.Usecases.Profiles;
using GymManagement.Domain.AggregateRoots.Users;

namespace GymManagement.Application.Usecases.Users.Queries.ListProfiles;

internal sealed class GetProfileQueryUsecase
    : IQueryUsecase<GetProfileQuery, GetProfileResponse>
{
    private readonly IUsersRepository _usersRepository;

    public GetProfileQueryUsecase(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public async Task<IErrorOr<GetProfileResponse>> Handle(GetProfileQuery query, CancellationToken cancellationToken)
    {
        User? user = await _usersRepository.GetByIdAsync(query.UserId);
        if (user is null)
        {
            return Error
                .NotFound(description: "User not found")
                .ToErrorOr<GetProfileResponse>();
        }

        return user
            .ToResponse()
            .ToErrorOr();
    }
}