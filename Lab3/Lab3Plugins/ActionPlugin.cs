using System;
using Lab3Plugins.Data;

namespace Lab3Plugins
{
    public interface IUniversityActionPlugin
    {
        string ActionText { get; }
        void ApplyTo(University university);
    }

    public interface IGroupActionPlugin
    {
        string ActionText { get; }
        void ApplyTo(Group group);
    }
}
