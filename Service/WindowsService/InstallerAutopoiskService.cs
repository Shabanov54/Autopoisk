using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace WindowsService
{
    [RunInstaller(true)]
    public partial class InstallerAutopoiskService : Installer

    {
        ServiceInstaller serviceInstaller;
        ServiceProcessInstaller processInstaller;
        public InstallerAutopoiskService()
        {
            InitializeComponent();
            serviceInstaller = new ServiceInstaller();
            processInstaller = new ServiceProcessInstaller();

            processInstaller.Account = ServiceAccount.LocalService;
            serviceInstaller.StartType = ServiceStartMode.Manual;
            serviceInstaller.ServiceName = "AutopoiskService";
            serviceInstaller.StartType = ServiceStartMode.Automatic;
            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
        }
    }
}
