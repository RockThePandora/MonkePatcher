# MonkePatcher
MonkePatcher is a patching tool built on top of QuestPatcher that aims to resolve the major issues encountered when modding Gorilla Tag on the Quest/Quest2 platform. Since QuestPatcher is a more generic patching tool, it is not well equipped to deal with the "unique" problems the "illicit" mod developer in the Gorilla Tag community presents. I believe a specialised tool could and should be more well armed to deal with these issues.

## Features (WIP)
- Patching
- Mod Verification
- Hash Checking (maybe)
- In-Headset Support (you don't need a PC)

## How will MonkePatcher resolve the issues encountered?
These solutions are WIP but I believe it is the best move going forward

**These solutions will not make cheating completely impossible, it simply makes installing them for the average user much harder. Any cheats that do get through can always be publicly reported**

### Problem 1 - 'People posting "unlocked" mods which work in public lobbies'
The solution here is that MonkePatcher will only install "verified mods" - Mods that are verified to be not malignant or hacky.
Verified mods do not have to be serious mods; they can be meme mods. There just needs to be proof that they are not illicit or cheat mods.

A good way of automating this would be providing a GithHub action script which submits a qmod that we can guaruntee was compiled from the available source code.
We could also skip some source code checking for some mods from trusted developers.

### Problem 2 - 'the distributing of a tag gun mod by a cheater who has been rampaging the (discord) server with several alts'
This is one of the easier problems to solve; since these mods won't be verified, they won't be installable. However if the verification process gets dropped we can simply blacklist the hashed qmod.
