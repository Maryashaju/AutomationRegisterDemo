using AutomationRegisterDemo.PageObject;
using System;
using TechTalk.SpecFlow;

namespace AutomationRegisterDemo.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }



        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();

        }
        
        [Given(@"I enter my first name")]
        public void GivenIEnterMyFirstName()
        {
            registrationPage.EnterFirstname();
        }
        
        [Given(@"i enter my last name")]
        public void GivenIEnterMyLastName()
        {
            registrationPage.EnterLastname();
        }
        
        [Given(@"I enter my Address")]
        public void GivenIEnterMyAddress()
        {
            registrationPage.EnterAddress();
        }
        
        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            registrationPage.EnterEmail();
        }
        
        [Given(@"I enter my phone number")]
        public void GivenIEnterMyPhoneNumber()
        {
            registrationPage.EnterPhone();
        }
        
        [Given(@"i choose my gender")]
        public void GivenIChooseMyGender()
        {
            registrationPage.ClickOnGender();
        }
        
        [Given(@"I select my hobby")]
        public void GivenISelectMyHobby()
        {
            registrationPage.ClickOnHobbies();
        }

        [Given(@"I click on textbox")]
        public void GivenIClickOnTextbox()
        {
            registrationPage.ClickOnTextBox();
        }


        [Given(@"I select my language")]
        public void GivenISelectMyLanguage()
        {
            registrationPage.ClickOnLanguage();
        }


        [Given(@"I select my skill")]
        public void GivenISelectMySkill()
        {
           registrationPage.SelectSkillFromDropDown();
        }

        [Given(@"I select my country")]
        public void GivenISelectMyCountry()
        {
            registrationPage.SelectCountry();
        }


        [Given(@"I enter my year of birth")]
        public void GivenIEnterMyYearOfBirth()
        {
            registrationPage.SelectYear();
        }

        [Given(@"I enter my month of birth")]
        public void GivenIEnterMyMonthOfBirth()
        {
            registrationPage.SelectMonth();
        }

        [Given(@"i enter my day of birth")]
        public void GivenIEnterMyDayOfBirth()
        {
            registrationPage.SelectDay();
        }




        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [Given(@"i Confirm my password")]
        public void GivenIConfirmMyPassword()
        {
            registrationPage.EnterConfirm();
        }
        
        [When(@"I click on submit")]
        public void WhenIClickOnSubmit()
        {
            registrationPage.ClickOnSubmit();
        }
        
        [Then(@"I should be able to register")]
        public void ThenIShouldBeAbleToRegister()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
