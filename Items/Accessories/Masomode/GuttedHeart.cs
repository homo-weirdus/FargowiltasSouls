using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FargowiltasSouls.Items.Accessories.Masomode
{
    public class GuttedHeart : ModItem
    {
        public override string Texture => "FargowiltasSouls/Items/Placeholder";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gutted Heart");
            Tooltip.SetDefault(@"''
Grants immunity to Bloodthirsty
10% increased max HP
Creepers hover around you blocking some damage
A new Creeper appears every X seconds, and 5 can exist at once");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.accessory = true;
            item.rare = 4;
            item.value = Item.sellPrice(0, 4);
            item.defense = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.buffImmune[mod.BuffType("Bloodthirsty")] = true;
            player.maxLife2 *= 1.1f;
            
            Timer++
            
            if(Timer >= && creeperCount < 5)
            {
            spawn creeper
            }
        }
    }
}
