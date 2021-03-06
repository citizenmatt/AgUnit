﻿using JetBrains.ReSharper.TaskRunnerFramework;

namespace AgUnit.Runner.Resharper61.TaskRunner.UnitTestRunner.Silverlight.Providers
{
    public interface IAssemblyTaskProvider
    {
        bool IsAssemblyTask(RemoteTask task);
        string GetAssemblyLocation(RemoteTask task);
    }
}