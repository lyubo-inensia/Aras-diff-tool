using Aras.IOM;
using InnoTool.Models;
using InnoTool.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnoTool.Factories
{
    public class MainFactory : IMainFactory
    {
        IConfigService confService;
        public IConfigService GetConfigService()
        {
            if (confService == null)
            {
                confService = new ConfigService();
            }

            return confService;
        }

        public IDiffService GetDiffService()
        {
            return new DiffService();
        }

        public IPackageService GetPackageService(ConnectionSettings conn)
        {
            return new PackageService(GetInnovatorService(conn));
        }
        public InnovatorService GetInnovatorService(ConnectionSettings conn)
        {
            return new InnovatorService(conn);
        }
        public Innovator GetInnovator(ConnectionSettings conn)
        {
            return IomFactory.CreateInnovator(
                        IomFactory.CreateHttpServerConnection(
                            conn.Url,
                            conn.Database,
                            conn.Username,
                            conn.Password
                            )
                        );
        }
    }
}
