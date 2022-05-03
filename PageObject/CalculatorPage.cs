//namespace ExploreMembership.FronEnd.Specs.PageObject
//{
//    public class CalculatorPage : BasePage
//    {
//        private protected const string CalculatorUrl = "https://specflowoss.github.io/Calculator-Demo/Calculator.html";
//        private Interactions _interactions;

//        private static string FirstNumberFieldSelector => "#first-number";
//        private static string SecondNumberFieldSelector => "#second-number";
//        private static string AddButtonSelector => "#add-button";
//        private static string ResultLabelSelector => "#result";
//        private static string ResetButtonSelector => "#reset-button";

//        public CalculatorPage(BrowserDriver browserDriver) : base(browserDriver)
//        {
//            _interactions = new Interactions(_page);
//        }

//        public async Task EnterFirstNumberAsync(string number)
//        {
//            await _interactions.SendTextAsync(FirstNumberFieldSelector, number);
//        }

//        public async Task EnterSecondNumberAsync(string number)
//        {
//            await _interactions.SendTextAsync(SecondNumberFieldSelector, number);
//        }

//        public async Task ClickAddAsync()
//        {
//            await _interactions.ClickAsync(AddButtonSelector);
//        }

//        public async Task EnsureCalculatorIsOpenAndResetAsync()
//        {
//            if ((await _page).Url != CalculatorUrl)
//            {
//                await _interactions.GoToUrl(CalculatorUrl);
//            }
//            else
//            {
//                await _interactions.ClickAsync(ResetButtonSelector);
//                await WaitForEmptyResultAsync();
//            }
//        }

//        public async Task<string> WaitForNonEmptyResultAsync()
//        {
//            await _interactions.WaitForNonEmptyValue(ResultLabelSelector);

//            return await _interactions.GetValueAttributeAsync(ResultLabelSelector);
//        }

//        public async Task WaitForEmptyResultAsync()
//        {
//            await _interactions.WaitForEmptyValue(ResultLabelSelector);
//        }
//    }
//}
