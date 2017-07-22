rmdir "C:\Temp\x64_NetBackup_7.6" /S /Q
pushd \\tsclient\C\My_Files\Files\64bit\
XCOPY \\tsclient\C\My_Files\Files\64bit\x64_NetBackup_7.6\* C:\Temp\x64_NetBackup_7.6 /s /i
c:
cd C:\Temp\x64_NetBackup_7.6
start silentclient.cmd
pause
rmdir "C:\Temp\x64_NetBackup_7.6" /S /Q