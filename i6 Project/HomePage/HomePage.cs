using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace i6_Project.HomePage
{
    
     
      public  class HomePage
      {

             
             public HomePage(IWebDriver webDriver)
             {
                Driver = webDriver;
             }

             public IWebDriver Driver { get; }

             public IWebElement lnkAccept => Driver.FindElement(By.LinkText("Accept"));


            public void ClickAccept() => lnkAccept.Click();

            public IWebElement lnkContact => Driver.FindElement(By.XPath("/html/body/div[16]/div[1]/div/nav/a[3]"));


            public void ClickContact() => lnkContact.Click();



        



      }
}
