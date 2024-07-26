﻿namespace Calabonga.Commandex.UI.Core.Dialogs;

public interface IDialogService
{
    void ShowDialog<TView, TViewModel>(Action<TViewModel> callback) where TView : IDialogView;

    void ShowDialog(string message, LogLevel type);
}