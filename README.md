# LeoECSLite System Groups - Группировка систем в отдельные файлы

# Содержание

* [Создание групп](#Создание-групп)
    * [Обычная группа](#Обычная-группа)
    * [Вложенные группы](#Вложенные-группы)
* [Подключение](#Подключение)
* [Контакты](#Контакты)

# Социальные ресурсы

> #### Discord [Группа по LeoEcsLite](https://discord.gg/5GZVde6)
> #### Telegram [Группа по Ecs](https://t.me/ecschat)

# Установка

> **ВАЖНО!** Зависит от [LeoECS Lite](https://github.com/Leopotam/ecslite) - фреймворк должен быть установлен до этого расширения.

## В виде unity модуля

Поддерживается установка в виде unity-модуля через git-ссылку в PackageManager:

```
https://github.com/skelitheprogrammer/LeoECSLite-EcsSystemGroups.git
```

или прямое редактирование `Packages/manifest.json`:

```
"com.skillitronic.leoecssystemgroups": "https://github.com/skelitheprogrammer/LeoECSLite-EcsSystemGroups.git",
```

# Создание групп

## Обычная группа

```c#
    public sealed class TestSystemGroupWithOneSystems : IEcsSystemGroup
    {
        public IEcsSystem[] Systems { get; }

        public TestSystemGroupWithOneSystems()
        {
            Systems = new IEcsSystem[]
            {
                new TestEmptySystemOne(),
            };
        }
    }
```

## Вложенные группы

```c#
    public sealed class TestSystemGroupWithNestedSystemGroupSystems : IEcsSystemGroup
    {
        public IEcsSystem[] Systems { get; }

        public TestSystemGroupWithOneSystems(string message)
        {
            Systems = new IEcsSystem[]
            {
                new TestSystemGroupWithOneSystems(),
                new TestEmptySystemTwo(message),
            };
        }
    }
```

# Подключение

```c#
    ...
    EcsWorld world = new();
    IEcsSystems systems = new EcsSystems(world);

    systems.AddGroup(new testSystemGroupWithOneSystems());
    systems.Init();
    ...
```

# Контакты

E-mail: dosynkirill@gmail.com </br>
Discord: @skilli на [сервере дискорд](#Социальные-ресурсы)
