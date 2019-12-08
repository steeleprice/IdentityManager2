﻿using System.Linq;
using IdentityManager2.Api.Models;
using IdentityManager2.Core;

namespace IdentityManager2.Mappers
{
    public static class RoleResultMappers
    {
        public static void MapToResultData(QueryResult<RoleSummary> result, RoleQueryResultResourceData data)
        {
            data.Count = result.Count;
            data.Filter = result.Filter;
            data.Start = result.Start;
            data.Total = result.Total;

            data.Items = result.Items
                .Select(x => new RoleResultResource {Data = x, Links = x})
                .ToList();
        }
    }
}