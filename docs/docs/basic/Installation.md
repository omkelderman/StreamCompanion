# Installation steps

1. Grab latest setup exe from [github releases page][dlLink], and proceed with installation by accepting terms and selecting install directory.

2. After successful installation you should be greeted with screen that looks like this:  
![Msn setup][MSNSetup]  
Read, and follow instructions in that window, If you still have trouble figuring what you should do on this step look [inside this link for steps][osuEnableMSN]

3. Next setup step ensures that osu! memory reading with is required for example for pp calculation is working properly - Select requested beatmap and __exact mods__ in-game and start playing. At that point you can minimize osu!(it will pause), and setup should finish shortly. 

::: warning
If for whatever reason it haven't completed successfully, ensure that when you change beatmap in osu! value highlighted below updates. 

![Memory setup][memoryDebugInfo] 

If it stays on default `---` there is a good chance that SC is getting sandboxed by your antivirus.
:::

[dlLink]: <https://github.com/Piotrekol/StreamCompanion/releases/latest>
[MSNSetup]: <./img/MSNSetup.png>
[memoryDebugInfo]: <./img/memoryDebugInfo.png>
<!--
TODO: EnableMSN image link
[osuEnableMSN]: <./img/dummy.png>
-->
