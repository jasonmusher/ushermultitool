On Error resume next 
Const ForReading = 1
 
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set objTextFile = objFSO.OpenTextFile _
    ("C:\Temp\server.txt", ForReading)

Do Until objTextFile.AtEndOfStream
    strComputer = objTextFile.Readline
'strComputer = "."
   Set objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\CIMV2\TerminalServices")
   Set colItems = objWMIService.ExecQuery("SELECT * FROM Win32_TSSessionSetting")
   For Each objItem In colItems
     if objItem.TerminalName = "RDP-Tcp" then
        objItem.TimeLimitPolicy = 0             'ENABLES Connection Override for Time Settings
        objItem.Put_                    'Commits the override so other settings will go through without error
        objItem.TimeLimit "DisconnectedSessionLimit", 3600000       'Disconnected for 1 hour
        objItem.TimeLimit "ActiveSessionLimit", 0           'Never
        objItem.TimeLimit "IdleSessionLimit", 3600000      '1 hour
        objItem.Put_
        objItem.Refresh_
        objItem.BrokenConnectionPolicy = 0                         'ENABLES Connection Override for Broken Connections
        objItem.Put_
        objItem.BrokenConnection 1             'ENDS Broken Connections
        objItem.ReconnectionPolicy = 0          'ENABLES Connection Override for Reconnecting Sessions
        objItem.Put_
     end if
  Next
Loop
WScript.ECHO "Script complete. rdp session settings are now configured."