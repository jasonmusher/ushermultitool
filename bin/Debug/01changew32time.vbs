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



Set oReg=GetObject("winmgmts:{impersonationLevel=impersonate}!\\" & strComputer & "\root\default:StdRegProv")
strKeyPath = "System\CurrentControlSet\Services\W32Time\TimeProviders\VMICTimeProvider"
oReg.SetDwordValue HKEY_LOCAL_MACHINE,strKeyPath,"Enabled", 0





oReg.SetDWORDValue HKEY_LOCAL_MACHINE, strKeyPath, strValueName


End If 
Loop

WScript.ECHO "Script complete. w32time is now updated to 0"
