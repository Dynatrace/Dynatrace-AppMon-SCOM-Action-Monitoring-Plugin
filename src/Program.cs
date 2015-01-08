using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EnterpriseManagement;
using Microsoft.EnterpriseManagement.ConnectorFramework;
using Microsoft.EnterpriseManagement.Common;
using Microsoft.EnterpriseManagement.Configuration;
using Microsoft.EnterpriseManagement.Monitoring;

namespace dynaTrace.SCOM.EventSender
{
    class Program
    {
        public static string connectorName = "dynaTrace SCOM Connector";
        public static string connectorId = "{5EBADB87-547C-4abd-AC79-C7FB2D0FACEF}";
        public static string monitorObjectId = null;
        private static string userName = null;
        private static string domainName = null;
        private static string passWord = null;
        private static string serverName = null;
        private static string severity = null;
        private static string alertName = null;
        private static string alertDesc = null;
        private static string srcMachine = null;

        static void ParseArguments(string[] args)
        {
            if ((args.Length == 0) || (args[0] != "/i" && args[0] != "/e" && args[0] != "/u"))
            {
                Console.WriteLine("Usage: dynaTrace.SCOM.exe /launchoption [options]");
                Console.WriteLine("Launchoptions:");
                Console.WriteLine("--------------");
                Console.WriteLine("/i : install dynaTrace SCOM Connector");
                Console.WriteLine("/u : uninstall dynaTrace SCOM Connector");
                Console.WriteLine("/e : sends an event to the dynaTrace SCOM Connector");
                Console.WriteLine("Options:");
                Console.WriteLine("--------------");
                Console.WriteLine("/user       : Username to authenticate on SCOM Server");
                Console.WriteLine("/domain     : Domainname to authenticate on SCOM Server");
                Console.WriteLine("/pwd        : Password to authenticate on SCOM Server");
                Console.WriteLine("/server     : SCOM Server name");
                Console.WriteLine("/severity   : Severity of the alert. 0=information, 1=warning, 2=error");
                Console.WriteLine("/alertname  : Name of the Alert");
                Console.WriteLine("/alertdesc  : Description of the Alert");
                Console.WriteLine("/srcmachine : Source machine of the Alert");
                System.Environment.Exit(1);
            }

            serverName = dynaTrace.SCOM.Properties.Settings.Default.SCOMServer_ServerName;
            userName = dynaTrace.SCOM.Properties.Settings.Default.SCOMServer_Username;
            domainName = dynaTrace.SCOM.Properties.Settings.Default.SCOMServer_Domain;

            for(int i=1;i<args.Length;i++)
            {
                if(args[i].ToLower() == "/user")
                    userName = args[i+1];
                if (args[i].ToLower() == "/domain")
                    domainName = args[i + 1];
                if (args[i].ToLower() == "/pwd")
                    passWord = args[i + 1];
                if (args[i].ToLower() == "/server")
                    serverName = args[i + 1];
                if (args[i].ToLower() == "/severity")
                    severity = args[i + 1];
                if (args[i].ToLower() == "/alertname")
                    alertName = args[i + 1];
                if (args[i].ToLower() == "/alertdesc")
                    alertDesc = args[i + 1];
                if (args[i].ToLower() == "/srcmachine")
                    srcMachine = args[i + 1];
            }

            if (serverName == null || serverName.Length == 0)
            {
                Console.WriteLine("No SCOM servername specified.");
                System.Environment.Exit(1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("dynaTrace.SCOM.EventSender.Program starting.");

            
            // parse our parameters
            ParseArguments(args);

            try
            {
                // first we get connected to SCOM server. If we have username/password supplied we use a mgntgroupconnectionsetting object to pass credentials
                // http://msdn.microsoft.com/en-us/library/bb437619.aspx
                ManagementGroupConnectionSettings mgSettings = new ManagementGroupConnectionSettings(serverName);
                mgSettings.CacheMode = CacheMode.None;
                if (userName != null && userName.Length > 0)
                {
                    mgSettings.UserName = userName;
                    mgSettings.Password = new System.Security.SecureString();
                    char[] passwordArray = passWord.ToCharArray();
                    foreach (char c in passwordArray)
                        mgSettings.Password.AppendChar(c);
                    mgSettings.Domain = domainName;
                }
                Console.WriteLine("Connecting to SCOM server: '{0}' as user {1}\\{2}", serverName, domainName, userName);
                //  Changed this section to connect to managementgroup only with supplied credentials - ELazar 03/06/14
                //ManagementGroup mg = new ManagementGroup(serverName);
                //ManagementGroup managementGroup = ManagementGroup.Connect(mgSettings);
                ManagementGroup mg = ManagementGroup.Connect(mgSettings);

                if (args[0] == "/i") // /i==install
                {
                    ConnectorFrameworkAdministration admin = mg.GetConnectorFrameworkAdministration();
                    ConnectorInfo info = new ConnectorInfo();

                    info.Description = connectorName;
                    info.DisplayName = connectorName;
                    info.Name = connectorName;
                    MonitoringConnector connector = admin.Setup(info, new Guid(connectorId));
                    connector.Initialize();

                    Console.WriteLine("Created '{0}' with ID: '{1}'", connector.Name, connector.Id);
                }
                if (args[0] == "/e") // /e==send event
                {
                    // query for the dynaTrace object
                    //  Removed hardcoded version number and changed GetManagementPack to GetManagementPacks()[0] - ELazar 02/26/14
                    //ManagementPack mgmtPack = mg.GetManagementPack("dynaTrace", null, new System.Version("1.0.0.0"));
                    ManagementPack mgmtPack = mg.GetManagementPacks("dynaTrace")[0];
                    ManagementPackClass mgmtPackClass = mgmtPack.GetClass("dynaTrace.Server");
                    MonitoringClass monClass = mg.GetMonitoringClass("dynaTrace.Server", mgmtPack);
                    System.Collections.ObjectModel.ReadOnlyCollection<MonitoringObject> monObjects = mg.GetMonitoringObjects(monClass);
                    MonitoringObject monObject = monObjects[0];
                    monitorObjectId = monObject.Id.ToString();

                    Console.WriteLine("Identified SCOM Objects:\n* dynaTrace Management Pack: {0}\n* dynaTrace.Server Object: {1}", mgmtPack.Id, monObject.Id);

                    // sending events with Managed APi
                    CustomMonitoringEvent custEventData = new CustomMonitoringEvent("dynaTrace", 1);
                    custEventData.LoggingComputer = srcMachine;
                    custEventData.Channel = "dynaTrace";
                    custEventData.TimeGenerated = DateTime.Now;
                    // 1=success, 2=warning, 3=other, 4=information
                    custEventData.LevelId = 1;
                    custEventData.EventData = String.Format("<Data><AlertSeverity>{0}</AlertSeverity><AlertName>{1}</AlertName><AlertDescription>{2}</AlertDescription></Data>", severity, alertName, alertDesc);
                    monObject.InsertCustomMonitoringEvent(custEventData);

                    Console.WriteLine("Sent event data: " + custEventData.EventData);
                }
                if (args[0] == "/u") // /u==uninstall
                {
                    ConnectorFrameworkAdministration admin = mg.GetConnectorFrameworkAdministration();
                    ConnectorInfo info = new ConnectorInfo();
                    MonitoringConnector connector = admin.GetMonitoringConnector(new Guid(connectorId));
                    admin.Cleanup(connector);

                    Console.WriteLine("Removed '{0}' with ID: '{1}'", connector.Name, connector.Id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                System.Environment.Exit(2);
            }
        }
    }
}
