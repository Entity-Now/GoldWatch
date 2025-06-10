namespace GoldWatch.Core.Fetcher;

public interface IGoldPriceFetcher
{
    Task<GoldResult> FetchCurrentPriceAsync();
}