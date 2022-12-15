﻿using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.UsersQueries
{
    public class GetUsersPageQuery:IRequest<IEnumerable<User>>
    {
        public int Page { get; set; }
    }
}
