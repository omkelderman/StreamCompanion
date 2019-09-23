# Creating outputs

In the end we want to create some useful data that can be used elsewhere. That's what `Output Patterns` are for. These will be saved as txt files in `Files` folder (see "SC files save location" button in general tab) or depending on `!Tokens!` used, as in-memory files for with you'll need OBS plugin to read from.    

`Output Patterns` should be always composed by one or several `!Tokens!` that correspond to specific value (map title/artist/current hit counts etc.)  
::: tip Full list of available tokens can be always displayed inside SC   
You can also edit output of each `!Token!`. Refer to [C# string.Format][stringFormatDocs] docs ({0} is token value).
<!--TODO?: Maybe replace image below to show example string.format usage instead of just linking docs  -->

![Tokens example][ExampleTokens]  
:::

## Output Patterns tab
![Output patterns tab][OutputPatterns]  

Click on any entry on list to edit it in fields below.  
`Save event` defines when specific pattern should be filled. **In other words, if you are currently playing ingame and `Output Pattern` event is set to `Listening` - that pattern will be wiped(empty file).**  

After editing a pattern remember to save it, as they are **not** saved automatically.  
&nbsp;    
&nbsp;    

::: tip
New `Output Patterns` will create their corresponding files on first save attempt.
:::
::: warning 
"show in osu!" will appear only if you have installed ingame-overlay plugin
:::

[ExampleTokens]: <./img/ExampleTokens.png>
[OutputPatterns]: <./img/OutputPatterns.png>
[stringFormatDocs]: <https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings>