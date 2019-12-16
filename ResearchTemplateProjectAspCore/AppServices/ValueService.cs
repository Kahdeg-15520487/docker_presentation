using ResearchTemplateProjectAspCore.Contracts;
using ResearchTemplateProjectAspCore.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchTemplateProjectAspCore.AppServices
{
    public class ValueService : IValueService
    {
        public static List<string> Values = new List<string>()
        {
            "value1","value2"
        };

        public ValueDto Add(ValueDto dto)
        {
            Values.Add(dto.Value);
            return new ValueDto { Value = dto.Value };
        }

        public ValueDto Get(int id)
        {
            if (id < 0 || id >= Values.Count)
            {
                return null;
            }
            return new ValueDto { Value = Values[id] };
        }

        public IEnumerable<ValueDto> GetAll()
        {
            return Values.Select(v => new ValueDto { Value = v });
        }
    }
}
