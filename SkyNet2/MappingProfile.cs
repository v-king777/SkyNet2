using AutoMapper;
using SkyNet2.Models.Users;
using SkyNet2.ViewModels.Account;

namespace SkyNet2;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterViewModel, User>()
            .ForMember(u => u.BirthDate, opt =>
                opt.MapFrom(rvm =>
                    new DateTime((int) rvm.Year, (int) rvm.Month, (int) rvm.Date)))
            .ForMember(u => u.Email, opt =>
                opt.MapFrom(rvm => rvm.EmailReg))
            .ForMember(u => u.UserName, opt =>
                opt.MapFrom(rvm => rvm.Login));
        
        CreateMap<LoginViewModel, User>();
    }
}