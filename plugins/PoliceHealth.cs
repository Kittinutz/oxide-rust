using System;

namespace Oxide.CovalencePlugin
{
    [Info("Police", "birthdates", "2.2.3")]
    [Description("Ability to customize the max health")]
    public class PoliceHealth : RustPlugin
    {
        private void Init()
        {
            permission.RegisterPermission("Police", this);
        }

          private void OnUserConnected(IPlayer player)
        {
            if (player.HasPermission("Police"))
            {
                player.maxHealth = 300f;
            }
        }
  

    }
}