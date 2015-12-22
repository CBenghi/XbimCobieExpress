﻿using System.Collections.Generic;
using Xbim.COBieLiteUK;
using Xbim.Ifc2x3.Kernel;
using Xbim.IO;

namespace XbimExchanger.IfcToCOBieLiteUK
{
    class MappingIfcProjectToProject : XbimMappings<XbimModel, List<Facility>, string, IfcProject, Project>
    {
        protected override Project Mapping(IfcProject source, Project target)
        {
            var helper = ((IfcToCOBieLiteUkExchanger)Exchanger).Helper;
            target.ExternalEntity = helper.ExternalEntityName(source);
            target.ExternalId = helper.ExternalEntityIdentity(source);
            target.AltExternalId = source.GlobalId;
            target.Name = source.Name;
            target.Description = source.Description;
            return target;
        }
    }
}
