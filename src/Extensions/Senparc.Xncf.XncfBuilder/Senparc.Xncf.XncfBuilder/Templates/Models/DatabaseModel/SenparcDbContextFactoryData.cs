﻿using Senparc.Xncf.XncfBuilder.Templates;

namespace Senparc.Xncf.XncfBuilder.Templates.Models.DatabaseModel
{
    public partial class SenparcDbContextFactory : IXncfTemplatePage
    {
        /// <summary>
        /// 相对地址
        /// </summary>
        public string RelativeFilePath => $"Models\\DatabaseModel\\SenparcDbContextFactory.cs";

        public string OrgName { get; set; }
        public string XncfName { get; set; }

        public SenparcDbContextFactory(string orgName, string xncfName)
        {
            OrgName = orgName;
            XncfName = xncfName;
        }
    }
}
