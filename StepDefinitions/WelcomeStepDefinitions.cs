using ExploreMembership.FronEnd.Specs.PageObject;

namespace ExploreMembership.FronEnd.Specs.StepDefinitions
{
    [Binding]
    public class WelcomeStepDefinitions
    {
        private readonly WelcomePage _welcomePage;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        public WelcomeStepDefinitions(WelcomePage welcomePage)
        {
            this._welcomePage = welcomePage;
        }

        [Given(@"Welcome page")]
        public async void GivenWelcomePage()
        {
            await _welcomePage.Login();
            var yooo = "yooo";
        }

        [When(@"Click on Centers tab")]
        public async void WhenClickOnCentersTab()
        {
            await this._welcomePage.ClickCentersAsync();
        }

        [Then(@"Centers screen is loaded")]
        public async void ThenCentersScreenIsLoaded()
        {
           // await this._welcomePage.WaitForCentersLoadedAsync();
        }
    }
}
