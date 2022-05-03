namespace ExploreMembership.FronEnd.Specs.PageObject
{
    //public class BasePage
    //{
    //    public readonly Task<IPage> _page;

    //    public BasePage(BrowserDriver browserDriver) => _page = CreatePageAsync(browserDriver.Current);

    //    private async Task<IPage>? CreatePageAsync(Task<IBrowser> browser)
    //    {
    //        return await (await browser).NewPageAsync();
    //    }
    //}

    public abstract class BasePage
    {
        public abstract string PagePath { get; }

        public abstract IPage Page { get; set; }

        public abstract IBrowser Browser { get; }

        public async Task NavigateAsync()
        {
            Page = await Browser.NewPageAsync();
            await Page.GotoAsync(PagePath);
        }
    }
}
