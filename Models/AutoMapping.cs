using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace webcore.Models
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
