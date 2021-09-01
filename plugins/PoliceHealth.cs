namespace Oxide.Plugins
{
    [Info("Police", "birthdates", "2.2.3")]
    [Description("Ability to customize the max health")]
    public class PoliceHealth : CovalencePlugin
    {
        private void Init()
        {
            permission.RegisterPermission("Police", this);
        }

          private void OnUserConnected(IPlayer player)
        {
            if (player.HasPermission("Police"))
            {
                player.maxHealth = 300f
            }
        }
  
        // private void OnPlayerRespawned(BasePlayer player)
        // {
        //     SetHealth(player);
        // }

        // private void SetHealth(BasePlayer player)
        // {
        //   if(player.HasPermission('police')){
        //     Debug.Writeline('helloworld');
        //   }
        //   Debug.Writeline('helloworld2');

          
        // }

    }
}