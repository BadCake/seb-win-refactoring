﻿/*
 * Copyright (c) 2020 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.I18n.Contracts
{
	/// <summary>
	/// Defines all text elements of the user interface. Use the pattern "LogicalGroup_Description" to allow for a better overview over all
	/// keys and their usage (where applicable).
	/// </summary>
	public enum TextKey
	{
		AboutWindow_LicenseInfo,
		AboutWindow_Title,
		Browser_BlockedContentMessage,
		Browser_BlockedPageButton,
		Browser_BlockedPageMessage,
		Browser_BlockedPageTitle,
		Browser_Name,
		Browser_Tooltip,
		BrowserWindow_DeveloperConsoleMenuItem,
		BrowserWindow_Downloading,
		BrowserWindow_DownloadCancelled,
		BrowserWindow_DownloadComplete,
		BrowserWindow_ZoomMenuItem,
		Build,
		FileSystemDialog_Cancel,
		FileSystemDialog_LoadError,
		FileSystemDialog_Loading,
		FileSystemDialog_OpenFileMessage,
		FileSystemDialog_OpenFolderMessage,
		FileSystemDialog_OverwriteWarning,
		FileSystemDialog_OverwriteWarningTitle,
		FileSystemDialog_SaveAs,
		FileSystemDialog_SaveFileMessage,
		FileSystemDialog_SaveFolderMessage,
		FileSystemDialog_Select,
		FileSystemDialog_Title,
		FolderDialog_ApplicationLocation,
		LockScreen_AllowOption,
		LockScreen_Message,
		LockScreen_TerminateOption,
		LockScreen_Title,
		LockScreen_UnlockButton,
		LogWindow_AlwaysOnTop,
		LogWindow_AutoScroll,
		LogWindow_Title,
		MessageBox_ApplicationAutoTerminationDataLossWarning,
		MessageBox_ApplicationAutoTerminationQuestion,
		MessageBox_ApplicationAutoTerminationQuestionTitle,
		MessageBox_ApplicationError,
		MessageBox_ApplicationErrorTitle,
		MessageBox_ApplicationInitializationFailure,
		MessageBox_ApplicationInitializationFailureTitle,
		MessageBox_ApplicationNotFound,
		MessageBox_ApplicationNotFoundTitle,
		MessageBox_ApplicationTerminationFailure,
		MessageBox_ApplicationTerminationFailureTitle,
		MessageBox_BrowserNavigationBlocked,
		MessageBox_BrowserNavigationBlockedTitle,
		MessageBox_BrowserQuitUrlConfirmation,
		MessageBox_BrowserQuitUrlConfirmationTitle,
		MessageBox_CancelButton,
		MessageBox_ClientConfigurationError,
		MessageBox_ClientConfigurationErrorTitle,
		MessageBox_ClientConfigurationQuestion,
		MessageBox_ClientConfigurationQuestionTitle,
		MessageBox_ConfigurationDownloadError,
		MessageBox_ConfigurationDownloadErrorTitle,
		MessageBox_InvalidConfigurationData,
		MessageBox_InvalidConfigurationDataTitle,
		MessageBox_InvalidPasswordError,
		MessageBox_InvalidPasswordErrorTitle,
		MessageBox_InvalidQuitPassword,
		MessageBox_InvalidQuitPasswordTitle,
		MessageBox_InvalidUnlockPassword,
		MessageBox_InvalidUnlockPasswordTitle,
		MessageBox_NoButton,
		MessageBox_NotSupportedConfigurationResource,
		MessageBox_NotSupportedConfigurationResourceTitle,
		MessageBox_OkButton,
		MessageBox_Quit,
		MessageBox_QuitTitle,
		MessageBox_QuitError,
		MessageBox_QuitErrorTitle,
		MessageBox_ReconfigurationDenied,
		MessageBox_ReconfigurationDeniedTitle,
		MessageBox_ReconfigurationError,
		MessageBox_ReconfigurationErrorTitle,
		MessageBox_ReloadConfirmation,
		MessageBox_ReloadConfirmationTitle,
		MessageBox_ServiceUnavailableError,
		MessageBox_ServiceUnavailableErrorTitle,
		MessageBox_ServiceUnavailableWarning,
		MessageBox_ServiceUnavailableWarningTitle,
		MessageBox_SessionStartError,
		MessageBox_SessionStartErrorTitle,
		MessageBox_ShutdownError,
		MessageBox_ShutdownErrorTitle,
		MessageBox_StartupError,
		MessageBox_StartupErrorTitle,
		MessageBox_UnexpectedConfigurationError,
		MessageBox_UnexpectedConfigurationErrorTitle,
		MessageBox_VirtualMachineNotAllowed,
		MessageBox_VirtualMachineNotAllowedTitle,
		MessageBox_YesButton,
		Notification_AboutTooltip,
		Notification_LogTooltip,
		OperationStatus_CloseRuntimeConnection,
		OperationStatus_EmptyClipboard,
		OperationStatus_FinalizeApplications,
		OperationStatus_FinalizeServiceSession,
		OperationStatus_InitializeApplications,
		OperationStatus_InitializeBrowser,
		OperationStatus_InitializeConfiguration,
		OperationStatus_InitializeKioskMode,
		OperationStatus_InitializeRuntimeConnection,
		OperationStatus_InitializeServiceSession,
		OperationStatus_InitializeShell,
		OperationStatus_InitializeWorkingArea,
		OperationStatus_RestartCommunicationHost,
		OperationStatus_RestoreWorkingArea,
		OperationStatus_RevertKioskMode,
		OperationStatus_StartClient,
		OperationStatus_StartCommunicationHost,
		OperationStatus_StartKeyboardInterception,
		OperationStatus_StartMouseInterception,
		OperationStatus_InitializeSession,
		OperationStatus_StopClient,
		OperationStatus_StopCommunicationHost,
		OperationStatus_StopKeyboardInterception,
		OperationStatus_StopMouseInterception,
		OperationStatus_TerminateBrowser,
		OperationStatus_TerminateShell,
		OperationStatus_ValidateVirtualMachinePolicy,
		OperationStatus_WaitExplorerStartup,
		OperationStatus_WaitExplorerTermination,
		OperationStatus_WaitRuntimeDisconnection,
		PasswordDialog_Cancel,
		PasswordDialog_Confirm,
		PasswordDialog_LocalAdminPasswordRequired,
		PasswordDialog_LocalAdminPasswordRequiredTitle,
		PasswordDialog_LocalSettingsPasswordRequired,
		PasswordDialog_LocalSettingsPasswordRequiredTitle,
		PasswordDialog_QuitPasswordRequired,
		PasswordDialog_QuitPasswordRequiredTitle,
		PasswordDialog_SettingsPasswordRequired,
		PasswordDialog_SettingsPasswordRequiredTitle,
		RuntimeWindow_ApplicationRunning,
		Shell_QuitButton,
		SystemControl_AudioDeviceInfo,
		SystemControl_AudioDeviceInfoMuted,
		SystemControl_AudioDeviceMuteTooltip,
		SystemControl_AudioDeviceNotFound,
		SystemControl_AudioDeviceUnmuteTooltip,
		SystemControl_BatteryCharged,
		SystemControl_BatteryCharging,
		SystemControl_BatteryChargeCriticalWarning,
		SystemControl_BatteryChargeLowInfo,
		SystemControl_BatteryRemainingCharge,
		SystemControl_KeyboardLayoutTooltip,
		SystemControl_WirelessConnected,
		SystemControl_WirelessConnecting,
		SystemControl_WirelessDisconnected,
		SystemControl_WirelessNotAvailable,
		Version
	}
}
