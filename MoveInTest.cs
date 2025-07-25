using AutoIt;
using AutoItX3Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace REA
{
    [TestClass]
    public class Move_In

    {

        readonly IWebDriver driver = new ChromeDriver();

        [NUnit.Framework.SetUp]
        public void Setup()
        {
            //IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
        }

        [NUnit.Framework.TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [TestMethod]
        public void ClearCookiess()
        {

            driver.Manage().Cookies.DeleteAllCookies();


        }

        [TestMethod]
        public void EngineerMovein()//Engineer proceeding move in after assigning
        {
           // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("jimson.mathew@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);
            //driver.FindElement(By.XPath("//li[@ng-reflect-router-link='/Move-In_Move-Out']//a[1]")).Click();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Move-In/List");       
            //driver.FindElement(By.LinkText("Add New Request")).Click();
            System.Threading.Thread.Sleep(3000);
           // driver.FindElement(By.XPath("//a[contains(@class,'btn-default btn-primary')]")).Click();
          //  System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Move-In/Request/1465/0");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='ng-star-inserted']")).Click();//edit
            System.Threading.Thread.Sleep(2000);
         /*   var AssignedTo = driver.FindElement(By.XPath("//select[@formcontrolname='AssignTo']"));
            var AssignedToselectElement = new SelectElement(AssignedTo);
            AssignedToselectElement.SelectByValue("rafeek.mh@asico.ae");*/
              driver.FindElement(By.XPath("//button[@class='btn-tertiary btn-custom-style-remove']")).Click();
            System.Threading.Thread.Sleep(1000);

            var KeyOne = driver.FindElement(By.XPath("//select[@formcontrolname='KeyListId']"));
            var KeyOneselectElement = new SelectElement(KeyOne);
            KeyOneselectElement.SelectByValue("5");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[contains(@class,'form-control key-count-input')]")).SendKeys("1");

            driver.FindElement(By.XPath("//button[@class='btn-tertiary btn-custom-style-remove']")).Click();//add key
            System.Threading.Thread.Sleep(1000);

            var KeyTwo = driver.FindElement(By.XPath("(//select[@formcontrolname='KeyListId'])[2]"));
            var KeyTwoselectElement = new SelectElement(KeyTwo);
            KeyTwoselectElement.SelectByValue("6");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//input[contains(@class,'form-control key-count-input')])[2]")).SendKeys("2");



         /*   var KeyThree = driver.FindElement(By.XPath("(//select[@formcontrolname='KeyListId'])[3]"));
            var KeyThreeselectElement = new SelectElement(KeyThree);
            KeyThreeselectElement.SelectByValue("6");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//input[@formcontrolname='KeyCount'])[3]")).SendKeys("3");
            System.Threading.Thread.Sleep(1000);*/
            
            driver.FindElement(By.XPath("//input[@formcontrolname='DewaNo']")).SendKeys("13464");

           


            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button
            System.Threading.Thread.Sleep(1000);



            var AreaOne = driver.FindElement(By.XPath("//select[@formcontrolname='AreaId']"));
            var AreaOneselectElement = new SelectElement(AreaOne);
            AreaOneselectElement.SelectByValue("1");

            var CategoryOne = driver.FindElement(By.XPath("//select[@formcontrolname='Category']"));
            var CategoryOneselectElement = new SelectElement(CategoryOne);
            CategoryOneselectElement.SelectByValue("9");

            var ItemDescOne = driver.FindElement(By.XPath("//select[@formcontrolname='ItemId']"));
            var ItemDescOneselectElement = new SelectElement(ItemDescOne);
            ItemDescOneselectElement.SelectByValue("1");
            System.Threading.Thread.Sleep(1000);


            var conditionOne = driver.FindElement(By.XPath("//select[@formcontrolname='Condition']"));
            var conditionOneselectElement = new SelectElement(conditionOne);
            conditionOneselectElement.SelectByValue("Damaged");


            var ActionRequiredOne = driver.FindElement(By.XPath("//select[@formcontrolname='ActionRequired']"));
            var ActionRequiredOneselectElement = new SelectElement(ActionRequiredOne);
            ActionRequiredOneselectElement.SelectByValue("NoAction");

            //Start

            System.Threading.Thread.Sleep(1000);
            // driver.FindElement(By.XPath("(//button[@ng-reflect-ng-class='[object Object]'])[3]")).Click(); //value no dropdown
            driver.FindElement(By.XPath("//td[@class='photo-wrapper']//button[1]")).Click();
            //button[@ng-reflect-ng-class='[object Object]'])[3]
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX3 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX7 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"IMG-20240510-WA0003.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//td[@class='photo-wrapper']//button[1]")).Click();//to check
           
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX8 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX9 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"IMG-20240510-WA0004.jpg");
            System.Threading.Thread.Sleep(1000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();
            // driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button

            //driver.FindElement(By.XPath("//input[@formcontrolname='DewaNo']")).SendKeys("1");
            //input[@formcontrolname='DewaNo']

            //End
            driver.FindElement(By.XPath("//td[@class='photo-wrapper']//button[1]")).Click();//to check

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX15 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX16 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
            System.Threading.Thread.Sleep(1000);
            autoItX3.Send("{ENTER}");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            // System.Threading.Thread.Sleep(1000);//next
            driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button

            var ItemDescTwo = driver.FindElement(By.XPath("(//select[@formcontrolname='ItemId'])[2]"));
            var ItemDescTwoselectElement = new SelectElement(ItemDescTwo);
            ItemDescTwoselectElement.SelectByValue("2");
            System.Threading.Thread.Sleep(1000);

            var AreaTwo = driver.FindElement(By.XPath("(//select[@formcontrolname='AreaId'])[2]"));
            var AreaTwoselectElement = new SelectElement(AreaTwo);
            AreaTwoselectElement.SelectByValue("2");

            var CategoryTwo = driver.FindElement(By.XPath("(//select[@formcontrolname='Category'])[2]"));
            var CategoryTwoselectElement = new SelectElement(CategoryTwo);
            CategoryTwoselectElement.SelectByValue("9");


            var conditionTwo = driver.FindElement(By.XPath("(//select[@formcontrolname='Condition'])[2]"));
            var conditionTwoselectElement = new SelectElement(conditionTwo);
            conditionTwoselectElement.SelectByValue("Damaged");


            var ActionRequiredTwo = driver.FindElement(By.XPath("(//select[@formcontrolname='ActionRequired'])[2]"));
            var ActionRequiredTwoselectElement = new SelectElement(ActionRequiredTwo);
            ActionRequiredTwoselectElement.SelectByValue("NoAction");

            //Start

            System.Threading.Thread.Sleep(1000);
            // driver.FindElement(By.XPath("(//button[@ng-reflect-ng-class='[object Object]'])[3]")).Click(); //value no dropdown
            driver.FindElement(By.XPath("(//button[@class='btn-upload-snag-image']//img)[2]")).Click();
            //button[@ng-reflect-ng-class='[object Object]'])[3]
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX10 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX11 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"pexels-azizico-27137595.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("(//button[@class='btn-upload-snag-image']//img)[2]")).Click();//to check

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX12 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX13 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"Salary-Certificate.jpg");
            System.Threading.Thread.Sleep(1000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();
            // driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button

            //driver.FindElement(By.XPath("//input[@formcontrolname='DewaNo']")).SendKeys("1");
            //input[@formcontrolname='DewaNo']

            //End
            System.Threading.Thread.Sleep(1000);            
            driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button

            var ItemDescThree = driver.FindElement(By.XPath("(//select[@formcontrolname='ItemId'])[3]"));
            var ItemDescThreeselectElement = new SelectElement(ItemDescThree);
            ItemDescThreeselectElement.SelectByValue("2");
            System.Threading.Thread.Sleep(1000);

            var AreaThree = driver.FindElement(By.XPath("(//select[@formcontrolname='AreaId'])[3]"));
            var AreaThreeselectElement = new SelectElement(AreaThree);
            AreaThreeselectElement.SelectByValue("3");

            var CategoryThree = driver.FindElement(By.XPath("(//select[@formcontrolname='Category'])[3]"));
            var CategoryThreeselectElement = new SelectElement(CategoryThree);
            CategoryThreeselectElement.SelectByValue("10");

            var conditionThree = driver.FindElement(By.XPath("(//select[@formcontrolname='Condition'])[3]"));
            var conditionThreeselectElement = new SelectElement(conditionThree);
            conditionThreeselectElement.SelectByValue("Good");


            var ActionRequiredThree = driver.FindElement(By.XPath("(//select[@formcontrolname='ActionRequired'])[3]"));
            var ActionRequiredThreeselectElement = new SelectElement(ActionRequiredThree);
            ActionRequiredThreeselectElement.SelectByValue("NoAction");
            //
            
                        //Start

                        System.Threading.Thread.Sleep(1000);
                        // driver.FindElement(By.XPath("(//button[@ng-reflect-ng-class='[object Object]'])[3]")).Click(); //value no dropdown
                        driver.FindElement(By.XPath("(//button[@class='btn-upload-snag-image']//img)[3]")).Click();
                        //button[@ng-reflect-ng-class='[object Object]'])[3]
                        System.Threading.Thread.Sleep(2000);
                        driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();
                        System.Threading.Thread.Sleep(1000);
                        driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
                        System.Threading.Thread.Sleep(2000);
                        AutoItX3 autoItX17 = new AutoItX3();
                        autoItX3.WinActivate("File Upload");
                        System.Threading.Thread.Sleep(1000);
                        //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
                        System.Threading.Thread.Sleep(2000);
                        AutoItX3 autoItX18 = new AutoItX3();
                        autoItX3.WinActivate("File Upload");

                        autoItX3.Send(@"IMG-20240510-WA0010.jpg");
                        System.Threading.Thread.Sleep(2000);
                        autoItX3.Send("{ENTER}");
                        System.Threading.Thread.Sleep(1000);
                        driver.FindElement(By.XPath("//button[text()='Save']")).Click();

                        System.Threading.Thread.Sleep(1000);

                        driver.FindElement(By.XPath("(//button[@class='btn-upload-snag-image']//img)[3]")).Click();//to check

                        System.Threading.Thread.Sleep(1000);
                        driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();
                        System.Threading.Thread.Sleep(1000);
                        driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
                        System.Threading.Thread.Sleep(2000);
                        AutoItX3 autoItX19 = new AutoItX3();
                        autoItX3.WinActivate("File Upload");
                        System.Threading.Thread.Sleep(1000);
                        //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
                        System.Threading.Thread.Sleep(2000);
                        AutoItX3 autoItX20 = new AutoItX3();
                        autoItX3.WinActivate("File Upload");

                        autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
                        System.Threading.Thread.Sleep(1000);
                        autoItX3.Send("{ENTER}");
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();
                        // driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button

                        //driver.FindElement(By.XPath("//input[@formcontrolname='DewaNo']")).SendKeys("1");
                        //input[@formcontrolname='DewaNo']

                        //End
                        driver.FindElement(By.XPath("(//button[@class='btn-upload-snag-image']//img)[3]")).Click();//to check

                        System.Threading.Thread.Sleep(1000);
                        driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();
                        System.Threading.Thread.Sleep(1000);
                        driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
                        System.Threading.Thread.Sleep(2000);
                        AutoItX3 autoItX21 = new AutoItX3();
                        autoItX3.WinActivate("File Upload");
                        System.Threading.Thread.Sleep(1000);
                        //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
                        System.Threading.Thread.Sleep(2000);
                        AutoItX3 autoItX22 = new AutoItX3();
                        autoItX3.WinActivate("File Upload");

                        autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
                        System.Threading.Thread.Sleep(1000);
                        autoItX3.Send("{ENTER}");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            driver.FindElement(By.XPath("//button[@class='btn-upload-snag-image']//img")).Click();//to check

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX23 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX24 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            autoItX3.Send("{ENTER}");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            // System.Threading.Thread.Sleep(1000);//next
            // driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button


            //remarks
            driver.FindElement(By.XPath("//button[@class='button-add-remarks']//img")).Click();
            driver.FindElement(By.XPath("//textarea[@formcontrolname='Remarks']")).SendKeys("dhfgsdhghsdhgghsdghsdh gdsg sdg dgsdg");
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            driver.FindElement(By.XPath("(//button[@class='button-add-remarks']//img)[2]")).Click();
            driver.FindElement(By.XPath("//textarea[@formcontrolname='Remarks']")).SendKeys("234ryeryreyyery ter gdsg sdg dgsdg");
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            driver.FindElement(By.XPath("(//button[@title='Remarks'])[3]")).Click();
            driver.FindElement(By.XPath("//textarea[@formcontrolname='Remarks']")).SendKeys("88hghgheyyery ter gdsg sdg dgsdg");
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();
            //button[@class='btn-default btn-primary']
            //  driver.FindElement(By.XPath("//button[@ng-reflect-ng-class='[object Object]']")).Click();//Add item*/
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[text()='   Add Photos ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX4 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX27 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"pexels-zhangkaiyv-1138369.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[text()='   Add Photos ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX5 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX26 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"pexels-zhangkaiyv-1138369.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[text()='   Add Photos ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX30 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX28 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[text()='   Add Photos ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX31 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX29 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[text()='   Add Photos ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX32 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX33 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[text()='   Add Photos ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX34 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX35 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[text()='   Add Photos ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX36 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX37 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[text()='   Add Photos ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX38 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX39 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[text()='   Add Photos ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX40 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX41 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//button[text()='   Add Photos ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[contains(.,'Drag your file(s) or Browse')]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX42 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX43 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"BlackMarble_2016_928m_india_labeled.png");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();

        }
        [TestMethod]
        public void SupervisorAssigningEngineer()
        {


            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("jimson.mathew@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Move-In_Move-Out/Request/10063/0");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='ng-star-inserted']")).Click();//edit
            System.Threading.Thread.Sleep(2000);
            var AssignedTo = driver.FindElement(By.XPath("//select[@formcontrolname='AssignTo']"));
            var AssignedToselectElement = new SelectElement(AssignedTo);
            AssignedToselectElement.SelectByValue("rafeek.mh@asico.ae");





        }

        [TestMethod]
        public void SupervisorSelfMoveIn()
        {


            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("jimson.mathew@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Move-In_Move-Out/Request/10108/0");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='ng-star-inserted']")).Click();//edit
            System.Threading.Thread.Sleep(2000);
            /*   var AssignedTo = driver.FindElement(By.XPath("//select[@formcontrolname='AssignTo']"));
               var AssignedToselectElement = new SelectElement(AssignedTo);
               AssignedToselectElement.SelectByValue("rafeek.mh@asico.ae");*/
            driver.FindElement(By.XPath("//button[@class='btn-tertiary btn-custom-style-remove']")).Click();//add key
            System.Threading.Thread.Sleep(1000);

            var KeyOne = driver.FindElement(By.XPath("//select[@ng-reflect-name='KeyListId']"));
            var KeyOneselectElement = new SelectElement(KeyOne);
            KeyOneselectElement.SelectByValue("3");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[contains(@class,'form-control key-count-input')]")).SendKeys("1");

            driver.FindElement(By.XPath("//button[@class='btn-tertiary btn-custom-style-remove']")).Click();//add key
            System.Threading.Thread.Sleep(1000);

            var KeyTwo = driver.FindElement(By.XPath("(//select[@ng-reflect-name='KeyListId'])[2]"));
            var KeyTwoselectElement = new SelectElement(KeyTwo);
            KeyTwoselectElement.SelectByValue("9");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//input[contains(@class,'form-control key-count-input')])[2]")).SendKeys("2");

            driver.FindElement(By.XPath("//button[@class='btn-tertiary btn-custom-style-remove']")).Click();//add key
            System.Threading.Thread.Sleep(1000);

            var KeyThree = driver.FindElement(By.XPath("(//select[@ng-reflect-name='KeyListId'])[3]"));
            var KeyThreeselectElement = new SelectElement(KeyThree);
            KeyThreeselectElement.SelectByValue("10");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//input[@formcontrolname='KeyCount'])[3]")).SendKeys("3");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//input[@formcontrolname='DewaNo']")).SendKeys("13464");
            driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button

            var ItemDescone = driver.FindElement(By.XPath("//select[@ng-reflect-name='ItemId']"));
            var ItemDesconeselectElement = new SelectElement(ItemDescone);
            ItemDesconeselectElement.SelectByValue("1");
            System.Threading.Thread.Sleep(1000);

            var AreaOne = driver.FindElement(By.XPath("//select[@ng-reflect-name='AreaId']"));
            var AreaOneselectElement = new SelectElement(AreaOne);
            AreaOneselectElement.SelectByValue("1");

            var conditionOne = driver.FindElement(By.XPath("//select[@ng-reflect-name='Condition']"));
            var conditionOneselectElement = new SelectElement(conditionOne);
            conditionOneselectElement.SelectByValue("Good");


            var ActionRequiredOne = driver.FindElement(By.XPath("//select[@ng-reflect-name='ActionRequired']"));
            var ActionRequiredOneselectElement = new SelectElement(ActionRequiredOne);
            ActionRequiredOneselectElement.SelectByValue("Replace");



            driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button

            var ItemDescTwo = driver.FindElement(By.XPath("(//select[@formcontrolname='ItemId'])[2]"));
            var ItemDescTwoselectElement = new SelectElement(ItemDescTwo);
            ItemDescTwoselectElement.SelectByValue("2");
            System.Threading.Thread.Sleep(1000);

            var AreaTwo = driver.FindElement(By.XPath("(//select[@formcontrolname='AreaId'])[2]"));
            var AreaTwoselectElement = new SelectElement(AreaTwo);
            AreaTwoselectElement.SelectByValue("1");

            var conditionTwo = driver.FindElement(By.XPath("(//select[@ng-reflect-name='Condition'])[2]"));
            var conditionTwoselectElement = new SelectElement(conditionTwo);
            conditionTwoselectElement.SelectByValue("Good");


            var ActionRequiredTwo = driver.FindElement(By.XPath("(//select[@ng-reflect-name='ActionRequired'])[2]"));
            var ActionRequiredTwoselectElement = new SelectElement(ActionRequiredTwo);
            ActionRequiredTwoselectElement.SelectByValue("NoAction");

            driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button

            var ItemDescThree = driver.FindElement(By.XPath("(//select[@formcontrolname='ItemId'])[3]"));
            var ItemDescThreeselectElement = new SelectElement(ItemDescThree);
            ItemDescThreeselectElement.SelectByValue("2");
            System.Threading.Thread.Sleep(1000);

            var AreaThree = driver.FindElement(By.XPath("(//select[@formcontrolname='AreaId'])[3]"));
            var AreaThreeselectElement = new SelectElement(AreaThree);
            AreaThreeselectElement.SelectByValue("1");

            var conditionThree = driver.FindElement(By.XPath("(//select[@ng-reflect-name='Condition'])[3]"));
            var conditionThreeselectElement = new SelectElement(conditionThree);
            conditionThreeselectElement.SelectByValue("Good");


            var ActionRequiredThree = driver.FindElement(By.XPath("(//select[@ng-reflect-name='ActionRequired'])[3]"));
            var ActionRequiredThreeselectElement = new SelectElement(ActionRequiredThree);
            ActionRequiredThreeselectElement.SelectByValue("NoAction");

            driver.FindElement(By.XPath(" //tr[@ng-reflect-name='0']//button")).Click();
            driver.FindElement(By.XPath("//textarea[@formcontrolname='Remarks']")).SendKeys("dhfgsdhghsdhgghsdghsdh gdsg sdg dgsdg");
            driver.FindElement(By.XPath("//button[@class='btn-default btn-primary']")).Click();

            driver.FindElement(By.XPath(" //tr[@ng-reflect-name='1']//button")).Click();
            driver.FindElement(By.XPath("//textarea[@formcontrolname='Remarks']")).SendKeys("234ryeryreyyery ter gdsg sdg dgsdg");
            driver.FindElement(By.XPath("//button[@class='btn-default btn-primary']")).Click();

            driver.FindElement(By.XPath(" //tr[@ng-reflect-name='2']//button")).Click();
            driver.FindElement(By.XPath("//textarea[@formcontrolname='Remarks']")).SendKeys("88hghgheyyery ter gdsg sdg dgsdg");
            driver.FindElement(By.XPath("//button[@class='btn-default btn-primary']")).Click();
            /* var AssignedTo = driver.FindElement(By.XPath("//select[@formcontrolname='AssignTo']"));
             var AssignedToselectElement = new SelectElement(AssignedTo);
             AssignedToselectElement.SelectByValue("rafeek.mh@asico.ae");*/





        }

        [TestMethod]
        public void CordinatorAssigningEngineer()
        {


            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("facilitycord@softspace.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Move-In_Move-Out/Request/10121/0");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='ng-star-inserted']")).Click();//edit
            System.Threading.Thread.Sleep(2000);
            var AssignedTo = driver.FindElement(By.XPath("//select[@formcontrolname='AssignTo']"));
            var AssignedToselectElement = new SelectElement(AssignedTo);
            AssignedToselectElement.SelectByValue("rafeek.mh@asico.ae");

       

        }

        [TestMethod]
        public void MoveInPendingBooking()  //Mae
        {


            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("mae.salvador@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Booking");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[contains(@class,'btn-filter mr-10')]")).Click();//filter
            System.Threading.Thread.Sleep(1000);
           // driver.FindElement(By.XPath("//span[contains(@class,'mat-mdc-select-min-line ng-tns-c3393473648-52')]")).Click();
            
          /*  var AssignedTo = driver.FindElement(By.XPath("//span[contains(@class,'mat-mdc-select-min-line ng-tns-c3393473648-52')]"));
            var AssignedToselectElement = new SelectElement(AssignedTo);
            AssignedToselectElement.SelectByValue("rafeek.mh@asico.ae");*/



        }

        [TestMethod] //Unit edit
        public void UnitEdit()
        {


            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Units/Edit/1/144");




        }

        [TestMethod]
        public void EngineerMoveinSecondTab()//Engineer proceeding move in after assigning second tab
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("rafeek.mh@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//mat-sidenav[@id='sidenav']/div[1]/div[2]/mat-list[1]/mat-list-item[4]")).Click();
            //driver.FindElement(By.LinkText("Add New Request")).Click();
            System.Threading.Thread.Sleep(3000);
            // driver.FindElement(By.XPath("//a[contains(@class,'btn-default btn-primary')]")).Click();
            //  System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Move-In_Move-Out/Request/10121/0");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='ng-star-inserted']")).Click();//edit
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='P205 ']")).Click();
            System.Threading.Thread.Sleep(2000);
            /*   var AssignedTo = driver.FindElement(By.XPath("//select[@formcontrolname='AssignTo']"));
               var AssignedToselectElement = new SelectElement(AssignedTo);
               AssignedToselectElement.SelectByValue("rafeek.mh@asico.ae");*/
            driver.FindElement(By.XPath("//button[@class='btn-tertiary btn-custom-style-remove']")).Click();//add key
            System.Threading.Thread.Sleep(1000);

            var KeyOne = driver.FindElement(By.XPath("//select[@ng-reflect-name='KeyListId']"));
            var KeyOneselectElement = new SelectElement(KeyOne);
            KeyOneselectElement.SelectByValue("3");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[contains(@class,'form-control key-count-input')]")).SendKeys("1");

            driver.FindElement(By.XPath("//button[@class='btn-tertiary btn-custom-style-remove']")).Click();//add key
            System.Threading.Thread.Sleep(1000);

            var KeyTwo = driver.FindElement(By.XPath("(//select[@ng-reflect-name='KeyListId'])[2]"));
            var KeyTwoselectElement = new SelectElement(KeyTwo);
            KeyTwoselectElement.SelectByValue("9");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//input[contains(@class,'form-control key-count-input')])[2]")).SendKeys("2");

            driver.FindElement(By.XPath("//button[@class='btn-tertiary btn-custom-style-remove']")).Click();//add key
            System.Threading.Thread.Sleep(1000);

            var KeyThree = driver.FindElement(By.XPath("(//select[@ng-reflect-name='KeyListId'])[3]"));
            var KeyThreeselectElement = new SelectElement(KeyThree);
            KeyThreeselectElement.SelectByValue("10");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//input[@formcontrolname='KeyCount'])[3]")).SendKeys("3");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//input[@formcontrolname='DewaNo']")).SendKeys("13464");
            driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button

            var ItemDescone = driver.FindElement(By.XPath("//select[@ng-reflect-name='ItemId']"));
            var ItemDesconeselectElement = new SelectElement(ItemDescone);
            ItemDesconeselectElement.SelectByValue("1");
            System.Threading.Thread.Sleep(1000);

            var AreaOne = driver.FindElement(By.XPath("//select[@ng-reflect-name='AreaId']"));
            var AreaOneselectElement = new SelectElement(AreaOne);
            AreaOneselectElement.SelectByValue("1");

            var CategoryOne = driver.FindElement(By.XPath("//select[@ng-reflect-name='Category']"));
            var CategoryOneselectElement = new SelectElement(CategoryOne);
            CategoryOneselectElement.SelectByValue("8");

            var conditionOne = driver.FindElement(By.XPath("//select[@ng-reflect-name='Condition']"));
            var conditionOneselectElement = new SelectElement(conditionOne);
            conditionOneselectElement.SelectByValue("Good");


            var ActionRequiredOne = driver.FindElement(By.XPath("//select[@ng-reflect-name='ActionRequired']"));
            var ActionRequiredOneselectElement = new SelectElement(ActionRequiredOne);
            ActionRequiredOneselectElement.SelectByValue("Replace");



            driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button

            var ItemDescTwo = driver.FindElement(By.XPath("(//select[@formcontrolname='ItemId'])[2]"));
            var ItemDescTwoselectElement = new SelectElement(ItemDescTwo);
            ItemDescTwoselectElement.SelectByValue("2");
            System.Threading.Thread.Sleep(1000);

            var AreaTwo = driver.FindElement(By.XPath("(//select[@formcontrolname='AreaId'])[2]"));
            var AreaTwoselectElement = new SelectElement(AreaTwo);
            AreaTwoselectElement.SelectByValue("2");

            var CategoryTwo = driver.FindElement(By.XPath("(//select[@ng-reflect-name='Category'])[2]"));
            var CategoryTwoselectElement = new SelectElement(CategoryTwo);
            CategoryTwoselectElement.SelectByValue("9");


            var conditionTwo = driver.FindElement(By.XPath("(//select[@ng-reflect-name='Condition'])[2]"));
            var conditionTwoselectElement = new SelectElement(conditionTwo);
            conditionTwoselectElement.SelectByValue("Damaged");


            var ActionRequiredTwo = driver.FindElement(By.XPath("(//select[@ng-reflect-name='ActionRequired'])[2]"));
            var ActionRequiredTwoselectElement = new SelectElement(ActionRequiredTwo);
            ActionRequiredTwoselectElement.SelectByValue("NoAction");

            driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button

            var ItemDescThree = driver.FindElement(By.XPath("(//select[@formcontrolname='ItemId'])[3]"));
            var ItemDescThreeselectElement = new SelectElement(ItemDescThree);
            ItemDescThreeselectElement.SelectByValue("2");
            System.Threading.Thread.Sleep(1000);

            var AreaThree = driver.FindElement(By.XPath("(//select[@formcontrolname='AreaId'])[3]"));
            var AreaThreeselectElement = new SelectElement(AreaThree);
            AreaThreeselectElement.SelectByValue("3");

            var CategoryThree = driver.FindElement(By.XPath("(//select[@ng-reflect-name='Category'])[3]"));
            var CategoryThreeselectElement = new SelectElement(CategoryThree);
            CategoryThreeselectElement.SelectByValue("10");

            var conditionThree = driver.FindElement(By.XPath("(//select[@ng-reflect-name='Condition'])[3]"));
            var conditionThreeselectElement = new SelectElement(conditionThree);
            conditionThreeselectElement.SelectByValue("Good");


            var ActionRequiredThree = driver.FindElement(By.XPath("(//select[@ng-reflect-name='ActionRequired'])[3]"));
            var ActionRequiredThreeselectElement = new SelectElement(ActionRequiredThree);
            ActionRequiredThreeselectElement.SelectByValue("NoAction");

            driver.FindElement(By.XPath(" //tr[@ng-reflect-name='0']//button")).Click();
            driver.FindElement(By.XPath("//textarea[@formcontrolname='Remarks']")).SendKeys("dhfgsdhghsdhgghsdghsdh gdsg sdg dgsdg");
            driver.FindElement(By.XPath("//button[@class='btn-default btn-primary']")).Click();

            driver.FindElement(By.XPath(" //tr[@ng-reflect-name='1']//button")).Click();
            driver.FindElement(By.XPath("//textarea[@formcontrolname='Remarks']")).SendKeys("234ryeryreyyery ter gdsg sdg dgsdg");
            driver.FindElement(By.XPath("//button[@class='btn-default btn-primary']")).Click();

            driver.FindElement(By.XPath(" //tr[@ng-reflect-name='2']//button")).Click();
            driver.FindElement(By.XPath("//textarea[@formcontrolname='Remarks']")).SendKeys("88hghgheyyery ter gdsg sdg dgsdg");
            driver.FindElement(By.XPath("//button[@class='btn-default btn-primary']")).Click();
            //button[@class='btn-default btn-primary']
            //  driver.FindElement(By.XPath("//button[@ng-reflect-ng-class='[object Object]']")).Click();//Add item*/

        }

        [TestMethod] 
        public void EngineerListSearch()
        {


            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("rafeek.mh@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Move-In/List");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@placeholder='Search']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@placeholder='Search']")).SendKeys("MIR-01249");




        }

        [TestMethod] 
        public void SupervisorListSearch()
        {


            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("jimson.mathew@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Move-In/List");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@placeholder='Search']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@placeholder='Search']")).SendKeys("MIR-01249");




        }

        [TestMethod]
        public void CordinatorListSearch()
        {


            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("facilitycord@softspace.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Move-In/List");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@placeholder='Search']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@placeholder='Search']")).SendKeys("MIR-01185");




        }


        [TestMethod]
        public void MoveInPhotoUpload() //PhotoUpload Move in
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("rafeek.mh@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);
           
            //driver.FindElement(By.LinkText("Add New Request")).Click();
         
            // driver.FindElement(By.XPath("//a[contains(@class,'btn-default btn-primary')]")).Click();
            //  System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Move-In_Move-Out/Request/10121/0");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='ng-star-inserted']")).Click();//edit
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//button[@class='btn-tertiary btn-custom-style-remove'])[3]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()='Click To Upload']")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX3 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"Trade liscense.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//button[@type='button']/following-sibling::button)[3]")).Click();

            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//button[@class='btn-tertiary btn-custom-style-remove'])[3]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()='Click To Upload']")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX4 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"Salary-Certificate.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//button[@type='button']/following-sibling::button)[3]")).Click();



            //  (//button[text()='Save'])[2]

            /*IWebElement element = driver.FindElement(By.Id("//div[@class='ngx-file-drop__content']//span"));
            element.SendKeys("E:\\Jithin\\Sample ID\\Salary-Certificate.jpg");*/
            /*   var AssignedTo = driver.FindElement(By.XPath("//select[@formcontrolname='AssignTo']"));
               var AssignedToselectElement = new SelectElement(AssignedTo);
               AssignedToselectElement.SelectByValue("rafeek.mh@asico.ae");*/


        }

        [TestMethod]
        public void PhotoUploadTestLeasing() //PhotoUploadTest leasing
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("mae.salvador@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(5000);

            //driver.FindElement(By.LinkText("Add New Request")).Click();

            // driver.FindElement(By.XPath("//a[contains(@class,'btn-default btn-primary')]")).Click();
            //  System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/LeasingRequest/Edit/24303");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[text()=' Edit ']")).Click();//edit
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("mat-tab-label-0-2")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()=' Add Document ']")).Click();
            System.Threading.Thread.Sleep(1000);

            var DocumentType = driver.FindElement(By.XPath("//select[@formcontrolname='docTypeId']"));
            var DocumentTypeselectElement = new SelectElement(DocumentType);
            DocumentTypeselectElement.SelectByValue("16");
            driver.FindElement(By.XPath("//input[@formcontrolname='docName']")).SendKeys("Nationalll");
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.XPath("//span[text()='Click to upload']")).Click();
            System.Threading.Thread.Sleep(2000);

            AutoItX3 autoItX3 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"Trade liscense.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");


            /*IWebElement element = driver.FindElement(By.Id("//div[@class='ngx-file-drop__content']//span"));
            element.SendKeys("E:\\Jithin\\Sample ID\\Salary-Certificate.jpg");*/
            /*   var AssignedTo = driver.FindElement(By.XPath("//select[@formcontrolname='AssignTo']"));
               var AssignedToselectElement = new SelectElement(AssignedTo);
               AssignedToselectElement.SelectByValue("rafeek.mh@asico.ae");*/


        }

        [TestMethod]
        public void SnaglistDocUpload() //Snaglist Doc Upload Move in
        {
            // IWebDriver driver = new ChromeDriver();
              driver.Manage().Window.Maximize();
               driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
               driver.FindElement(By.Id("mat-input-0")).SendKeys("rafeek.mh@asico.ae");
               driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
               System.Threading.Thread.Sleep(1000);
               driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
               System.Threading.Thread.Sleep(5000);

               //driver.FindElement(By.LinkText("Add New Request")).Click();

               // driver.FindElement(By.XPath("//a[contains(@class,'btn-default btn-primary')]")).Click();
               //  System.Threading.Thread.Sleep(3000);
               driver.Navigate().GoToUrl("http://194.233.75.55:4056/Move-In_Move-Out/Request/10121/0");
               System.Threading.Thread.Sleep(2000);
               driver.FindElement(By.XPath("//button[@class='ng-star-inserted']")).Click();//edit
               System.Threading.Thread.Sleep(2000);
               driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();//snag list button
               System.Threading.Thread.Sleep(1000);
              driver.FindElement(By.XPath("(//button[@ng-reflect-ng-class='[object Object]'])[3]")).Click();

               //button[@ng-reflect-ng-class='[object Object]'])[3]
               System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();
               System.Threading.Thread.Sleep(1000);
               driver.FindElement(By.XPath("//span[text()='Click To Upload']")).Click();
               System.Threading.Thread.Sleep(2000);
               AutoItX3 autoItX3 = new AutoItX3();
               autoItX3.WinActivate("File Upload");
               System.Threading.Thread.Sleep(1000);
               //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
               System.Threading.Thread.Sleep(2000);
               AutoItX3 autoItX4 = new AutoItX3();
               autoItX3.WinActivate("File Upload");

               autoItX3.Send(@"Trade liscense.jpg");
               System.Threading.Thread.Sleep(2000);
               autoItX3.Send("{ENTER}");
               System.Threading.Thread.Sleep(1000);
               driver.FindElement(By.XPath("(//button[@type='button']/following-sibling::button)[3]")).Click();

               System.Threading.Thread.Sleep(1000);

               driver.FindElement(By.XPath("(//button[@ng-reflect-ng-class='[object Object]'])[3]")).Click();
               System.Threading.Thread.Sleep(1000);
               driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();
               System.Threading.Thread.Sleep(1000);
               driver.FindElement(By.XPath("//span[text()='Click To Upload']")).Click();
               System.Threading.Thread.Sleep(2000);
               AutoItX3 autoItX5 = new AutoItX3();
               autoItX3.WinActivate("File Upload");
               System.Threading.Thread.Sleep(1000);
               //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
               System.Threading.Thread.Sleep(2000);
               AutoItX3 autoItX6 = new AutoItX3();
               autoItX3.WinActivate("File Upload");

               autoItX3.Send(@"Salary-Certificate.jpg");
               System.Threading.Thread.Sleep(1000);
               autoItX3.Send("{ENTER}");
               System.Threading.Thread.Sleep(1000);
               driver.FindElement(By.XPath("(//button[@type='button']/following-sibling::button)[3]")).Click();

               System.Threading.Thread.Sleep(1000);
               driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click();
               System.Threading.Thread.Sleep(1000);
               driver.FindElement(By.XPath("(//button[@class='btn-upload-snag-image'])[2]")).Click();
               System.Threading.Thread.Sleep(1000);

             //  driver.FindElement(By.XPath("//h6[text()='Snag List']/following-sibling::button")).Click(); 



               driver.FindElement(By.XPath("//button[text()=' Add Image']")).Click();

               System.Threading.Thread.Sleep(1000);
               driver.FindElement(By.XPath("//span[text()='Click To Upload']")).Click();
               System.Threading.Thread.Sleep(2000);

               autoItX3.WinActivate("File Upload");
               System.Threading.Thread.Sleep(1000);
               //driver.FindElement(By.XPath("(//button[text()='Save'])[2]")).Click();
               System.Threading.Thread.Sleep(2000);
               AutoItX3 autoItX7 = new AutoItX3();
               autoItX3.WinActivate("File Upload");

               autoItX3.Send(@"National Identity.png");
               System.Threading.Thread.Sleep(2000);
               autoItX3.Send("{ENTER}");
               System.Threading.Thread.Sleep(1000);
               driver.FindElement(By.XPath("(//button[@type='button']/following-sibling::button)[3]")).Click();

               System.Threading.Thread.Sleep(1000);



            
          /*  AutoItX3 autoItX3 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"Trade liscense.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//button[@type='button']/following-sibling::button)[3]")).Click();

            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//button[@class='btn-tertiary btn-custom-style-remove'])[3]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()='Click To Upload']")).Click();
            System.Threading.Thread.Sleep(2000);
            AutoItX3 autoItX4 = new AutoItX3();
            autoItX3.WinActivate("File Upload");

            autoItX3.Send(@"Salary-Certificate.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);*/
             


            //  (//button[text()='Save'])[2]

            /*IWebElement element = driver.FindElement(By.Id("//div[@class='ngx-file-drop__content']//span"));
            element.SendKeys("E:\\Jithin\\Sample ID\\Salary-Certificate.jpg");*/
            /*   var AssignedTo = driver.FindElement(By.XPath("//select[@formcontrolname='AssignTo']"));
               var AssignedToselectElement = new SelectElement(AssignedTo);
               AssignedToselectElement.SelectByValue("rafeek.mh@asico.ae");*/


        }


    }
}
