using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;

namespace i6_Project
{
    public class Tests 
    {
        WebDriver webDriver = new ChromeDriver(@"C:\Users\DELL\Downloads\Driver");

        IWebDriver WebDriver;

        [SetUp]
        public void Setup()
        {
            // Start browser
            webDriver.Navigate().GoToUrl("https://i6.io/");

            // Maximize browser
            webDriver.Manage().Window.Maximize();

        }

        [Test]
        public void Test()
        {
            // Start browser
            webDriver.Navigate().GoToUrl("https://i6.io/");

            // Maximize browser
            webDriver.Manage().Window.Maximize();

            //wait for 2 seconds
            Task.Delay(2000).Wait();

            var lnkAccept = webDriver.FindElement(By.LinkText("Accept"));

            //Click Operation Accpet Cookies policy 
            webDriver.FindElement(By.LinkText("Accept")).Click();
                                   

            //wait for 2 seconds
            Task.Delay(2000).Wait();


            //click operation 
            webDriver.FindElement(By.XPath("/html/body/div[16]/div[1]/div/nav/a[3]")).Click();

            Task.Delay(2000).Wait();

            //Enter data to First Name field
            webDriver.FindElement(By.XPath("//*[@id='First-Name']")).SendKeys("Test");

            Task.Delay(2000).Wait();

            //Enter data to Last Name field
            webDriver.FindElement(By.XPath("//*[@id='Last-Name']")).SendKeys("Quality");

            Task.Delay(2000).Wait();

            //Leave Blank data to Company field
            webDriver.FindElement(By.XPath("//*[@id='Company-2']")).SendKeys("");

            Task.Delay(2000).Wait();

            //Enter data to email field
            webDriver.FindElement(By.XPath("//*[@id='Email']")).SendKeys("aaaa88888");

            Task.Delay(2000).Wait();

            //leave blank data on phone Number field
            webDriver.FindElement(By.XPath("//*[@id='Number-2']")).SendKeys("");

            Task.Delay(2000).Wait();

            //Select operation from Enquiry tab select Careers
            webDriver.FindElement(By.XPath("//*[@id='Enquiry-2']/option[8]")).Click();

            Task.Delay(2000).Wait();

            //Scroll Operation scroll down to message field
            var scrollOrigin = new WheelInputDevice.ScrollOrigin
            {
                Viewport = true,
                XOffset = 200,
                YOffset = 10
            };
            new Actions(webDriver)
                .ScrollFromOrigin(scrollOrigin, 0, 500)
                .Perform();

            Task.Delay(2000).Wait();

            //Leave Blank data on Message  field
            webDriver.FindElement(By.XPath("//*[@id='Message-2']")).SendKeys("");

            Task.Delay(2000).Wait();

            //Click Operation Optin for future contacts 
            webDriver.FindElement(By.XPath("//*[@id='Subscribe-to-Email']")).Click();

            Task.Delay(2000).Wait();

            //Submit Operation

            webDriver.FindElement(By.XPath("//*[@id='email-form']/input")).Click();

            Task.Delay(2000).Wait();

            //Scroll Operation Scroll page up
            scrollOrigin = new WheelInputDevice.ScrollOrigin
            {
                Viewport = true,
                XOffset = 200,
                YOffset = 10
            };
            new Actions(webDriver)
                .ScrollFromOrigin(scrollOrigin, 0, -500)
                .Perform();
        }


        //Close Browser

        [OneTimeTearDown]
        public void Close()
        {
            Task.Delay(2000).Wait();

            webDriver.Close();
        }







    }

    
}
