﻿
using BatchLabs.Max2016.Plugin.Common;
using BatchLabs.Max2016.Plugin.Max;

namespace BatchLabs.Max2016.Plugin
{
    public class ManageDataAction : ActionBase
    {
        public override void InternalExecute()
        {            
            var coreInterface = MaxGlobalInterface.Instance.COREInterface16;
            coreInterface.PushPrompt("Calling out to data UI in BatchLabs");
            Log.Instance.Debug("Calling out to data UI in BatchLabs");

            LabsRequestHandler.CallBatchLabs("data");
        }

        public override string InternalActionText => "Manage Your Job Data";
    }
}