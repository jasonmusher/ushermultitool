rmdir "C:\Temp\x64_Tools_W2K12\" /S /Q
pushd \\tsclient\C\My_Files\Files\64bit\
XCOPY \\tsclient\C\My_Files\Files\64bit\x64_Tools_W2K12\* C:\Temp\x64_Tools_W2K12\ /s /i
c:
cd C:\Temp\x64_Tools_W2K12\
start ToolsW2K12.bat
pause
rmdir "C:\Temp\x64_Tools_W2K12\" /S /Q