﻿using Calabonga.Commandex.Engine.Dialogs;
using Calabonga.Commandex.Engine.Settings;
using Calabonga.Commandex.Engine.Wizards;
using Calabonga.Commandex.Shell.Core;
using Calabonga.Commandex.Shell.Extensions;
using Calabonga.Commandex.Shell.Services;
using Calabonga.Commandex.Shell.ViewModels;
using Calabonga.Commandex.Shell.ViewModels.Dialogs;
using Calabonga.Commandex.Shell.Views;
using Calabonga.Commandex.Shell.Views.Dialogs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Calabonga.Commandex.Shell.Engine;

internal static class DependencyContainer
{
    /// <summary>
    /// Configure services
    /// </summary>
    /// <returns></returns>
    internal static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddLogging(options =>
        {
            options.AddSerilog(dispose: true);
            options.AddDebug();
        });

        // views and models for views
        services.AddSingleton<ShellWindow>();
        services.AddSingleton<ShellWindowViewModel>();
        services.AddSingleton<AboutDialog>();
        services.AddSingleton<AboutDialogResult>();
        services.AddSingleton<DefaultDialogView>();

        // engine
        services.AddTransient<CommandExecutor>();
        services.AddTransient<ArtifactService>();
        services.AddTransient<FileService>();
        services.AddTransient<NugetLoader>();
        services.AddScoped<IConfigurationFinder, ConfigurationFinder>();

        // dialogs and wizard
        services.AddSingleton<IWizardView, Wizard>();
        services.AddSingleton<IDialogService, DialogService>();
        services.AddSingleton<IVersionService, VersionService>();

        // settings
        services.AddSingleton<IAppSettings>(_ => App.Current.Settings);

        // definitions
        services.AddModulesDefinitions();

        return services.BuildServiceProvider();
    }
}