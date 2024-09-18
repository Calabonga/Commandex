# Calabonga.Commandex

## Description

Command Executer or Command Launcher. To run commands of any type for any purpose. For example, to execute a stored procedure or just to copy some files to some destination.

## Ingredients

WPF, MVVM, CommunityToolkit, etc.

## What is Calabonga.Commandex

It's a complex solution with a few repositories:

* **[Calabonga.Commandex.Shell](https://github.com/Calabonga/Calabonga.Commandex.Shell)** → Command Executer or Command Launcher. To run commands of any type for any purpose. For example, to execute a stored procedure or just to copy some files to some destination.

* **[Calabonga.Commandex.Commands](https://github.com/Calabonga/Calabonga.Commandex.Commands)** → Commands for Calabonga.Commandex.Shell that can execute them from unified shell.

* **[Calabonga.Commandex.Shell.Develop.Template](https://github.com/Calabonga/Calabonga.Commandex.Shell.Develop.Template)** → This is a Developer version of the Command Executer (`Calabonga.Commandex`). Witch is created to runs commands of any type for any purposes. For example, to execute a stored procedure or just to co…

* **[Calabonga.Commandex.Engine](https://github.com/Calabonga/Calabonga.Commandex.Engine)** → Engine and contracts library for Calabonga.Commandex. Contracts are using for developing a modules for Commandex Shell.

## Version History

### v1.7.0 2024-09-18

*What's Changed*

* Huge refactoring by @Calabonga in https://github.com/Calabonga/Calabonga.Commandex.Shell/pull/20
* Wizard windows style fix by @Calabonga in https://github.com/Calabonga/Calabonga.Commandex.Shell/pull/21
* application icon added by @Calabonga in https://github.com/Calabonga/Calabonga.Commandex.Shell/pull/22
* RC.16 by @Calabonga in https://github.com/Calabonga/Calabonga.Commandex.Shell/pull/23
* Hierarchical commands list by @Calabonga in https://github.com/Calabonga/Calabonga.Commandex.Shell/pull/24


**Full Changelog**: https://github.com/Calabonga/Calabonga.Commandex.Shell/compa

### v1.0.0-rc.16 2024-09-16

* UX refactored
  * Menu added
  * Shortcuts added
  * Three type of the command list view added
* `IDialogResult` renamed to `IViewModel`
* New property `Tags` added to `ICommandexCommand` for future commands groups management

## Known Issues

When your Command need to use `Microsoft.Data.SqlClient` then you should install reference (nuget) in the `Shell` application. [More information](https://stackoverflow.com/questions/78411196/what-data-sqlclient-can-be-used-with-net-8)

## Видео (Video)

### [1. Commandex Framework - Модульный монолит. Идея.](https://boosty.to/calabonga/posts/88abe79c-c396-4b03-9dc2-4c76b20a25ca)


В продолжение темы про эволюцию архитектуры программного обеспечения, в котором речь зашла про "модульный монолит".
В этом видео - пример реализации модульного монолита.

![Commandex-1-intro](https://github.com/user-attachments/assets/acf1289a-c89e-40ba-bfda-0b24867c18bd)

### [2. Commandex Framework - Модульный монолит. Знакомство.](https://boosty.to/calabonga/posts/3915ad48-1f0b-44cc-83ac-a1981d8d6c8e)

В этом видео я представлю вашему вниманию свой новый фреймворк, которые позволит без особых усилий организовать на платформе WPF приложение по работе с плагинами.

![Commandex-2-framework](https://github.com/user-attachments/assets/599dd945-8a1f-43ac-8318-73bea7b99cb8)

### [3. Commandex Framework - Модульный монолит. Shell.](https://boosty.to/calabonga/posts/dba3f618-314e-4383-ae7b-2485ba93a058)

Немного теории про Commandex Framework. В этом видео подробнее про Commandex Shell:

* Клонирование репозитория (загрузка)
* Компиляция
* Настройки в .env
* Справка по работе с Shell
   * Папка с плагинами
   * Nuget установленные и не только...
   * Логирование
   * И другие полезные мелочи

![Commandex-3-shell](https://github.com/user-attachments/assets/72ce2079-9fef-44fb-aa61-5aa2fa9b7219)

### [4. Commandex Framework - Модульный монолит. EmptyCommand.](https://boosty.to/calabonga/posts/fdfd99c2-a3d2-4b19-94ee-eae01aac2ae0)

`EmptyCommandexCommand` - это самый простой тип команды, которые ничего не должен возвращать на Shell, простой триггер, которые можно что-то сделать, и при этом не должен никому ни в чем отчитываться. Simplest command type for Commandex. This type does not anything returns to shell.

![Commandex-4-empty-command](https://github.com/user-attachments/assets/9574459f-94e2-4cc3-8aa1-2d5d70a9c606)

### [5. Commandex Framework - Модульный монолит. Result-команды.](https://boosty.to/calabonga/posts/6fc9185d-feda-4155-b92b-796607604c58)

`ResultCommandexCommand<T>` - это вид команды, который может вернуть на Shell результаты своей работы. На видео были созданы две новые команды:

* `CheckApiReadyCommandexCommand` - возвращает `bool`-значение, которое выбирается случайным образом. 
* `ValidateDocumentCommandexCommand` - возвращает класс `ValidateResult`, значения свойств которого, также выбирается случайным образом. Вдобавок, я показал как обрабатывает Shell ошибки, которые возникают при выполнении команд.

![Commandex-5-result-command](https://github.com/user-attachments/assets/e690628f-1be5-4c1f-92e7-7468a22b0686)

### [6. Commandex Framework - Модульный монолит. Dialog-команды.](https://boosty.to/calabonga/posts/f73a1f14-4e64-4703-9c08-2add245125d6)

![Commandex-6-framework](https://github.com/user-attachments/assets/6dc338cb-cccd-4007-9229-9ee1f67c9126)

### 7. Commandex Framework - Модульный монолит. Wizard-команды. [Видео планируется]

### 8. Commandex Framework - Модульный монолит. Parameter-команды. [Видео планируется]

### 9. Commandex Framework - Модульный монолит. Dialog-команды с параметром. [Видео планируется]

### 10. Commandex Framework - Модульный монолит. Новый Shell - новые возможности. [Видео планируется]
