﻿using Domain.Entities.OportunityEntities;

namespace Domain.Entities
{
    public class OportunityApplicant
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Oportunity Oportunity { get; set; }
        public int OportunityId { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }

    }
}
