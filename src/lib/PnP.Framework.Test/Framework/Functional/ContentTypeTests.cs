﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PnP.Framework.Tests.Framework.Functional.Implementation;

namespace PnP.Framework.Tests.Framework.Functional
{
    [TestClass]
    public class ContentTypeTests : FunctionalTestBase
    {
        #region Construction
        public ContentTypeTests()
        {
            //debugMode = true;
            //centralSiteCollectionUrl = "https://bertonline.sharepoint.com/sites/TestPnPSC_12345_c81e4b0d-0242-4c80-8272-18f13e759333";
            //centralSubSiteUrl = "https://bertonline.sharepoint.com/sites/TestPnPSC_12345_c81e4b0d-0242-4c80-8272-18f13e759333/sub";
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
        #endregion

        #region Site collection test cases
        [TestMethod]
        [Timeout(15 * 60 * 1000)]
        public void SiteCollectionContentTypeAddingTest()
        {
            new ContentTypeImplementation().SiteCollectionContentTypeAdding(centralSiteCollectionUrl);
        }
        #endregion

        #region Web test cases
        // No need to have these as the engine is blocking creation and extraction of content types at web level
        #endregion
    }
}
