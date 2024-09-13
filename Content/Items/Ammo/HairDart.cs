using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace gvmod.Content.Items.Ammo
{
    public class HairDart : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 14;
            Item.height = 10;

            Item.damage = 1;
            Item.DamageType = ModContent.GetInstance<SeptimaDamageClass>();

            Item.maxStack = 9999;
            Item.consumable = true;
            Item.knockBack = 2f;
            Item.value = Item.sellPrice(0, 0, 0, 10);
            Item.rare = ItemRarityID.Green;

            Item.ammo = Item.type;
        }

        public override void AddRecipes()
        {
            CreateRecipe(99)
                .AddRecipeGroup(RecipeGroupID.IronBar)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
