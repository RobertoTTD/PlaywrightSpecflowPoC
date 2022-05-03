//using ExploreMembership.FronEnd.Specs.PageObject;

//namespace ExploreMembership.FronEnd.Specs.Hooks
//{
//    [Binding]
//    public sealed class CalculatorHook
//    {
//        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

//        [BeforeScenario]
//        public async Task BeforeScenario(CalculatorPage calculatorPage)
//        {
//            await calculatorPage.EnsureCalculatorIsOpenAndResetAsync();
//        }

//        //[BeforeScenario(Order = 1)]
//        //public void FirstBeforeScenario()
//        //{
//        //    // Example of ordering the execution of hooks
//        //    // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

//        //    //TODO: implement logic that has to run before executing each scenario
//        //}

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            //TODO: implement logic that has to run after executing each scenario
//        }
//    }
//}