﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Xncf.XncfBuilder.Templates.Migrations.Migrations.MySql
{
    public partial class AddSample : IXncfTemplatePage
    {
        /// <summary>
        /// 相对地址
        /// </summary>
        public string RelativeFilePath => $"Migrations/Migrations.MySql/{MigrationTime}_AddSample.cs";

        public string OrgName { get; set; }
        public string XncfName { get; set; }
        public string MigrationTime { get; set; }

        public AddSample(string orgName, string xncfName, string migrationTime)
        {
            OrgName = orgName;
            XncfName = xncfName;
            MigrationTime = migrationTime;
        }
    }
}
