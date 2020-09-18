﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PnP.Framework.Tests.Framework.Functional.Implementation;
using System;

namespace PnP.Framework.Tests.Framework.Functional
{
    [TestClass]
    public class WorkflowsTests : FunctionalTestBase
    {
        #region Construction
        public WorkflowsTests()
        {
            //debugMode = true;
            //centralSiteCollectionUrl = "https://bertonline.sharepoint.com/sites/TestPnPSC_12345_60453ae9-a218-436e-9231-cb9da3c4fdd3";
            //centralSubSiteUrl = "https://bertonline.sharepoint.com/sites/TestPnPSC_12345_60453ae9-a218-436e-9231-cb9da3c4fdd3/sub";
        }
        #endregion

        #region Test setup
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            ClassInitBase(context);
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            ClassCleanupBase();
        }

        [TestInitialize()]
        public override void Initialize()
        {
            base.Initialize();

            if (new Uri(TestCommon.DevSiteUrl).DnsSafeHost.Contains("spoppe.com"))
            {
                Assert.Inconclusive("Test that require workflow can't be running on edog.");
            }
        }
        #endregion

        #region Site collection test cases
        /// <summary>
        /// WorkflowsTests Test
        /// </summary>
        [TestMethod]
        [Timeout(15 * 60 * 1000)]
        public void SiteCollectionWorkflowsTest()
        {
            new WorkflowImplementation().Workflows(centralSiteCollectionUrl);
        }
        #endregion

        #region Web test cases
        /// <summary>
        /// WorkflowsTests Test
        /// </summary>
        [TestMethod]
        [Timeout(15 * 60 * 1000)]
        public void WebWorkflowsTest()
        {
            new WorkflowImplementation().Workflows(centralSubSiteUrl);
        }
        #endregion
    }
}
