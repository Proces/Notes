using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Notes.Application.Mappings
{
    public interface IMapWith<T>
    {
        public void Mapping (Profile profile)=> profile.CreateMap(typeof(T), GetType());
    }
}
