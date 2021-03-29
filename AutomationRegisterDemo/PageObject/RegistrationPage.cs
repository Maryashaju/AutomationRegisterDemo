using AutomationRegisterDemo.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationRegisterDemo.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement firstname => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(2) > input"));

        IWebElement lastname => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input"));


        IWebElement address => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > div > textarea"));

        IWebElement email => driver.FindElement(By.CssSelector("#eid > input"));

        IWebElement phone => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input"));

        IWebElement gender => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(5) > div > label:nth-child(2) > input"));

        IWebElement hobbies => driver.FindElement(By.CssSelector("#checkbox2"));

        IWebElement textbox => driver.FindElement(By.CssSelector("#msdd"));

        IWebElement language => driver.FindElement(By.XPath("//a[text()='Arabic']"));

        IWebElement language2 => driver.FindElement(By.XPath("//a[text()='English']"));
        
        IWebElement skill => driver.FindElement(By.XPath("//*[@id='Skills']"));

        IWebElement country => driver.FindElement(By.XPath("//*[@id='countries']"));

        IWebElement year => driver.FindElement(By.XPath("//*[@id='yearbox']"));

        IWebElement month => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[11]/div[2]/select"));

        IWebElement day => driver.FindElement(By.XPath("//*[@id='daybox']"));

        IWebElement password => driver.FindElement(By.CssSelector("#firstpassword"));

        IWebElement confirm => driver.FindElement(By.CssSelector("#secondpassword"));

        IWebElement submit => driver.FindElement(By.CssSelector("#submitbtn"));

       














        public void EnterFirstname()
        {
            firstname.SendKeys("Queen");
        }

        public void EnterLastname()
        {
           lastname.SendKeys("Bee");
        }

        public void EnterAddress()
        {
            address.SendKeys("10 Downing Street, United Kingdom");
        }

        public void EnterEmail()
        {
            email.SendKeys("Queen.bee@gmail.com");
        }

        public void EnterPhone()
        {
            phone.SendKeys("+447933672155");
        }

        public void ClickOnGender()
        {
            gender.Click();
        }

        public void ClickOnHobbies()
        {
            hobbies.Click();
        }

        public void ClickOnTextBox()
        {
            textbox.Click();
        }

        public void ClickOnLanguage()
        {
            language.Click();
            language2.Click();
        }

        public void SelectSkillFromDropDown()
        {
            SelectElement select = new SelectElement(skill);
            select.SelectByValue("Client Support");
        }

        public void SelectCountry()
        {
            SelectElement select = new SelectElement(country);
            select.SelectByValue("Canada");
        }

        public void SelectYear()
        {
            SelectElement select = new SelectElement(year);
            select.SelectByValue("1978");
        }


        public void SelectMonth()
        {
            SelectElement select = new SelectElement(month);
            select.SelectByValue("January");
        }

        public void SelectDay()
        {
            SelectElement select = new SelectElement(day);
            select.SelectByValue("3");
        }

        public void EnterPassword()
        {
            password.SendKeys("password");
        }

        public void EnterConfirm()
        {
            confirm.SendKeys("password");
        }

        public void ClickOnSubmit()
        {
            submit.Click();
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
        }









    }
}
