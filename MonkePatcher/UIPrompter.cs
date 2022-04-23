using QuestPatcher.Core;
using System;
using System.Threading.Tasks;

namespace MonkePatcher
{
    internal class UIPrompter : IUserPrompter
    {
        public Task<bool> Prompt32Bit()
        {
            throw new NotImplementedException();
        }

        public Task<bool> PromptAdbDisconnect(DisconnectionType type)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PromptAppNotInstalled()
        {
            throw new NotImplementedException();
        }

        public Task<bool> PromptPauseBeforeCompile()
        {
            throw new NotImplementedException();
        }

        public Task<bool> PromptUnstrippedUnityUnavailable()
        {
            throw new NotImplementedException();
        }

        public Task PromptUpgradeFromOld()
        {
            throw new NotImplementedException();
        }
    }
}
