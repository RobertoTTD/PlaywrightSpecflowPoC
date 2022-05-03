//namespace ExploreMembership.FronEnd.Specs.PageObject
//{
//    public class LoginPage : BasePage
//    {
//        private protected const string LoginUrl = "https://localhost:62527/";
//        //private protected const string LoginUrl = "https://dora-test.explorelearning.cloud/";
//        private Interactions _interactions;

//        private static string AccountTextSelector => "id=i0116";
//        private static string PasswordTextSelector => "id=i0118";
//        private static string NextButtonSelector => "id=idSIButton9";

//        public LoginPage(BrowserDriver browserDriver) : base(browserDriver)
//        {
//            _interactions = new Interactions(_page);
//        }

//        public async Task Login()
//        {
//            await EnterAccountAsync();
//            await _interactions.ClickAsync(NextButtonSelector);
//            await EnterPasswordAsync();
//            await _interactions.ClickAsync(NextButtonSelector);
//            await _interactions.ClickAsync(NextButtonSelector);
//        }

//        public async Task EnterAccountAsync()
//        {
//            await _interactions.SendTextAsync(AccountTextSelector, "roberto.rodriguez@explorelearning.co.uk");
//        }

//        public async Task EnterPasswordAsync()
//        {
//            await _interactions.SendTextAsync(PasswordTextSelector, "Expl0re123!");
//        }

//        public async Task EnsurePageIsOpenAsync()
//        {
//            if (!(await _page).Url.StartsWith("https://login.microsoftonline.com/") ||
//                !((await _page).Url != LoginUrl))
//            {
//                await _interactions.GoToUrl(LoginUrl);
//            }

//            await (await _page).WaitForLoadStateAsync();
//        }

//        //public async Task WaitForLoginLoadedAsync()
//        //{
//        //    await (await _page).WaitForSelectorAsync(LoginTextSelector);
//        //    //.WaitForLoadStateAsync();
//        //}

//        //public async Task WaitForCentersLoadedAsync()
//        //{
//        //    await (await _page).WaitForSelectorAsync(CenterSelector);
//        //    //.WaitForLoadStateAsync();
//        //}
//    }
//}
