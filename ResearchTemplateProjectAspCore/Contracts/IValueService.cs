using ResearchTemplateProjectAspCore.Contracts.Dtos;
using System.Collections.Generic;

namespace ResearchTemplateProjectAspCore.Contracts
{
    public interface IValueService
    {
        ValueDto Get(int id);
        IEnumerable<ValueDto> GetAll();
        ValueDto Add(ValueDto dto);
    }
}
