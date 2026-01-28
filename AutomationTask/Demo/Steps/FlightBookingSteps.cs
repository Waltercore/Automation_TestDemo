using Automation_Framework.Drivers;
using Groups_Framework.Page.PageParts;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Groups_Framework.Steps
{
    [Binding]
    public class FlightBookingSteps:BaseDriver
    {
        IWebDriver localDriver;
        FlightBooking _page;
        public FlightBookingSteps()
        {
            localDriver = BaseDriver.SeleniumInitialization("Chrome");
            _page= new FlightBooking(localDriver);
        }        

        [Given(@"The user navigates to this url '([^']*)'")]
        public void GivenTheUserNavigatesToThisUrl(string url)
        {
            _page.NavigateToLoginPage(url);
        }

        [Then(@"The user enter ""([^""]*)"" departure airport name")]
        public void ThenTheUserEnterDepartureAirportName(string name)
        {
            _page.EnterDepartureAirport(name);
        }


        [Then(@"The user enter ""([^""]*)"" destination airport name")]
        public void ThenTheUserEnterDestinationAirportName(string name)
        {
            _page.EnterDestinationAirport(name);
        }

        [When(@"The user enter start Date ""([^""]*)"" september and End Date ""([^""]*)"" october")]
        public void WhenTheUserEnterStartDateSeptemberAndEndDateOctober(string p0, string p1)
        {
            _page.EnterDates(p0, p1);
        }
        [Then(@"The user enter the amount of passangers ""(.*)"" of the flight")]
        public void ThenTheUserEnterTheAmountOfPassangersOfTheFlight(string p0)
        {
            for (int i = 2; i <= Int64.Parse(p0); i++)
            {
                _page.EnterPassengers();
            }
        }
        [Then(@"The user starts the search of flights and clicks on ""(.*)""")]
        public void ThenTheUserStartsTheSearchOfFlightsAndClicksOn(string p0)
            {
                _page.PerformSearch();
            }

        [Then(@"The user click on the filter")]
        public void ThenTheUserClickOnTheFilter()
        {
            _page.EnterFilter();
        }
        [Then(@"the user click on ""(.*)"" to clear filter")]
        public void ThenTheUserClickOnToClearFilter(string p0)
        {
            _page.ClearFilter ();
        }
        [Then(@"The user select ""(.*)"" airline")]
        public void ThenTheUserSelectAirline(string p0)
        {
            _page.SelectAirline();
        }
        [Then(@"The user click on ""(.*)"" filter")]
        public void ThenTheUserClickOnFilter(string p0)
        {
            _page.SelectPaymentMethod();
        }
        [Then(@"The user clear filter by clicking on ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" this leaves only Mastercard Gold selected")]
        public void ThenTheUserClearFilterByClickingOnAndAndAndAndThisLeavesOnlyMastercardGoldSelected(string p0, string p1, string p2, string p3, string p4)
        {
            _page.SelectMastercard();
        }
        [Then(@"The user selects a ""(.*)"" from the results")]
        public void ThenTheUserSelectsAFromTheResults(string p0)
        {
            _page.ChooseFlight();
        }

        [Then(@"The user enters her ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void ThenTheUserEntersHerAndAndAnd(string p0, string p1, string p2, string p3)
        {
            _page.EnterPersonalData();
        }

        [Then(@"The user enters address details the ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void ThenTheUserEntersAddressDetailsTheAndAndAnd(string p0, string p1, string p2, string p3)
        {
            _page.EnterAddress();
        }

        [Then(@"The user enters contact information ""(.*)"" and ""(.*)"" and ""(.*)"" and selects to be notified ""(.*)""")]
        public void ThenTheUserEntersContactInformationAndAndAndSelectsToBeNotified(string p0, string p1, string p2, string p3)
        {
            _page.EnterContactInfo();
        }
        [Then(@"The user clicks on ""(.*)""")]
        public void ThenTheUserClicksOn(string p0)
        {
            _page.ClickOnWeiter();
        }
        [Then(@"The user enters erwachsener (.*) personal data ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void ThenTheUserEntersErwachsenerPersonalDataAndAndAnd(int p0, string p1, string p2, string p3, string p4)
        {
            _page.Erwachsener1();
        }
        [Then(@"The user enters personal data of erwachener (.*) ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void ThenTheUserEntersPersonalDataOfErwachenerAndAndAnd(int p0, string p1, string p2, string p3, string p4)
        {
            _page.Erwachsener2();
        }


    }



}

