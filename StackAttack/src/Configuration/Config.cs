using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAttack.Configuration
{
    public class Config
    {
        public bool EnableQuickStackHotkey { get; set; } = true;
        public bool EnableDepositAllHotkey { get; set; } = true;
        public bool EnableWithdrawAllHotkey { get; set; } = true;
        public bool EnableQuickStackNearbyHotkey { get; set; } = true;
        public int QuickStackNearbyRadius { get; set; } = 5;

        public Config() { }
        public Config(Config previousConfig)
        {
            EnableQuickStackHotkey = previousConfig.EnableQuickStackHotkey;
            EnableDepositAllHotkey = previousConfig.EnableDepositAllHotkey;
            EnableWithdrawAllHotkey = previousConfig.EnableWithdrawAllHotkey;
            QuickStackNearbyRadius = previousConfig.QuickStackNearbyRadius;
        }
    }
}
