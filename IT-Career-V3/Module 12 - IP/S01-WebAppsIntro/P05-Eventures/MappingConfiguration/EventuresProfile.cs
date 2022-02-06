using AutoMapper;
using P05_Eventures.Data.Models;
using P05_Eventures.ViewModels.Events;

namespace P05_Eventures.MappingConfiguration
{
    public class EventuresProfile : Profile
    {
        public EventuresProfile()
        {
            this.CreateMap<Event, CreateEventViewModel>().ReverseMap();
            this.CreateMap<Event, IndexEventViewModel>();
            this.CreateMap<Event, IndexUserEventViewModel>();
            this.CreateMap<Event, EditEventViewModel>().ReverseMap();
        }
    }
}
