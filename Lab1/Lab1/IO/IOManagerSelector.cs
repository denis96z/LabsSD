using System;
using System.IO;

namespace Lab1
{
    interface IIOManagerSelector
    {
        IIOManager GetManager();
    }

    class IOManagerByExtensionSelector : IIOManagerSelector
    {
        private string fileName = null;

        public IOManagerByExtensionSelector(string fileName)
        {
            this.fileName = fileName ?? throw new ArgumentNullException("fileName");
        }

        public IIOManager GetManager()
        {
            string e = Path.GetExtension(fileName);
            switch (Path.GetExtension(fileName))
            {
                case ".xml":
                    return new XMLFileManager(fileName);

                default:
                    return null;
            }
        }
    }
}