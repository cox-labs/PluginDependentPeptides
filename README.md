# PluginDependentPeptides

Perseus plugin for importing dependent peptide search results
from [MaxQuant](https://www.biochem.mpg.de/5111795/maxquant).
Requires [PluginInterop](https://github.com/jdrudolph/PluginInterop)
and [Python](https://www.python.org/) with
[perseuspy](https://www.github.com/jdrudolph/perseuspy) installed.

For questions and bug reports please use the [issue](https://github.com/jdrudolph/plugindependentpeptides/issues) system.

## Installation

`PluginDependentPeptides` can be downloaded from the
Perseus [plugin store](http://www.coxdocs.org/doku.php?id=perseus:user:plugins:store#available_plugins), along side its dependency `PluginInterop`.

For latests builds you require to have [Visual Studio](https://www.visualstudio.com/downloads/).

## Frequently asked questions

1. **Where can I find the `rawFilesTable.txt` file?** First load your project in MaxQuant.
   Now in the 'Raw files' tab right click the table and choose `Plain matrix export...`.
   ![rawFilesTable.txt](/img/rawfilestable.png)

## Plugin development guide

You can find a plugin development guide on [github](https://github.com/jdrudolph/PluginTutorial).
