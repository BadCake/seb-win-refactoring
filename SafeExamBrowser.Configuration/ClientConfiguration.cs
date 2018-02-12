﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using SafeExamBrowser.Contracts.Configuration;
using SafeExamBrowser.Contracts.Configuration.Settings;

namespace SafeExamBrowser.Configuration
{
	[Serializable]
	public class ClientConfiguration : IClientConfiguration
	{
		public ISessionData SessionData { get; set; }
		public ISettings Settings { get; set; }
		public IRuntimeInfo RuntimeInfo { get; set; }
	}
}