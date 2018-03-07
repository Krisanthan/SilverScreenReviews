using AutoMapper;
using SilverScreenReviews.DTO;
using SilverScreenReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverScreenReviews.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<User, UserDTO>();
            Mapper.CreateMap<UserDTO, User>();
            Mapper.CreateMap<MembershipType, MembershipTypeDTO>();
        }
    }
}