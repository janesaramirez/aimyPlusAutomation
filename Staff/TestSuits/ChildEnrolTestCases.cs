using AimyTest.Browsers;
using AimyTest.Registering_a_parent;
using AimyTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimyTest.TestSuits
{
    public class ChildEnrolTestCases : TestBase
    {
        public static readonly log4net.ILog log = Utilities.LogHelper.GetLogger();
        private IWebDriver driver = null;

        public ChildEnrolTestCases()
        {
            driver = ChromeBrowser.chromeDriver;
            ChromeBrowser.Initialize();
        }

        //[Test]
        //public void A_SampleTest() {
        //    var lib = new Child_1_Enrollment();
        //    lib.TC_CRE_CHILD_01_FillInformation(driver, dob, fname, mname, lname, Gen, schname, SiteID, true, true);
        //    lib.Edit_ChildInfo(driver, dob, fname, mname, lname, Gender, sname, stname);
        //}

        //[Test]
        //public void A_SampleTest2()
        //{
        //    var lib = new ChildEnrollment();
        //    lib.FillInformation();
           
        //}

        //[Test]
        //public void A_SampleTest3()
        //{
        //    var lib = new Child_20_Profile();
        //    lib.Add_NON_AuthorisedPickup();
        //    lib.AddAuthorisedPickup();
        //    lib.AddMedicalCondition();
        //    lib.AddNewChild();
        //}

        //[Test]
        //public void A_SampleTest4()
        //{
        //    var lib = new Child_21_AddAuthorisedPickup();
        //    lib.FillInfo();
        //    lib.TC_CRE_CHILD_03_FillAuthorisedPickUp();
        //    lib.Verify_ParentChildInfo();
        //    lib.Verify_ParentName();    
        //}

        //[Test]
        //public void A_SampleTest5()
        //{
        //    var lib = new Child_22_MedicalCondition();
        //    lib.TC_CRE_CHILD_07_MedicalCondition();
        //    lib.Verify_ParentChildInfo();
        //    lib.Verify_ParentName();
        //}

        //[Test]
        //public void A_SampleTest5a()
        //{
        //    var lib = new Child_23_NonAuthorisedPickup();
        //    lib.FillInfo();
        //    lib.TC_CRE_CHILD_05_Fill_NON_AuthorisedPickUp();
        //    lib.Verify_ParentChildInfo();
        //}

        [Test]
        public void A_REG_PARENT_01()
        {
            var lib = new RegisteringParentPage_1();

            Pages.LoginPage.LoginAimy(driver, "bing@cssteam.co.nz", "123123");
            Common.TitleValidation(driver, "Validate Aimy Home Title", "Home - aimy plus");
            //Parent Management --> http://uat.aimy.co.nz/Parent/Management
            ChromeBrowser.Goto("Parent/Management");
            Common.TitleValidation(driver, "Validate Parent Management Title", "Parent Management - aimy plus");
            
            //Register New Parent --> http://uat.aimy.co.nz/Parent/RegisterFromAdmin
            
            
            // Contact Details http://uat.aimy.co.nz/Parent/EditParentContact/30307?Wizard=False



            //lib.TC_CRE_PARENT_01_1_FillInformation();
            //lib.TC_CRE_PARENT_UI_01_1_Data_Required_Validation();
        }

        //[Test]
        //public void A_SampleTest7()
        //{
        //    var lib = new RegisteringParentPage_30_PersonalDetailPage();
        //    lib.TC_CRE_PARENT_01_3_FillParentProfile();
        //    lib.txtBillingPostCode_js();
        //    lib.txtLandline1_js();
        //    lib.chksameAddressCheckBox_js();
        //    lib.LstHowHear_js();
        //    lib.txtPostCode_js();
        //    lib.txtOfficeExtension_js();
        //    lib.txtOffice1_js();
        //    lib.txtMobile1_js();
        //    lib.txtDateOfBirth();
        //}

        //[Test]
        //public void A_SampleTest8()
        //{
        //    var lib = new RegisteringParentPage_50_ParentProfile();
        //    lib.Add1stEmergencyContact();
        //    lib.Add2ndEmergencyContact();
        //    lib.AddNewChild();
        //    lib.AddSecondParent();
        //    lib.UploadPicture();
        //}

        //[Test]
        //public void A_SampleTest9()
        //{
        //    var lib = new RegisteringParentPage_51_Add2ndParent();
        //    lib.TC_CRE_PARENT_02_FillSecondParentInfo();
        //    lib.txtHomePhone_js();
        //    lib.txtMobile_js();
        //    lib.txtWorkPhone_js();
        //}

        //[Test]
        //public void A_SampleTest10()
        //{
        //    var lib = new RegisteringParentPage_52_Add1stEmergency();
        //    lib.TC_CRE_PARENT_03_Fill_1_EmergencyContact();
        //    lib.txtHomePhone_js();
        //    lib.txtMobile_js();
        //    lib.txtWorkPhone_js();
        //}

        //[Test]
        //public void A_SampleTest11()
        //{
        //    var lib = new RegisteringParentPage_53_Add2ndEmergency();
        //    lib.TC_CRE_PARENT_04_Fill_2_EmergencyContact();
        //    lib.txtHomePhone_js();
        //    lib.txtMobile_js();
        //    lib.txtWorkPhone_js();
        //}
    }
}
