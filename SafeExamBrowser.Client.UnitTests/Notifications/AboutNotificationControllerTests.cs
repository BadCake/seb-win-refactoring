﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SafeExamBrowser.Client.Notifications;
using SafeExamBrowser.Contracts.Configuration;
using SafeExamBrowser.Contracts.I18n;
using SafeExamBrowser.Contracts.UserInterface;

namespace SafeExamBrowser.Client.UnitTests.Notifications
{
	[TestClass]
	public class AboutNotificationControllerTests
	{
		private Mock<IRuntimeInfo> runtimeInfoMock;
		private Mock<IUserInterfaceFactory> uiFactoryMock;

		[TestInitialize]
		public void Initialize()
		{
			runtimeInfoMock = new Mock<IRuntimeInfo>();
			uiFactoryMock = new Mock<IUserInterfaceFactory>();
		}

		[TestMethod]
		public void MustCloseWindowWhenTerminating()
		{
			var button = new NotificationButtonMock();
			var window = new Mock<IWindow>();
			var sut = new AboutNotificationController(runtimeInfoMock.Object, uiFactoryMock.Object);

			uiFactoryMock.Setup(u => u.CreateAboutWindow(It.IsAny<IRuntimeInfo>())).Returns(window.Object);
			sut.RegisterNotification(button);
			button.Click();
			sut.Terminate();

			window.Verify(w => w.Close());
		}

		[TestMethod]
		public void MustOpenOnlyOneWindow()
		{
			var button = new NotificationButtonMock();
			var window = new Mock<IWindow>();
			var sut = new AboutNotificationController(runtimeInfoMock.Object, uiFactoryMock.Object);

			uiFactoryMock.Setup(u => u.CreateAboutWindow(It.IsAny<IRuntimeInfo>())).Returns(window.Object);
			sut.RegisterNotification(button);
			button.Click();
			button.Click();
			button.Click();
			button.Click();
			button.Click();

			uiFactoryMock.Verify(u => u.CreateAboutWindow(It.IsAny<IRuntimeInfo>()), Times.Once);
			window.Verify(u => u.Show(), Times.Once);
			window.Verify(u => u.BringToForeground(), Times.Exactly(4));
		}

		[TestMethod]
		public void MustSubscribeToClickEvent()
		{
			var button = new NotificationButtonMock();
			var sut = new AboutNotificationController(runtimeInfoMock.Object, uiFactoryMock.Object);

			sut.RegisterNotification(button);

			Assert.IsTrue(button.HasSubscribed);
		}
	}
}
