﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nest.Resolvers.Converters;
using Newtonsoft.Json;

namespace Nest
{
	[JsonConverter(typeof(ReadAsTypeConverter<MatchAllFilter>))]
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface IMatchAllFilter : IFilterBase
	{
	}

	public class MatchAllFilter : FilterBase, IMatchAllFilter
	{
		bool IFilterBase.IsConditionless
		{
			get
			{
				return false;
			}

		}
	}
}
