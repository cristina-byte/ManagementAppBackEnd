﻿using AutoMapper;
using Domain.Entities;
using Domain.TeamEntities;
using ManagementTool.API.Dto.UserDtos;

namespace ManagementTool.API.Dto.TeamDtos
{
    public class TeamDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public DateTime CreatedAt { get; set; }
    


    }
}
