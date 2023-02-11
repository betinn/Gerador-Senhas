using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GS.Business
{
    internal class ProfileUpdater
    {
        private static readonly string _extention = "GERS";
        private static readonly string _subFolder = Path.Combine(Application.Current.StartupUri.AbsolutePath, "Profiles");
        private static readonly string _backupFiles = Path.Combine(_subFolder, "backup");
    }
}
