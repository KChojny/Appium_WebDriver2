using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace Chojnowski_Appium_WebDriver_
{
    [TestClass]
    public class UnitTest1
    {
        AndroidDriver<AppiumWebElement> driver;


        [TestInitialize]
        public void BeforeTest()
        {
            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "11");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");

            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
        }

        [TestMethod] //Draw
        public void TestMethod1()
        {
            NewGame();

            IWebElement el2 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button5");
            el2.Click();
            IWebElement el3 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button1");
            el3.Click();
            IWebElement el4 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button2");
            el4.Click();
            IWebElement el5 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button8");
            el5.Click();
            IWebElement el6 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button6");
            el6.Click();
            IWebElement el7 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button4");
            el7.Click();
            IWebElement el8 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button7");
            el8.Click();
            IWebElement el9 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button3");
            el9.Click();
            IWebElement el10 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button9");
            el10.Click();

            string result = Result();
            string expected = "Draw";
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // O player won
        public void TestMethod2()
        {
            NewGame();

            IWebElement el2 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button1");
            el2.Click();
            IWebElement el3 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button5");
            el3.Click();
            IWebElement el4 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button9");
            el4.Click();
            IWebElement el5 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button3");
            el5.Click();
            IWebElement el6 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button7");
            el6.Click();
            IWebElement el7 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button8");
            el7.Click();
            IWebElement el8 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button4");
            el8.Click();

            string result = Result();
            string expected = "O";
            Assert.AreEqual(expected, result);
        }

        [TestMethod] // X player won
        public void TestMethod3()
        {
            NewGame();

            IWebElement el1 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button10");
            el1.Click();
            IWebElement el2 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button5");
            el2.Click();
            IWebElement el3 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button7");
            el3.Click();
            IWebElement el4 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button9");
            el4.Click();
            IWebElement el5 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button1");
            el5.Click();
            IWebElement el6 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button3");
            el6.Click();
            IWebElement el7 = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button4");
            el7.Click();


            string result = Result();
            string expected = "X";
            Assert.AreEqual(expected, result);
        }

        private void NewGame()
        {
            IWebElement newGame = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/button10");
            newGame.Click();
        }

        private string Result()
        {
            IWebElement element = (IWebElement)driver.FindElementById("com.companyname.chojnowski_tic_tac_toe:id/textView1");
            string str = element.Text;
            string[] strs = str.Split(' ', '!');
            return strs[0];
        }
    }
}