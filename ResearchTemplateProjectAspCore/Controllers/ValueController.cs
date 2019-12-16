using Microsoft.AspNetCore.Mvc;
using ResearchTemplateProjectAspCore.Contracts;
using ResearchTemplateProjectAspCore.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchTemplateProjectAspCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        private readonly IValueService valueService;

        public ValueController(IValueService valueService)
        {
            this.valueService = valueService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ValueDto result = valueService.Get(id);
            return result is null ? NotFound() as IActionResult : Ok(result);
        }

        [HttpGet]
        public IEnumerable<ValueDto> GetNull()
        {
            return valueService.GetAll();
        }
    }
}
