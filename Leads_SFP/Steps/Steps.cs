using Leads_SFP.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Leads_SFP.Steps
{
    [Binding]
    class Steps
    {
        Authorize authorize;
        NewLead newLead;

        [Given(@"Open authorize page")]
        public void GivenOpenAuthorizePage()
        {
            authorize = new Authorize((IWebDriver)FeatureContext.Current["driver"]);
        }

        [Given(@"User authorized")]
        public void GivenUserAuthorized(Table table)
        {
            newLead = authorize.Authorized(table.Rows[0]["Login"], table.Rows[0]["Password"]);
        }

       // [When(@"I press button LogIn")]
       // public void WhenIPressButtonLogIn()
       // {
       //     ScenarioContext.Current.Pending();
       // }

        [When(@"I enter (.*)  in FullName field, (.*) in Course field, (.*) in login field, (.*) in email field, (.*) in password field, (.*) in PhoneNumber  field, (.*) in Birthday field, (.*) in Status field")]
        public void WhenIEnterInFullNameFieldInCourseFieldInLoginFieldInEmailFieldInPasswordFieldInPhoneNumberFieldInBirthdayFieldInStatusField(string name, string course, string login, string mail, string pass, string num, string birthd, string status)
        {
            newLead.SetNameField(name);
            newLead.SetCourseField(course);
            newLead.SetLoginField(login);
            newLead.SetMailField(mail);
            newLead.SetPassField(pass);
            newLead.SetNumberField(num);
            newLead.SetBirthdField(birthd);
            newLead.SetStatusField(status);
        }

        [When(@"I press ADD Button")]
        public void WhenIPressADDButton()
        {
            newLead.CreateNewLeadClick();
        }

        [When(@"I press last lead")]
        public void WhenIPressLastLead()
        {
            newLead.SelectLastLeadClick();
        }
     
        

        [Then(@"Name with (.*) in field, Course with (.*) in field, Login with (.*) in field, eMail with (.*) in field, Number with (.*) in PhoneNumber  field, Birthday with (.*) in field, Status with (.*) in field")]
        public void ThenNameWithInFieldCourseWithInFieldLoginWithInFieldEMailWithInFieldNumberWithInPhoneNumberFieldBirthdayWithInFieldStatusWithInField(string p0, string p1, string p2, string p3, string p4, string p5, string p6)
        {
            string[] actual = newLead.GetSendingData();
            string[] expect = { p0, p1, p2, p3, p4, p5, p6 };
            Assert.AreEqual(expect, actual);
        } 
     

        

    }
}
