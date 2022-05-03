//using ExploreMembership.FronEnd.Specs.PageObject;

//namespace ExploreMembership.FronEnd.Specs.StepDefinitions
//{
//    [Binding]
//    public sealed class CalculatorStepDefinitions
//    {
//        private readonly CalculatorPage calculatorPage;

//        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

//        public CalculatorStepDefinitions(CalculatorPage calculatorPage)
//        {
//            this.calculatorPage = calculatorPage;
//        }

//        [Given("the first number is (.*)")]
//        public async Task GivenTheFirstNumberIsAsync(string number)
//        {
//            //TODO: implement arrange (precondition) logic
//            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
//            // To use the multiline text or the table argument of the scenario,
//            // additional string/Table parameters can be defined on the step definition
//            // method. 

//            await this.calculatorPage.EnterFirstNumberAsync(number);
//        }

//        [Given("the second number is (.*)")]
//        public async Task GivenTheSecondNumberIsAsync(string number)
//        {
//            //TODO: implement arrange (precondition) logic

//            await this.calculatorPage.EnterSecondNumberAsync(number);
//        }

//        [When("the two numbers are added")]
//        public async Task WhenTheTwoNumbersAreAddedAsync()
//        {
//            //TODO: implement act (action) logic

//            await this.calculatorPage.ClickAddAsync();
//        }

//        [Then("the result should be (.*)")]
//        public async Task ThenTheResultShouldBeAsync(string result)
//        {
//            //TODO: implement assert (verification) logic

//            var actionResult = await this.calculatorPage.WaitForNonEmptyResultAsync();

//            actionResult.Should().Be(result);
//        }
//    }
//}