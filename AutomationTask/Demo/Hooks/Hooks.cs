using Automation_Framework.Drivers;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Automation_Framework.Hooks
{
    //After every test case, it will perform this step to finish the test. We can manage preconditions and postconditions.
    [Binding]
    public class Hooks:BaseDriver
    {


        [AfterScenario]
        public static void AfterScenario(FeatureContext featureContext)
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

    }
}
