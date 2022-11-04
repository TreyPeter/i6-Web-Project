using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace i6_Project.HomePage
{
    class ContactUS
    {
        private object lnkContact;

        public ContactUS(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebDriver webDriver { get; }

        IWebElement FirstNameTextField => webDriver.FindElement(By.LinkText("First Name"));

        IWebElement LastNameTextField => webDriver.FindElement(By.LinkText("Last Name"));

        IWebElement CompanyTextField => webDriver.FindElement(By.LinkText("Company"));

        IWebElement PhoneNumberTextField => webDriver.FindElement(By.LinkText("Phone Number"));

        IWebElement EnquiryTypeTextField => webDriver.FindElement(By.LinkText("Enquiry Type"));

        IWebElement MessageTextField => webDriver.FindElement(By.LinkText("Message"));

        IWebElement EmailOptinBox => webDriver.FindElement(By.LinkText("Email Opt-in"));

        IWebElement Submitbtn => webDriver.FindElement(By.LinkText("Submit Now"));
    }
   
}
