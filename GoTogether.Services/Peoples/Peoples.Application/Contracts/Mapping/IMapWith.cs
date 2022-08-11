using AutoMapper;

namespace Peoples.Application.Contracts.Mapping;

public interface IMapWith<T>
{
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
}
