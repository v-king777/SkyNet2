using AutoMapper;
using SkyNet2.Models.Users;
using SkyNet2.ViewModels.Account;

namespace SkyNet2;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterViewModel, User>()
            .ForMember(user => user.BirthDate, expression =>
                expression.MapFrom(model =>
                    new DateTime((int) model.Year, (int) model.Month, (int) model.Date)))
            .ForMember(user => user.Email, expression =>
                expression.MapFrom(model => model.EmailReg))
            .ForMember(user => user.UserName, expression =>
                expression.MapFrom(model => model.Login));
        
        CreateMap<LoginViewModel, User>();
    }
}