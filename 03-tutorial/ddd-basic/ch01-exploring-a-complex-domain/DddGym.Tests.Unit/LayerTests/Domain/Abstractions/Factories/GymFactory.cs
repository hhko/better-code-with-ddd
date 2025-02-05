﻿using DddGym.Domain.Gyms;

namespace DddGym.Tests.Unit.LayerTests.Domain.Abstractions.Factories;

internal static class GymFactory
{
    public static Gym CreateGym(
        //int maxRooms = Constants.Subscriptions.MaxRoomsFreeTier,
        Guid? id = null)
    {
        return new Gym(
            //maxRooms,
            //subscriptionId: Constants.Subscriptions.Id,
            id: id ?? Constants.Gym.Id);
    }
}
