﻿using System.Collections.Generic;
using Alfred.Dal.Implementation.Fake.EntityDtos;

namespace Alfred.Dal.Implementation.Fake.Database
{
    public class FakeCommunitiesDb
    {
       
        public static List<CommunityDto> GetCommunities()
        {
            return new List<CommunityDto>
            {
                new CommunityDto
                {
                    Id = 1,
                    Email = "DotNetCommunity@superheros.com",
                    Name = "DotNet Community"
                },
                new CommunityDto
                {
                    Id = 2,
                    Email = "JavaCommunity@superheros.com",
                    Name = "Java Community"
                },
                new CommunityDto
                {
                    Id = 3,
                    Email = "AgileCommunity@superheros.com",
                    Name = "Agile Community"
                }
            };
        }
    }
}
