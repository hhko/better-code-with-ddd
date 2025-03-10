﻿using DddGym.Framework.BaseTypes.Application.Cqrs;

namespace GymManagement.Application.Usecases.Gyms.Commands.AddTrainer;

public sealed record AddTrainerCommand(
    Guid SubscriptionId,
    Guid GymId,
    Guid TrainerId)
    : ICommand;