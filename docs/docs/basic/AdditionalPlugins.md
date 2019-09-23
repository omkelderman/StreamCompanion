# Additional plugins

osu!StreamCompanion comes with a bunch of pre-installed plugins that extend its core functionality. However there are currently 2 official plugins that are not packaged in the SC installer:

## In-game overlay plugin

Due to how in-game overlay plugin works it is not provided in initial installation and has to be added manually by downloading [current newest release][dlLink] and unpacking it to your StreamCompanion folder (by default it's `C:\Program Files (x86)\StreamCompanion` ) like so:  
![l][ingameOverlayDrag] 

### Example use
#### Watching/Playing:
<!--TODO: IMAGE-->
Pattern used:
::: tip 
this pattern uses `\n` as line break directly instead of !lb! (does the same)
:::
```
!mapartisttitle! \n!100!x100 !50!x50 \n!miss!xMiss \nnow:!PpIfMapEndsNow! \nfc: !ppifrestFced! \n!mods! \nx!combo! \nx!currentmaxcombo!
```

#### Song selection:
<!--TODO: IMAGE-->
Pattern used:
```
SS:!SSPP! 99:!99PP! 98:!98PP! 95:!95PP! \n!mmod!: SS:!mSSPP! 99:!m99PP! 98:!m98PP! 95:!m95pp!
```

### TODO: pattern configuration
Any pattern set in StreamCompanion can be shown in overlay. To show it you need to enable it in pattern settings  
<!--TODO: IMAGE-->

1. Shows new window where you can drag your text to correct position on virtual screen.
2. Allows you to change text color in overlay
3. pattern X and Y position - you can also directly edit it there
4. Font to be used to display your pattern on screen
5. Size of the font

::: warning note about pattern editing
Due to various things, to refresh edited pattern on osu! screen you need to:
1. Save pattern
2. Change playing song in osu!
3. Wait up to 5 seconds
:::

### osu! letterboxing
if you use letterboxing you will need to adjust your pattern X and Y positions to be in osu! window range.  
<!--TODO: LETTERBOXING IMAGE-->


## OBS plugin

### TODO: OBS PLUGIN INSTALL





[dlLink]: <https://github.com/Piotrekol/StreamCompanion/releases/latest>
[ingameOverlayDrag]: <./img/ingameOvelayPluginDrag.png>