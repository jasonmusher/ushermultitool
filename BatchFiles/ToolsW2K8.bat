rmdir "C:\Temp\Tools_W2K8\" /S /Q
pushd \\tsclient\C\My_Files\Files\both\
XCOPY \\tsclient\C\My_Files\Files\both\Tools_W2K8\* C:\Temp\Tools_W2K8\ /s /i
c:
cd C:\Temp\Tools_W2K8\
start ToolsW2K8.bat
pause
rmdir "C:\Temp\Tools_W2K8\" /S /Q