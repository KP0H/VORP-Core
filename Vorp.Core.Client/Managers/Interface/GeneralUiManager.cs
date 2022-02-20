﻿using System.Threading.Tasks;
using Vorp.Core.Client.RedM.Enums;

namespace Vorp.Core.Client.Managers.Interface
{
    public class GeneralUiManager : Manager<GeneralUiManager>
    {
        public override void Begin()
        {
            
        }

        [TickHandler(SessionWait = true)]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private async Task OnDisableHud()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            API.DisableControlAction(0, (uint)eControls.HudSpecial, true);
            API.DisableControlAction(0, (uint)eControls.RevealHud, true);
        }
    }
}
