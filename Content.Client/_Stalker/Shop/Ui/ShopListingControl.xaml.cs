﻿using Robust.Client.AutoGenerated;
using Robust.Client.Graphics;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._Stalker.Shop.Ui;

[GenerateTypedNameReferences]
public sealed partial class ShopListingControl : Control
{
    public ShopListingControl(string itemName, string itemDescription,
        string price, bool canBuy, bool sell, Texture? texture = null, int? count = null)
    {
        RobustXamlLoader.Load(this);

        // Labels
        ShopItemName.Text = itemName;
        ShopItemDescription.SetMessage(itemDescription);
        ShopItemPrice.Text = price;
        ShopItemCount.Text = count switch
        {
            null => null,
            1 => null,
            _ => $"{count} pieces."
        };

        // Buttons
        ShopItemButton.Text = !sell ? Loc.GetString("shop-listing-buy") : Loc.GetString("shop-listing-sell");
        ShopItemButton.Disabled = !canBuy;

        // Texture
        ShopItemTexture.Texture = texture;
    }
}
