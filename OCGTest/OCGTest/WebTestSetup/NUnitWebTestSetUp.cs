﻿using AutomationFramework.Configs;
using AutomationFramework.DriverCore;
using AutomationFramework.TestSetup;
using NUnit.Framework;
using OCGTest.PageObject;

namespace OCGTest.WebTestSetup
{
    public class NUnitWebTestSetUp : NUnitTestSetup
    {
        #region INIT PAGE OBJS + ASSERTER
        protected Asserter.Asserter? Asserter;
        protected HomePage? HomePage;
        protected SearchResultPage? SearchResultPage;

        #endregion
        #region INIT DAO + DATA FROM UI

        #endregion


        public NUnitWebTestSetUp(string browser, int width, int height) : base( browser,  width,  height)
        {

        }

        [SetUp]
        public void WebTestSetUp()
        {
            /// Initialize header pages
            ConfigManager_ = new ConfigManager();
            DriverBaseAction = new WebDriverAction();
            string appConfig = ConfigManager.GetConfig<AppConfig>("Application").BaseUrl;
            DriverBaseAction.GoToUrl(appConfig);
            Console.Write(appConfig);
            HomePage = new HomePage();
            SearchResultPage = new SearchResultPage();


        }
        [TearDown]
        public void WebTestTearDown()
        {

        }
    }
}

