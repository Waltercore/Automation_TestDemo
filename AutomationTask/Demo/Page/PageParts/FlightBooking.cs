using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Automation_Framework.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace Groups_Framework.Page.PageParts
//here we will look for the elements inside the Shadow Dom Roots

{
    public class FlightBooking
    {
        IWebDriver localDriver;
        WebDriverWait wait;
        public FlightBooking(IWebDriver driver)
        {
            localDriver = driver;
            wait = new WebDriverWait(localDriver, TimeSpan.FromSeconds(10));
        }
        public void NavigateToLoginPage(string url)
        {
            localDriver.Url = url;
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll"))).Click();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("");
            }

        }

        public void EnterDepartureAirport(string name)
        {
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-search")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector("page-search")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("fd-flight-search-stage")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("fd-form-round-trip[dateformat='DD.MM.YYYY']")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector("fd-airport-input[name='outbound-departure']")).GetShadowRoot();
            ISearchContext shadow5 = shadow4.FindElement(By.CssSelector("fd-float-input")).GetShadowRoot();
            IWebElement actualInput = shadow5.FindElement(By.CssSelector("#input"));
            actualInput.SendKeys(name);
            Thread.Sleep(1000);
            actualInput.SendKeys(Keys.Tab);
        }

        public void EnterDestinationAirport(string name)
        {
            IWebElement shadowHost = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.TagName("app-search")));
            var js = (IJavaScriptExecutor)localDriver;

            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-search")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector("page-search")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("fd-flight-search-stage")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("fd-form-round-trip[dateformat='DD.MM.YYYY']")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector("fd-airport-input[name='outbound-arrival']")).GetShadowRoot();
            ISearchContext shadow5 = shadow4.FindElement(By.CssSelector("fd-float-input")).GetShadowRoot();
            IWebElement actualInput = shadow5.FindElement(By.CssSelector("#input"));
            actualInput.SendKeys(name);
            Thread.Sleep(1000);
            actualInput.SendKeys(Keys.Tab);
        }


        public void EnterDates(string startDate, string EndDate)
        {

            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-search")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector("page-search")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("fd-flight-search-stage")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("fd-form-round-trip[dateformat='DD.MM.YYYY']")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector("fd-date-input[name='date-input']")).GetShadowRoot();
            ISearchContext shadow5 = shadow4.FindElement(By.CssSelector("fd-calendar[monthformat='MMMM']")).GetShadowRoot();
            ISearchContext shadow6 = shadow5.FindElement(By.CssSelector(".datepicker")).GetShadowRoot();
            ISearchContext shadow7 = shadow6.FindElement(By.CssSelector("fd-datepicker-month[month='9 2022']")).GetShadowRoot();
            ISearchContext shadow8 = shadow7.FindElement(By.CssSelector("fd-datepicker-day[timestamp='1664229600']")).GetShadowRoot();
            IList<IWebElement> shadow9 = shadow8.FindElements(By.CssSelector(".marker"));
            foreach (IWebElement b in shadow9)
            {
                if (b.Text.Equals(startDate))
                {
                    b.Click();
                }
            }
            //End Date
            ISearchContext shadow10 = localDriver.FindElement(By.CssSelector("app-search")).GetShadowRoot();
            ISearchContext shadow11 = shadow10.FindElement(By.CssSelector("page-search")).GetShadowRoot();
            ISearchContext shadow12 = shadow11.FindElement(By.CssSelector("fd-flight-search-stage")).GetShadowRoot();
            ISearchContext shadow13 = shadow12.FindElement(By.CssSelector("fd-form-round-trip[dateformat='DD.MM.YYYY']")).GetShadowRoot();
            ISearchContext shadow14 = shadow13.FindElement(By.CssSelector("fd-date-input[name='date-input']")).GetShadowRoot();
            ISearchContext shadow15 = shadow14.FindElement(By.CssSelector("fd-calendar[monthformat='MMMM']")).GetShadowRoot();
            ISearchContext shadow16 = shadow15.FindElement(By.CssSelector(".datepicker")).GetShadowRoot();
            ISearchContext shadow17 = shadow16.FindElement(By.CssSelector("fd-datepicker-month[month='10 2022']")).GetShadowRoot();
            ISearchContext shadow18 = shadow17.FindElement(By.CssSelector("fd-datepicker-day[timestamp='1666044000']")).GetShadowRoot();
            IList<IWebElement> shadow19 = shadow18.FindElements(By.CssSelector(".marker"));
            foreach (IWebElement c in shadow19)
            {
                if (c.Text.Equals(EndDate))
                {
                    c.Click();
                }
            }
            Thread.Sleep(1000);
        }
        public void EnterPassengers()
        {
            //opening Dialog
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-search")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector("page-search")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("fd-flight-search-stage")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("fd-form-round-trip[dateformat='DD.MM.YYYY']")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector("fd-pax-input[name='pax-input']")).GetShadowRoot();
            ISearchContext shadow5 = shadow4.FindElement(By.CssSelector("fd-float-input[label='Reisende']")).GetShadowRoot();
            IWebElement actualInput = shadow5.FindElement(By.CssSelector("#input"));
            actualInput.Click();


            //Increasing Adults passenger
            ISearchContext shadow10 = localDriver.FindElement(By.CssSelector("app-search")).GetShadowRoot();
            ISearchContext shadow11 = shadow10.FindElement(By.CssSelector("page-search")).GetShadowRoot();
            ISearchContext shadow12 = shadow11.FindElement(By.CssSelector("fd-flight-search-stage")).GetShadowRoot();
            ISearchContext shadow13 = shadow12.FindElement(By.CssSelector("fd-form-round-trip[dateformat='DD.MM.YYYY']")).GetShadowRoot();
            ISearchContext shadow14 = shadow13.FindElement(By.CssSelector("fd-pax-input[name='pax-input']")).GetShadowRoot();
            ISearchContext shadow15 = shadow14.FindElement(By.CssSelector("fd-pax-selection")).GetShadowRoot();
            ISearchContext shadow16 = shadow15.FindElement(By.CssSelector("fd-pax-selection-content[slot='content']")).GetShadowRoot();
            ISearchContext shadow17 = shadow16.FindElement(By.CssSelector("fd-stepper[name='adult']")).GetShadowRoot();
            shadow17.FindElement(By.CssSelector(".button.primary.increase"));
            IWebElement actualInput2 = shadow17.FindElement(By.CssSelector(".button.primary.increase"));
            actualInput2.Click();
            Thread.Sleep(2000);
        }

        public void PerformSearch()
        {
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-search")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector("page-search")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("fd-flight-search-stage")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("fd-form-round-trip[dateformat='DD.MM.YYYY']")).GetShadowRoot();
            shadow3.FindElement(By.CssSelector(".button"));
            IWebElement actualInput = shadow3.FindElement(By.CssSelector(".button"));
            actualInput.Click();
            Thread.Sleep(12000);
        }
        public void EnterFilter()
        {
            //clicking on Airline
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-compare")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector("fd-filter-frame[slot='appSidebar']")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("fd-flight-filter")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("#airlines")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector("fd-filter-element[headline='Airline']")).GetShadowRoot();
            shadow4.FindElement(By.CssSelector(".filter-element-trigger"));
            IWebElement actualInput = shadow4.FindElement(By.CssSelector(".filter-element-trigger"));
            actualInput.Click();
            Thread.Sleep(3000);
        }
        public void ClearFilter()
        {
            //click on alle löschen
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-compare")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector("fd-filter-frame[slot='appSidebar']")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("fd-flight-filter")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("#airlines")).GetShadowRoot();
            shadow3.FindElement(By.CssSelector(".button.action.negative"));
            IWebElement actualInput = shadow3.FindElement(By.CssSelector(".button.action.negative"));
            actualInput.Click();
            Thread.Sleep(4000);
        }
        public void SelectAirline()
        {
            //click on Swiss airline checkbox
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-compare")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector("fd-filter-frame[slot='appSidebar']")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("fd-flight-filter")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("#airlines")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector(" fd-filter-element:nth-child(1) > div:nth-child(1) > fd-checkbox:nth-child(10)")).GetShadowRoot();
            shadow4.FindElement(By.CssSelector("label"));
            IWebElement actualInput = shadow4.FindElement(By.CssSelector("label"));
            actualInput.Click();
            Thread.Sleep(4000);
        }
        public void SelectPaymentMethod()
        {
            //click on Swiss airline checkbox
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-compare")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector("fd-filter-frame[slot='appSidebar']")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("fd-flight-filter")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("#airlines")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector(" fd-filter-element:nth-child(1) > div:nth-child(1) > fd-checkbox:nth-child(13)")).GetShadowRoot();
            shadow4.FindElement(By.CssSelector("label"));
            IWebElement actualInput = shadow4.FindElement(By.CssSelector(".filter-element-trigger"));
            actualInput.Click();
            Thread.Sleep(3000);
        }
        public void SelectMastercard()
        {
            //remove Visa payment method from filter
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-compare")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector("fd-filter-frame[slot='appSidebar']")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("fd-flight-filter")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("#payment-method")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector(" fd-filter-element:nth-child(1) > div:nth-child(1) > fd-checkbox:nth-child(3)")).GetShadowRoot();
            shadow4.FindElement(By.CssSelector("label"));
            IWebElement actualInput = shadow4.FindElement(By.CssSelector("label"));
            actualInput.Click();
            Thread.Sleep(1000);

            //remove Mastercard payment method
            ISearchContext shadow10 = localDriver.FindElement(By.CssSelector("app-compare")).GetShadowRoot();
            ISearchContext shadow11 = shadow10.FindElement(By.CssSelector("fd-filter-frame[slot='appSidebar']")).GetShadowRoot();
            ISearchContext shadow12 = shadow11.FindElement(By.CssSelector("fd-flight-filter")).GetShadowRoot();
            ISearchContext shadow13 = shadow12.FindElement(By.CssSelector("#payment-method")).GetShadowRoot();
            ISearchContext shadow14 = shadow13.FindElement(By.CssSelector(" fd-filter-element:nth-child(1) > div:nth-child(1) > fd-checkbox:nth-child(2)")).GetShadowRoot();
            shadow14.FindElement(By.CssSelector("label"));
            IWebElement actualInput2 = shadow14.FindElement(By.CssSelector("label"));
            actualInput2.Click();
            Thread.Sleep(1000);

            //Remove Visa Electron
            ISearchContext shadow20 = localDriver.FindElement(By.CssSelector("app-compare")).GetShadowRoot();
            ISearchContext shadow21 = shadow20.FindElement(By.CssSelector("fd-filter-frame[slot='appSidebar']")).GetShadowRoot();
            ISearchContext shadow22 = shadow21.FindElement(By.CssSelector("fd-flight-filter")).GetShadowRoot();
            ISearchContext shadow23 = shadow22.FindElement(By.CssSelector("#payment-method")).GetShadowRoot();
            ISearchContext shadow24 = shadow23.FindElement(By.CssSelector(" fd-filter-element:nth-child(1) > div:nth-child(1) > fd-checkbox:nth-child(4)")).GetShadowRoot();
            shadow24.FindElement(By.CssSelector("label"));
            IWebElement actualInput3 = shadow24.FindElement(By.CssSelector("label"));
            actualInput3.Click();
            Thread.Sleep(1000);

            //Remove American Express
            ISearchContext shadow30 = localDriver.FindElement(By.CssSelector("app-compare")).GetShadowRoot();
            ISearchContext shadow31 = shadow30.FindElement(By.CssSelector("fd-filter-frame[slot='appSidebar']")).GetShadowRoot();
            ISearchContext shadow32 = shadow31.FindElement(By.CssSelector("fd-flight-filter")).GetShadowRoot();
            ISearchContext shadow33 = shadow32.FindElement(By.CssSelector("#payment-method")).GetShadowRoot();
            ISearchContext shadow34 = shadow33.FindElement(By.CssSelector(" fd-filter-element:nth-child(1) > div:nth-child(1) > fd-checkbox:nth-child(5)")).GetShadowRoot();
            shadow34.FindElement(By.CssSelector("label"));
            IWebElement actualInput4 = shadow34.FindElement(By.CssSelector("label"));
            actualInput4.Click();
            Thread.Sleep(1000);

            //Remove Lastschrifft
            ISearchContext shadow40 = localDriver.FindElement(By.CssSelector("app-compare")).GetShadowRoot();
            ISearchContext shadow41 = shadow40.FindElement(By.CssSelector("fd-filter-frame[slot='appSidebar']")).GetShadowRoot();
            ISearchContext shadow42 = shadow41.FindElement(By.CssSelector("fd-flight-filter")).GetShadowRoot();
            ISearchContext shadow43 = shadow42.FindElement(By.CssSelector("#payment-method")).GetShadowRoot();
            ISearchContext shadow44 = shadow43.FindElement(By.CssSelector(" fd-filter-element:nth-child(1) > div:nth-child(1) > fd-checkbox:nth-child(6)")).GetShadowRoot();
            shadow44.FindElement(By.CssSelector("label"));
            IWebElement actualInput5 = shadow44.FindElement(By.CssSelector("label"));
            actualInput5.Click();
            Thread.Sleep(5000);
        }
        public void ChooseFlight()
        {
            //click on a flight from results
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-compare")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector("fd-page-compare[slot='appContent']")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("fd-flight-offers-list")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector(" fd-flight-offer:nth-child(1)")).GetShadowRoot();
            shadow3.FindElement(By.CssSelector(".button"));
            IWebElement actualInput = shadow3.FindElement(By.CssSelector(".button"));
            actualInput.Click();
            Thread.Sleep(10000);
        }
        public void EnterPersonalData()
        {
            //Select Gender of the customer
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector("fd-customer-personal-data[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow5 = shadow4.FindElement(By.CssSelector("fd-radio-group[name='salutation']")).GetShadowRoot();
            shadow5.FindElement(By.CssSelector("label:nth-child(1) > fd-radio-item-button:nth-child(2)"));
            IWebElement actualInput = shadow5.FindElement(By.CssSelector("label:nth-child(1) > fd-radio-item-button:nth-child(2)"));
            actualInput.Click();
            Thread.Sleep(1000);

            //Enter vorname
            ISearchContext shadow10 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow11 = shadow10.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow12 = shadow11.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow13 = shadow12.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot();
            ISearchContext shadow14 = shadow13.FindElement(By.CssSelector("fd-customer-personal-data[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow15 = shadow14.FindElement(By.CssSelector("fd-float-input[name='firstName']")).GetShadowRoot();
            shadow15.FindElement(By.CssSelector("#input"));
            IWebElement actualInput2 = shadow15.FindElement(By.CssSelector("#input"));
            actualInput2.SendKeys("Tina");
            Thread.Sleep(1000);

            //Enter Nachname
            ISearchContext shadow20 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow21 = shadow20.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow22 = shadow21.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow23 = shadow22.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot();
            ISearchContext shadow24 = shadow23.FindElement(By.CssSelector("fd-customer-personal-data[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow25 = shadow24.FindElement(By.CssSelector("fd-float-input[name='lastName']")).GetShadowRoot();
            shadow25.FindElement(By.CssSelector("#input"));
            IWebElement actualInput3 = shadow25.FindElement(By.CssSelector("#input"));
            actualInput3.SendKeys("Meyer");
            Thread.Sleep(1000);

            //Enter birthday
            ISearchContext shadow30 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow31 = shadow30.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow32 = shadow31.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow33 = shadow32.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot();
            ISearchContext shadow34 = shadow33.FindElement(By.CssSelector("fd-customer-personal-data[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow35 = shadow34.FindElement(By.CssSelector("fd-float-input--date[name='birthday']")).GetShadowRoot();
            ISearchContext shadow36 = shadow35.FindElement(By.CssSelector("fd-float-input[inputmode='numeric']")).GetShadowRoot();
            shadow36.FindElement(By.CssSelector("#input"));
            IWebElement actualInput4 = shadow36.FindElement(By.CssSelector("#input"));
            actualInput4.SendKeys("11.10.1986");
            Thread.Sleep(1000);
        }
        public void EnterAddress()
        {
            //enter the street
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector("fd-customer-address[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow5 = shadow4.FindElement(By.CssSelector("fd-float-input[name='street']")).GetShadowRoot();
            shadow5.FindElement(By.CssSelector("#input"));
            IWebElement actualInput = shadow5.FindElement(By.CssSelector("#input"));
            actualInput.SendKeys("Teststrasse");
            Thread.Sleep(1000);

            //enter haus nr.
            ISearchContext shadow10 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow11 = shadow10.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow12 = shadow11.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow13 = shadow12.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot();
            ISearchContext shadow14 = shadow13.FindElement(By.CssSelector("fd-customer-address[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow15 = shadow14.FindElement(By.CssSelector("fd-float-input[name='streetNumber']")).GetShadowRoot();
            shadow15.FindElement(By.CssSelector("#input"));
            IWebElement actualInput1 = shadow15.FindElement(By.CssSelector("#input"));
            actualInput1.SendKeys("11");
            Thread.Sleep(1000);

            //enter PLZ
            ISearchContext shadow20 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow21 = shadow20.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow22 = shadow21.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow23 = shadow22.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot();
            ISearchContext shadow24 = shadow23.FindElement(By.CssSelector("fd-customer-address[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow25 = shadow24.FindElement(By.CssSelector("fd-float-input[name='zip']")).GetShadowRoot();
            shadow25.FindElement(By.CssSelector("#input"));
            IWebElement actualInput2 = shadow25.FindElement(By.CssSelector("#input"));
            actualInput2.SendKeys("00000");
            Thread.Sleep(1000);

            //enter stadt
            ISearchContext shadow30 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow31 = shadow30.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow32 = shadow31.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow33 = shadow32.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot();
            ISearchContext shadow34 = shadow33.FindElement(By.CssSelector("fd-customer-address[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow35 = shadow34.FindElement(By.CssSelector("fd-float-input[name='city']")).GetShadowRoot();
            shadow35.FindElement(By.CssSelector("#input"));
            IWebElement actualInput3 = shadow35.FindElement(By.CssSelector("#input"));
            actualInput3.SendKeys("Teststadt");
            Thread.Sleep(1000);

        }
        public void EnterContactInfo()
        {
            //Enter email address
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector("fd-customer-contact-information[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow5 = shadow4.FindElement(By.CssSelector("fd-float-input[name='email']")).GetShadowRoot();
            shadow5.FindElement(By.CssSelector("#input"));
            IWebElement actualInput = shadow5.FindElement(By.CssSelector("#input"));
            actualInput.SendKeys("tina.meyer@gmx.gov");
            Thread.Sleep(1000);

            //Confirm email address
            ISearchContext shadow10 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow11 = shadow10.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow12 = shadow11.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow13 = shadow12.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot(); ;
            ISearchContext shadow14 = shadow13.FindElement(By.CssSelector("fd-customer-contact-information[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow15 = shadow14.FindElement(By.CssSelector("fd-float-input[name='emailRepeat']")).GetShadowRoot();
            shadow15.FindElement(By.CssSelector("#input"));
            IWebElement actualInput1 = shadow15.FindElement(By.CssSelector("#input"));
            actualInput1.SendKeys("tina.meyer@gmx.gov");
            Thread.Sleep(1000);

            //enter telefon
            ISearchContext shadow20 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow21 = shadow20.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow22 = shadow21.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow23 = shadow22.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot();
            ISearchContext shadow24 = shadow23.FindElement(By.CssSelector("fd-customer-contact-information[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow25 = shadow24.FindElement(By.CssSelector("fd-float-input[name='phoneNumber']")).GetShadowRoot();
            shadow25.FindElement(By.CssSelector("#input"));
            IWebElement actualInput2 = shadow25.FindElement(By.CssSelector("#input"));
            actualInput2.SendKeys("0341-23456789");
            Thread.Sleep(1000);

            //select to be contacted per email
            ISearchContext shadow30 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow31 = shadow30.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow32 = shadow31.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            ISearchContext shadow33 = shadow32.FindElement(By.CssSelector("fd-customer-form")).GetShadowRoot();
            ISearchContext shadow34 = shadow33.FindElement(By.CssSelector("fd-customer-contact-information[class='frame-item']")).GetShadowRoot();
            ISearchContext shadow35 = shadow34.FindElement(By.CssSelector("fd-checkbox[name='email-permission-checkbox']")).GetShadowRoot();
            shadow35.FindElement(By.CssSelector("label"));
            IWebElement actualInput3 = shadow35.FindElement(By.CssSelector("label"));
            actualInput3.Click();
            Thread.Sleep(3000);
        }
        public void ClickOnWeiter()
        {
            //Click on weiter zu den Reisenden
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("section-customer[name='SECTION_CUSTOMER']")).GetShadowRoot();
            shadow2.FindElement(By.CssSelector(".button"));
            IWebElement actualInput = shadow2.FindElement(By.CssSelector(".button"));
            actualInput.Click();
            Thread.Sleep(5000);
        }
        public void Erwachsener1() 
        {
            //enter erwachsener 1 information
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("section-travellers[name='SECTION_TRAVELLERS']")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("fd-traveller-form")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector("fd-traveller-data[name='Traveller-0']")).GetShadowRoot();
            ISearchContext shadow5 = shadow4.FindElement(By.CssSelector("fd-radio-group[name='title']")).GetShadowRoot();
            shadow5.FindElement(By.CssSelector("label:nth-child(1) > fd-radio-item-button:nth-child(2)"));
            IWebElement actualInput = shadow5.FindElement(By.CssSelector("label:nth-child(1) > fd-radio-item-button:nth-child(2)"));
            actualInput.Click();
            Thread.Sleep(1000);

            //enter vorname
            ISearchContext shadow10 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow11 = shadow10.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow12 = shadow11.FindElement(By.CssSelector("section-travellers[name='SECTION_TRAVELLERS']")).GetShadowRoot();
            ISearchContext shadow13 = shadow12.FindElement(By.CssSelector("fd-traveller-form")).GetShadowRoot();
            ISearchContext shadow14 = shadow13.FindElement(By.CssSelector("fd-traveller-data[name='Traveller-0']")).GetShadowRoot();
            ISearchContext shadow15 = shadow14.FindElement(By.CssSelector("fd-float-input[name='firstName']")).GetShadowRoot();
            shadow15.FindElement(By.CssSelector("#input"));
            IWebElement actualInput2 = shadow15.FindElement(By.CssSelector("#input"));
            actualInput2.SendKeys("Tina");
            Thread.Sleep(1000);

            //enter nachname
            ISearchContext shadow20 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow21 = shadow20.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow22 = shadow21.FindElement(By.CssSelector("section-travellers[name='SECTION_TRAVELLERS']")).GetShadowRoot();
            ISearchContext shadow23 = shadow22.FindElement(By.CssSelector("fd-traveller-form")).GetShadowRoot();
            ISearchContext shadow24 = shadow23.FindElement(By.CssSelector("fd-traveller-data[name='Traveller-0']")).GetShadowRoot();
            ISearchContext shadow25 = shadow24.FindElement(By.CssSelector("fd-float-input[name='lastName']")).GetShadowRoot();
            shadow25.FindElement(By.CssSelector("#input"));
            IWebElement actualInput3 = shadow25.FindElement(By.CssSelector("#input"));
            actualInput3.SendKeys("Meyer");
            Thread.Sleep(1000);

            //enter geburtstag
            ISearchContext shadow30 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow31 = shadow30.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow32 = shadow31.FindElement(By.CssSelector("section-travellers[name='SECTION_TRAVELLERS']")).GetShadowRoot();
            ISearchContext shadow33 = shadow32.FindElement(By.CssSelector("fd-traveller-form")).GetShadowRoot();
            ISearchContext shadow34 = shadow33.FindElement(By.CssSelector("fd-traveller-data[name='Traveller-0']")).GetShadowRoot();
            ISearchContext shadow35 = shadow34.FindElement(By.CssSelector(".last-element")).GetShadowRoot();
            ISearchContext shadow36 = shadow35.FindElement(By.CssSelector("fd-float-input[inputmode='numeric']")).GetShadowRoot();
            shadow36.FindElement(By.CssSelector("#input"));
            IWebElement actualInput4 = shadow36.FindElement(By.CssSelector("#input"));
            actualInput4.SendKeys("11.10.1986");
            Thread.Sleep(1000);

          }
        public void Erwachsener2()
        {
            //enter erwachsener 2 information
            ISearchContext shadow0 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow1 = shadow0.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow2 = shadow1.FindElement(By.CssSelector("section-travellers[name='SECTION_TRAVELLERS']")).GetShadowRoot();
            ISearchContext shadow3 = shadow2.FindElement(By.CssSelector("fd-traveller-form")).GetShadowRoot();
            ISearchContext shadow4 = shadow3.FindElement(By.CssSelector("fd-traveller-data[name='Traveller-1']")).GetShadowRoot();
            ISearchContext shadow5 = shadow4.FindElement(By.CssSelector("fd-radio-group[name='title']")).GetShadowRoot();
            shadow5.FindElement(By.CssSelector("label:nth-child(2) > fd-radio-item-button:nth-child(2)"));
            IWebElement actualInput = shadow5.FindElement(By.CssSelector("label:nth-child(2) > fd-radio-item-button:nth-child(2)"));
            actualInput.Click();
            Thread.Sleep(1000);

            //enter vorname
            ISearchContext shadow10 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow11 = shadow10.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow12 = shadow11.FindElement(By.CssSelector("section-travellers[name='SECTION_TRAVELLERS']")).GetShadowRoot();
            ISearchContext shadow13 = shadow12.FindElement(By.CssSelector("fd-traveller-form")).GetShadowRoot();
            ISearchContext shadow14 = shadow13.FindElement(By.CssSelector("fd-traveller-data[name='Traveller-1']")).GetShadowRoot();
            ISearchContext shadow15 = shadow14.FindElement(By.CssSelector("fd-float-input[name='firstName']")).GetShadowRoot();
            shadow15.FindElement(By.CssSelector("#input"));
            IWebElement actualInput2 = shadow15.FindElement(By.CssSelector("#input"));
            actualInput2.SendKeys("Wolfang");
            Thread.Sleep(1000);

            //enter nachname
            ISearchContext shadow20 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow21 = shadow20.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow22 = shadow21.FindElement(By.CssSelector("section-travellers[name='SECTION_TRAVELLERS']")).GetShadowRoot();
            ISearchContext shadow23 = shadow22.FindElement(By.CssSelector("fd-traveller-form")).GetShadowRoot();
            ISearchContext shadow24 = shadow23.FindElement(By.CssSelector("fd-traveller-data[name='Traveller-1']")).GetShadowRoot();
            ISearchContext shadow25 = shadow24.FindElement(By.CssSelector("fd-float-input[name='lastName']")).GetShadowRoot();
            shadow25.FindElement(By.CssSelector("#input"));
            IWebElement actualInput3 = shadow25.FindElement(By.CssSelector("#input"));
            actualInput3.SendKeys("Meyer");
            Thread.Sleep(1000);

            //enter geburtstag
            ISearchContext shadow30 = localDriver.FindElement(By.CssSelector("app-book")).GetShadowRoot();
            ISearchContext shadow31 = shadow30.FindElement(By.CssSelector(".app-content")).GetShadowRoot();
            ISearchContext shadow32 = shadow31.FindElement(By.CssSelector("section-travellers[name='SECTION_TRAVELLERS']")).GetShadowRoot();
            ISearchContext shadow33 = shadow32.FindElement(By.CssSelector("fd-traveller-form")).GetShadowRoot();
            ISearchContext shadow34 = shadow33.FindElement(By.CssSelector("fd-traveller-data[name='Traveller-1']")).GetShadowRoot();
            ISearchContext shadow35 = shadow34.FindElement(By.CssSelector(".last-element")).GetShadowRoot();
            ISearchContext shadow36 = shadow35.FindElement(By.CssSelector("fd-float-input[inputmode='numeric']")).GetShadowRoot();
            shadow36.FindElement(By.CssSelector("#input"));
            IWebElement actualInput4 = shadow36.FindElement(By.CssSelector("#input"));
            actualInput4.SendKeys("18.09.1985");
            Thread.Sleep(1000);

        }
    }
}
