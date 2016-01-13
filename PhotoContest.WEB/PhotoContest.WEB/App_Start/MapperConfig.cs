namespace PhotoContest.WEB.App_Start
{
    using AutoMapper;
    using Models.ViewModels;
    using PhotoContest.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class MapperConfig
    {
        public static void ConfigureMappings()
        {
            Mapper.CreateMap<User, UserQuickViewModel>();
        }
    }
}