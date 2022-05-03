namespace ExploreMembership.FronEnd.Specs.PageObject
{
    //public class WelcomePage : BasePage
    //{
    //    private protected const string WelcomeUrl = "https://localhost:62527/";
    //   // private protected const string WelcomeUrl = "https://dora-test.explorelearning.cloud/";
    //    private Interactions _interactions;
    //    private static string AccountTextSelector => "id=i0116";
    //    private static string PasswordTextSelector => "id=i0118";
    //    private static string NextButtonSelector => "id=idSIButton9";

    //    private static string AdminTabSelector => "#text=Admin";
    //    private static string WelcomeTextSelector => "#text=Welcome back";
    //    private static string ExploreIconSelector => "#text=Explore Learning";
    //    //private static string CenterSelector => "#text=' Centres '";
    //    private static string HeaderSelector => "id=MainHeader";
    //    private static string CenterSelector => "id=centres_header";
    //    private static string YourCentersSelector => "no-margin";
    //    //private static string ExploreIconSelector => "#text=Explore Learning";

    //    public WelcomePage(BrowserDriver browserDriver) : base(browserDriver)
    //    {
    //        _interactions = new Interactions(_page);
    //    }

    //    public async Task ClickAdminAsync()
    //    {
    //        await _interactions.ClickAsync(AdminTabSelector);
    //    }

    //    public async Task ClickCentersAsync()
    //    {
    //        //await _interactions.ClickAsync(CenterSelector);
    //        //await (await this._page).HoverAsync(CenterSelector);
    //        await _interactions.ClickAsync(CenterSelector);
    //        ////var bar = (await this._page).Locator(HeaderSelector);
    //        //var centres = await (await this._page).QuerySelectorAsync(CenterSelector);
    //        var yooo = "yoo";
    //        //await centres.ClickAsync();
    //        //var yo2 = "yoo";
    //    }

    //    public async Task WaitForWelcomeLoadedAsync()
    //    {
    //        await (await _page).WaitForSelectorAsync(WelcomeTextSelector);
    //        //.WaitForLoadStateAsync();
    //    }

    //    public async Task WaitForCentersLoadedAsync()
    //    {
    //        await (await _page).WaitForSelectorAsync(YourCentersSelector);

    //        var yup = "yup";
    //        //.WaitForLoadStateAsync();
    //    }

    //    public async Task Login()
    //    {
    //        await EnterAccountAsync();
    //        await _interactions.ClickAsync(NextButtonSelector);
    //        await EnterPasswordAsync();
    //        await _interactions.ClickAsync(NextButtonSelector);
    //        await _interactions.ClickAsync(NextButtonSelector);
    //        await ClickCentersAsync();
    //    }

    //    public async Task EnterAccountAsync()
    //    {
    //        await _interactions.SendTextAsync(AccountTextSelector, "roberto.rodriguez@explorelearning.co.uk");
    //    }

    //    public async Task EnterPasswordAsync()
    //    {
    //        await _interactions.SendTextAsync(PasswordTextSelector, "Expl0re123!");
    //    }

    //    public async Task EnsurePageIsOpenAsync()
    //    {
    //        if (!(await _page).Url.StartsWith("https://login.microsoftonline.com/") ||
    //            !((await _page).Url != WelcomeUrl))
    //        {
    //            await _interactions.GoToUrl(WelcomeUrl);
    //        }

    //        await (await _page).WaitForLoadStateAsync();
    //    }
    //}

    public class WelcomePage : BasePage
    {
        public override string PagePath => "";
        private static string WelcomeUrl => "https://localhost:62527/";
        //   public override string WelcomeUrl => "https://dora-test.explorelearning.cloud/";
        private static string AccountTextSelector => "id=i0116";
        private static string PasswordTextSelector => "id=i0118";
        private static string NextButtonSelector => "id=idSIButton9";
        private static string CenterSelector => "id=centres_header";
        private Interactions _interactions;
        private Task<IPage> _page;

        public WelcomePage (BrowserDriver browserDriver)
        {
             _page = CreatePageAsync(browserDriver.Current);
            _interactions = new Interactions(_page);
        }

        public override IPage Page { get; set; }

        public override IBrowser Browser { get; }


        private async Task<IPage> CreatePageAsync(Task<IBrowser> browser)
        {
            return await (await browser).NewPageAsync();
        }

        public async Task Login()
        {
            await EnterAccountAsync();
            await (await _page).ClickAsync(NextButtonSelector);
            await EnterPasswordAsync();
            await _interactions.ClickAsync(NextButtonSelector);
            await _interactions.ClickAsync(NextButtonSelector);
        }

        public async Task EnterAccountAsync()
        {
            await _interactions.SendTextAsync(AccountTextSelector, "roberto.rodriguez@explorelearning.co.uk");
        }

        public async Task EnterPasswordAsync()
        {
            await _interactions.SendTextAsync(PasswordTextSelector, "Expl0re123!");
        }

        public async Task ClickCentersAsync()
        {
            //await _interactions.ClickAsync(CenterSelector);
            //await (await this._page).HoverAsync(CenterSelector);
            await _interactions.ClickAsync(CenterSelector);
            ////var bar = (await this._page).Locator(HeaderSelector);
            //var centres = await (await this._page).QuerySelectorAsync(CenterSelector);
            var yooo = "yoo";
            //await centres.ClickAsync();
            //var yo2 = "yoo";
        }

        public async Task EnsurePageIsOpenAsync()
        {
            if (!(await _page).Url.StartsWith("https://login.microsoftonline.com/") ||
                !((await _page).Url != WelcomeUrl))
            {
                await _interactions.GoToUrl(WelcomeUrl);
            }

            await (await _page).WaitForLoadStateAsync();
        }
    }
}
