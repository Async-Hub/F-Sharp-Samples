#if INTERACTIVE
   #r "Azure.Security.KeyVault.Keys.dll"
#endif

open Azure.Security.KeyVault
open Azure.Security.KeyVault.Keys  

let url = "https://kv-az-exam.vault.azure.net/"
let client = new KeyClient(url, new )