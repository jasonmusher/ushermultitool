On Error resume next 
Const HKEY_LOCAL_MACHINE = &H80000002
' Specify the text file of computerNames.
strFilePath = "C:\Temp\server.txt"

' Open the file for read access.
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set objFile = objFSO.OpenTextFile(strFilePath, 1)

' Read each line of the file and set strComputer.
Do Until objFile.AtEndOfStream
strComputer = Trim(objFile.ReadLine)
If strComputer<> "" Then
On Error Resume Next
Err.Clear
 
 
Set objRegistry = GetObject _
    ("winmgmts:\\" & strComputer & "\root\default:StdRegProv")

strKeyPath = "SOFTWARE\Microsoft\PowerShell\1\ShellIds\Microsoft.PowerShell"
strValueName = "ExecutionPolicy"
strDescription = "Unrestricted"

objRegistry.SetStringValue HKEY_LOCAL_MACHINE, strKeyPath, strValueName, strDescription

End If 
Loop

WScript.ECHO "Script completed. powershell has been set to unrestricted"