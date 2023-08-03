using AutoMapper;
using CrudAPI.DTOs;
using CrudAPI.Models;

namespace CrudAPI.Map
{
    public class MapperClass : Profile
    {
        public MapperClass()
        {
                CreateMap<BankAccountUpdateDTO, BankAccount>().ReverseMap() ;
                CreateMap<BankAccountDTO, BankAccount>().ReverseMap() ;
        }
    }
}
