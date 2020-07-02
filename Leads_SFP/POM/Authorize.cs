using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leads_SFP.POM
{
    class Authorize
    {
        private IWebDriver _driver;
        private By _loginField;
        private By _passField;
        private By _loginButton;
        public Authorize(IWebDriver driver)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl("https://dev-eduaction-leads.herokuapp.com/");
            _loginField = By.Id("login_input");
            _passField = By.Id("password_input");
            _loginButton = By.Id("button");

        }
        public void SetLogin(string login)
        {
            _driver.FindElement(_loginField).SendKeys(login);


        }
        public void SetPass(string pass)
        {
            _driver.FindElement(_passField).SendKeys(pass);
        }
        public void ClickLogin()
        {
            _driver.FindElement(_loginButton).Click();
        }
        public NewLead Authorized(string login, string pass)
        {
            SetLogin(login);
            SetPass(pass);
            ClickLogin();
            return new NewLead(_driver);
        }
    }
}
