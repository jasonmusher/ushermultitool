On Error resume next 
Const ForReading = 1

Set objFSO = CreateObject("Scripting.FileSystemObject")
Set objTextFile = objFSO.OpenTextFile _
    ("C:\Temp\server.txt", ForReading)

Do Until objTextFile.AtEndOfStream
    strComputer = objTextFile.Readline
'strComputer = "."
Set objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")

 

Set objNetworkSettings = objWMIService.Get("Win32_NetworkAdapterConfiguration")

arrDNSSuffixes = Array("global.ual.com", "nam.coair.com", "ual.com")

objNetworkSettings.SetDNSSuffixSearchOrder(arrDNSSuffixes)

loop 

WScript.ECHO "Script complete. DNS Suffix are now assigned"