using AMS.ConnectionStrings.Services;
using AMS.Core.Models;
using AMS.Settings.Services;
using System.Configuration;

namespace Marathon.Kittyhawk.Infrastructure.Framework
{
    public static class Global
    {        
        public static string CrossReferenceUrl { get; set; }        
        public static string AllocationManagerUrl { get; set; }
        public static string PIUrl { get; set; }
        public static string TerminalDownloadUrl { get; set; }
        public static ProxyUser ServiceAccountWithDomain { get; set; }
        public static ProxyUser ServiceAccountWithoutDomain { get; set; }
        public static string RightAngleCoreConnectionString { get; set; }
        public static string MasterServiceRAConnectionString { get; set; }
        public static string GainLossTerminalCode { get; set; }
        public static string HardinStreetMarineCode { get; set; }
        public static string MarathonPetroleumCompanyCode { get; set; }
        public static string MarathonRefiningAndMarketingCode { get; set; }
        public static string MarathonTerminalCode { get; set; }
        public static string MarathonTTRCode { get; set; }
        public static string MPCInternalUseCode { get; set; }
        public static bool SkipAllocationManagerLookup { get; set; }
        public static string CatlettsburgTransOrigin { get; set; }
        public static string CompanyUseTerminalCode { get; set; }
        public static string ApiGravityTransOrigins { get; set; }

        static Global()
        {
            var appSettingService = new AppSettingService();
            var connStringService = new ConnStringService();

            CrossReferenceUrl = appSettingService.GetAppSettingAsync($"KH-XREF-{Services.Environments.Environment}").Result.Value;
            AllocationManagerUrl = appSettingService.GetAppSettingAsync($"KH-AM-{Services.Environments.Environment}").Result.Value;
            PIUrl = appSettingService.GetAppSettingAsync($"KH-TU-PI-{Services.Environments.Environment}").Result.Value;
            TerminalDownloadUrl = appSettingService.GetAppSettingAsync($"KH-TD-{Services.Environments.Environment}").Result.Value;
            RightAngleCoreConnectionString = connStringService.GetConnStringAsObjectAsync($"Kittyhawk-{Services.Environments.Environment}").Result.ConnectionString;

            if (Services.Environments.Environment == Services.EnvironmentType.Local)
            {
                MasterServiceRAConnectionString = ConfigurationManager.ConnectionStrings["SRARead"].ConnectionString;
            }
            else
            { 
                MasterServiceRAConnectionString = connStringService.GetConnStringAsObjectAsync($"Kittyhawk-SRARead-{Services.Environments.Environment}").Result.ConnectionString;
            }

            GainLossTerminalCode = appSettingService.GetAppSettingAsync($"KH-BA-GainLoss-Terminal-{Services.Environments.Environment}").Result.Value;
            HardinStreetMarineCode = appSettingService.GetAppSettingAsync($"KH-BA-Hardin-Street-Marine-LLC-{Services.Environments.Environment}").Result.Value;
            MarathonPetroleumCompanyCode = appSettingService.GetAppSettingAsync($"KH-BA-Marathon-Petroleum-Company-LP-{Services.Environments.Environment}").Result.Value;
            MarathonRefiningAndMarketingCode = appSettingService.GetAppSettingAsync($"KH-BA-Marathon-Refining-Marketing-{Services.Environments.Environment}").Result.Value;
            MarathonTerminalCode = appSettingService.GetAppSettingAsync($"KH-BA-Marathon-Terminals-{Services.Environments.Environment}").Result.Value;
            MarathonTTRCode = appSettingService.GetAppSettingAsync($"KH-BA-Marathon-TTR-{Services.Environments.Environment}").Result.Value;
            MPCInternalUseCode = appSettingService.GetAppSettingAsync($"KH-BA-MPC-InternalUse-{Services.Environments.Environment}").Result.Value;
            SkipAllocationManagerLookup = bool.Parse(appSettingService.GetAppSettingAsync($"KH-AM-Skip-Lookup-{Services.Environments.Environment}").Result.Value);
            CatlettsburgTransOrigin = appSettingService.GetAppSettingAsync($"KH-TU-Catlettsburg-TransOrigin-{Services.Environments.Environment}").Result.Value;
            CompanyUseTerminalCode = appSettingService.GetAppSettingAsync($"KH-BA-CompanyUse-Terminal-{Services.Environments.Environment}").Result.Value;
            ApiGravityTransOrigins = appSettingService.GetAppSettingAsync($"KH-TU-APIGravity-TransOrigins-{Services.Environments.Environment}").Result.Value;

            ServiceAccountWithDomain = connStringService.GetProxyUser($"ServiceAccountWithDomain-{Services.Environments.Environment}");
            ServiceAccountWithoutDomain = connStringService.GetProxyUser($"ServiceAccountWithoutDomain-{Services.Environments.Environment}");
        }
    }
}
