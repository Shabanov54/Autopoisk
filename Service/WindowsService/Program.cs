using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {

//#if DEBUG
//            //While debugging this section is used.
//            AutopoiskService autopoiskService = new AutopoiskService();
//            autopoiskService.onDebug();
//            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
//        }
//    }
//}


//#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new AutopoiskService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
//#endif

