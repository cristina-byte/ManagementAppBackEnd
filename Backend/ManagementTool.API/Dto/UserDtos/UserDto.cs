﻿namespace ManagementTool.API.Dto.UserDtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set;}
        public Boolean IsOnline { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
