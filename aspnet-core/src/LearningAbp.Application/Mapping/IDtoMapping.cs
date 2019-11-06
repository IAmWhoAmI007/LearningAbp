using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningAbp.Mappers
{
    internal interface IDtoMapping
    {
        void CreateMapping(IMapperConfigurationExpression mapperConfig);
    }
}
