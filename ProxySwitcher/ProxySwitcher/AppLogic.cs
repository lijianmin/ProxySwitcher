using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Microsoft.Win32;

namespace ProxySwitcher
{
    public class AppLogic
    {
        //private String proxyAddress;
        //private int portNo;
        //private Boolean isDisabled;
        private String serverSource;
        private RegistryKey proxyReg;

        public AppLogic()
        {
            //this.proxyAddress = "";
            //this.portNo = 0;
            //this.isDisabled = false;
            this.serverSource = "servers.txt";
            this.proxyReg = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
        }

        public List<String> LoadServers()
        {
            List<String> servers = new List<String>();

            String line;

            try
            {
                StreamReader file = new StreamReader(this.serverSource);

                while ((line = file.ReadLine()) != null) servers.Add(line);
            }
            catch (FileNotFoundException err)
            {
                //Its a Winforms app anyway...
            }

            return servers;
        }

        //Enable proxy
        public void EnableProxy(String proxyAddress)
        { 
            proxyReg.SetValue("ProxyEnable", 1);
            proxyReg.SetValue("ProxyServer", proxyAddress);
        }

        //Disable Proxy
        public void DisableProxy()
        {
            proxyReg.SetValue("ProxyEnable", 0);
        }

    }
}
