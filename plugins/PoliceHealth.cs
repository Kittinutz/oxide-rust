using Newtonsoft.Json;
using Oxide.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Oxide.Core.Plugins;
using UnityEngine;
using Oxide.Core;
using Oxide.Core.Libraries.Covalence;
using Oxide.Core.Plugins;

namespace Oxide.Plugins
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
                player.MaxHealth = 300f;
            }
        }
  

    }
}