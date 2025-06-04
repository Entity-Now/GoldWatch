namespace GoldWatch.Core;

public class RequestCloud
{
    public static async Task<GoldResult> GetGoldPrice()
    {
        IGoldPriceFetcher[] platforms = [new cmbchinaFetcher(), new guojijinjiaFetcher(), new huilvbiaoFetcher()];
        foreach (var platform in platforms)
        {
            try
            {

                var result = await platform.FetchCurrentPriceAsync();

                return result;
            }
            finally
            {
                    
            }
        }

        return new GoldResult();
    }
}