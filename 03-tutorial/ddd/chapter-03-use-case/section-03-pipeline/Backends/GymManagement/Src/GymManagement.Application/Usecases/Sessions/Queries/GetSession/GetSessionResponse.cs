﻿using DddGym.Framework.BaseTypes.Application.Cqrs;
using GymManagement.Domain.AggregateRoots.Sessions;

namespace GymManagement.Application.Usecases.Sessions.Queries.GetSession;

public sealed record GetSessionResponse(
    Session Session) : IResponse;