using StardewModdingAPI;

namespace CJBShowItemSellPrice.Framework;

public static class StardewAccessIntegration
{
    private static IStardewAccessApi? _stardewAccessApi;

    public static void TryLoad(IModHelper modHelper)
    {
        StardewAccessIntegration._stardewAccessApi =
            modHelper.ModRegistry.GetApi<IStardewAccessApi>("shoaib.stardewaccess");
    }

    public static bool IsLoaded()
    {
        return StardewAccessIntegration._stardewAccessApi != null;
    }

    public static void SetMenuSuffixText(string text)
    {
        if (StardewAccessIntegration._stardewAccessApi == null) return;
        StardewAccessIntegration._stardewAccessApi.MenuSuffixText = text;
    }
}

public interface IStardewAccessApi
{
    public string MenuSuffixText { get; set; }
}
