﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AimyTest.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace AimyTest.Booking_Manager
{
    public class BookingManager : MyElelment
    {
        private readonly log4net.ILog log = Utilities.LogHelper.GetLogger();

        static private string sURL;

        // 'Select All Terms' checkbox
        [FindsBy(How = How.Id, Using = "all-terms-toggle")]
        private IWebElement chkAllTerms { get; set; }

        // 'CONFIRMED BOOKING' pane
        //[FindsBy(How = How.XPath, Using = "html/body/div[3]/div[3]/ul/li[2]/a")]
        [FindsBy(How = How.XPath, Using = "html/body/div[3]/div[3]/ul/li[2]/a")]
        private IWebElement lnkConfirmedBooking { get; set; }

        //// Child 'Marlon Casson' under Pending Bookings
        //[FindsBy(How = How.LinkText, Using = "Marlon Casson")]
        //public IWebElement lnkChild1 { get; set; }

        //// Child 'Marlon Casson' under Pending Bookings
        //[FindsBy(How = How.LinkText, Using = "Tony Casson")]
        //public IWebElement lnkChild2 { get; set; }

        private bool ValidationBooking(IWebDriver driver, string TestName, string Name)
        {
            log.Info("Booking Manager Validation Test Case: ");

            AimyClick(driver, chkAllTerms);

            IReadOnlyCollection<IWebElement> elements = null;
            try
            {
                elements = WebDriverExtensions.FindElements(driver,
                    By.LinkText(Name),
                    10);
            }
            catch (Exception)
            {
                if (elements == null)
                {
                    log.Info("[FAIL] " + TestName);
                    log.Info("'" + Name + "' does NOT exist under " + TestName + ". FAILED!");
                    return false;
                }
            }
            log.Info("[PASS] " + TestName);
            log.Info("The child '" + Name + "' exist under " + TestName + ". PASSED!");
            return true;
        }

        public bool ValidationPendingBookingExist(IWebDriver driver, string Name)
        {
            sURL = GlobalVariable.sURL + "Finance/RedirectType?type=BookingConfirmation";
            driver.Navigate().GoToUrl(sURL);

            Common.WaitBySleeping(GlobalVariable.iShortWait);

            bool exist = ValidationBooking(driver, "BookingManager - Pending Booking Checking",
                Name);
            return exist;            
        }

        public bool ValidationConfirmedBookingExist(IWebDriver driver, string ChildName)
        {
            sURL = GlobalVariable.sURL + "Finance/RedirectType?type=BookingConfirmation";
            driver.Navigate().GoToUrl(sURL);

            Common.WaitBySleeping(GlobalVariable.iShortWait);

            AimyClick(driver, lnkConfirmedBooking);

            Common.WaitBySleeping(GlobalVariable.iShortWait);

            bool exist = ValidationBooking(driver, "BookingManager - Confirmed Booking Checking",
                ChildName);
            return exist;
        }
    }
}
