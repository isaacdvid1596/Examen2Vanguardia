﻿using System.Collections.Generic;
using Hotel.Rates.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Rates.Infrastructure.Configurations
{
    public class RatePlanRoomConfiguration : IEntityTypeConfiguration<RatePlanRoom>
    {
        public void Configure(EntityTypeBuilder<RatePlanRoom> builder)
        {
            builder.HasKey(rpr => new
            {
                rpr.RatePlanId,
                rpr.RoomId
            });

            builder.HasOne(rpr => rpr.Room)
                .WithMany(r => r.RatePlanRooms)
                .HasForeignKey(rpr => rpr.RoomId);

            builder.HasOne(rpr => rpr.RatePlan)
               .WithMany(r => r.RatePlanRooms)
               .HasForeignKey(rpr => rpr.RatePlanId);

            builder.HasData(new List<RatePlanRoom>
            {
                new RatePlanRoom
                {
                    RatePlanId = -1,
                    RoomId = -1
                },
                new RatePlanRoom
                {
                    RatePlanId = -1,
                    RoomId = -2
                },
                new RatePlanRoom
                {
                    RatePlanId = -2,
                    RoomId = -1
                },
                new RatePlanRoom
                {
                    RatePlanId = -3,
                    RoomId = -2
                },
                new RatePlanRoom
                {
                    RatePlanId = -4,
                    RoomId = -1
                },
                new RatePlanRoom
                {
                    RatePlanId = -4,
                    RoomId = -2
                }
            });
        }
    }
}
