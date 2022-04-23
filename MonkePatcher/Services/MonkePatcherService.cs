using QuestPatcher.Core;
using System;

namespace MonkePatcher.Services
{
    internal class MonkePatcherService : QuestPatcherService
    {
        public MonkePatcherService() : base(new UIPrompter())
        {

        }

        protected override void ExitApplication()
        {
            throw new NotImplementedException();
        }
    }
}
