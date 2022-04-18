# MonkePatcher
MonkePatcher is a patching tool built on top of QuestPatcher that aims to resolve the major issues encountered when modding Gorilla Tag on the Quest/Quest2 platform. Since QuestPatcher is a more generic patching tool, it is not well equipped to deal with the "unique" problems the "illicit" mod developer in the Gorilla Tag community presents. I believe a specialised tool could and should be more well armed to deal with these issues.

## Features (WIP)
- Patching
- Mod Verification
- Hash Checking (maybe)
- In-Headset Support (you don't need a PC)

## How will MonkePatcher resolve the issues encountered?
These solutions are WIP but I believe it is the best move going forward

### Problem 1 - 'People posting "unlocked" mods which work in public lobbies'
The solution here is that MonkePatcher will only install "verified mods" - Mods that are verified to be not malignant or hacky.
Verified mods do not have to be serious mods; they can be meme mods. There just needs to be proof that they are not illicit or cheat mods.

At the time of writing this the current verification stage is that the mods source code will be submitted and inspected. The inspection may not be necesarry if the mod author is "trusted". The source code will then be compiled into a qmod and hashed to ensure nobody uploads fake mods that are "unlocked".

### Problem 2 - 'the distributing of a tag gun mod by a cheater who has been rampaging the (discord) server with several alts'
This is one of the easier problems to solve; since these mods won't be verified, they won't be installable. However if the verification process gets dropped we can simply blacklist the hashed qmod.
