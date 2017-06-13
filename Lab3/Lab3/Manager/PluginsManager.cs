using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Lab3Plugins;

namespace Lab3.Manager
{
    class PluginsManager
    {
        public List<Type> UniversityPlugins { get; } = new List<Type>();
        public List<Type> GroupPlugins { get; } = new List<Type>();

        public List<Type> UniversityActionPlugins { get; } = new List<Type>();
        public List<Type> GroupActionPlugins { get; } = new List<Type>();

        public void LoadPlugins()
        {
            string[] pluginFiles = Directory.GetFiles(
                Environment.CurrentDirectory, "*.dll");

            foreach (string pluginPath in pluginFiles)
            {
                if (Path.GetFileNameWithoutExtension(pluginPath) == "Lab3Plugins")
                {
                    continue;
                }

                Type objType = null;
                try
                {
                    Assembly assembly = Assembly.LoadFrom(pluginPath);
                    if (assembly == null)
                    {
                        continue;
                    }

                    if ((objType = assembly.GetType("UniversityPlugins." +
                        Path.GetFileNameWithoutExtension(pluginPath))) != null)
                    {
                        UniversityPlugins.Add(objType);
                        continue;
                    }

                    if ((objType = assembly.GetType("GroupPlugins." +
                        Path.GetFileNameWithoutExtension(pluginPath))) != null)
                    {
                        GroupPlugins.Add(objType);
                        continue;
                    }

                    if ((objType = assembly.GetType("UniversityActionPlugins." +
                        Path.GetFileNameWithoutExtension(pluginPath))) != null)
                    {
                        UniversityActionPlugins.Add(objType);
                        continue;
                    }

                    if ((objType = assembly.GetType("GroupActionPlugins." +
                        Path.GetFileNameWithoutExtension(pluginPath))) != null)
                    {
                        GroupActionPlugins.Add(objType);
                        continue;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }

        public Type this[string pluginName]
        {
            get
            {
                foreach (Type t in UniversityPlugins)
                {
                    if (t.Name == pluginName)
                    {
                        return t;
                    }
                }

                foreach (Type t in GroupPlugins)
                {
                    if (t.Name == pluginName)
                    {
                        return t;
                    }
                }

                foreach (Type t in UniversityActionPlugins)
                {
                    if (t.Name == pluginName)
                    {
                        return t;
                    }
                }

                foreach (Type t in GroupActionPlugins)
                {
                    if (t.Name == pluginName)
                    {
                        return t;
                    }
                }

                throw new ArgumentException();
            }
        }
    }
}
