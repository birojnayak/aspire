// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Aspire.Dashboard.Components.Dialogs;
using Microsoft.FluentUI.AspNetCore.Components;

namespace Aspire.Dashboard.Components.Layout;

public partial class MainLayout
{
    public async Task LaunchSettings()
    {
        DialogParameters parameters = new()
        {
            Title = Loc[Resources.Layout.MainLayoutSettingsDialogTitle],
            PrimaryAction = Resources.Layout.MainLayoutSettingsDialogClose,
            PrimaryActionEnabled = true,
            SecondaryAction = null,
            TrapFocus = true,
            Modal = true,
            Alignment = HorizontalAlignment.Right,
            Width = "300px",
            Height = "auto"
        };

        _ = await dialogService.ShowPanelAsync<SettingsDialog>(parameters).ConfigureAwait(true);
    }
}
