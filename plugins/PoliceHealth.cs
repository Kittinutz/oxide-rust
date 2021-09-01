//Requires: Coroutines

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Oxide.Plugins
{
    [Info("Better Health", "birthdates", "2.2.3")]
    [Description("Ability to customize the max health")]
    public class PoliceHealth : RustPlugin
    {

  
        private void OnPlayerRespawned(BasePlayer player)
        {
            SetHealth(player);
        }

        private void SetHealth(BasePlayer player)
        {
          if(player.HasPermission('police')){
            Debug.Writeline('helloworld');
          }
          Debug.Writeline('helloworld2');

          
        }

    }
}
//Generated with birthdates' Plugin Maker