using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leads_SFP.POM
{
    class NewLead
    {
        private IWebDriver _driver;
        private By _name;
        private By _course;
        private By _login;
        private By _mail;
        private By _password;
        private By _number;
        private By _birthday;
        private By _status;
       // private By _statusId;
        private By _addBtn;
        private By _lastLead;
       

        public NewLead(IWebDriver driver)
        {
            _driver = driver;

            _name     = By.Id("leads_page_name_input");
            _course   = By.Id("leads_page_course_input");
            _login    = By.Id("leads_page_login_input");
            _mail     = By.Id("leads_page_mail_input");
            _password = By.Id("leads_page_password_input");
            _number   = By.Id("leads_page_phone_input");
            _birthday = By.Id("leads_page_date_input");
            _status   = By.Id("dropDown");
           // _statusId = By.Id("student");
            _addBtn   = By.Id("add_button");
            _lastLead = By.XPath("//*[text()='New User']");  //заменить

        }

        public void SetNameField(string name)
        {
            _driver.FindElement(_name).SendKeys(name);
        }
        public void SetCourseField(string course)
        {
            _driver.FindElement(_course).SendKeys(course);
        }
        public void SetLoginField(string login)
        {
            _driver.FindElement(_login).SendKeys(login);
        }
        public void SetMailField(string mail)
        {
            _driver.FindElement(_mail).SendKeys(mail);
        }
        public void SetPassField(string pass)
        {
            _driver.FindElement(_password).SendKeys(pass);
        }
        public void SetNumberField(string num)
        {
            _driver.FindElement(_number).SendKeys(num);
        }
        public void SetBirthdField(string birthd)
        {
            _driver.FindElement(_birthday).SendKeys(birthd);
        }
        public void SetStatusField(string status)
        {
            _driver.FindElement(_status).SendKeys(status);
        }
        public void CreateNewLeadClick()
        {
            _driver.FindElement(_addBtn).Click();
        }
        public void SelectLastLeadClick()
        {
            _driver.FindElement(_lastLead).Click();
        }
        public string[] GetSendingData()
        {
            string[] actual = new string[7];
            actual[0] = _driver.FindElement(_name).Text;
            actual[1] = _driver.FindElement(_course).Text;
            actual[2] = _driver.FindElement(_login).Text;
            actual[3] = _driver.FindElement(_mail).Text;
            actual[4] = _driver.FindElement(_number).Text;
            actual[5] = _driver.FindElement(_birthday).Text;
            actual[6] = _driver.FindElement(_status).Text;
            return actual;
        }
       // public void SetNameField(string name)
       // {
       //     _driver.FindElement(_name).SendKeys(name);
       // }
       // public void SetNameField(string name)
       // {
       //     _driver.FindElement(_name).SendKeys(name);
       // }
    }
}
