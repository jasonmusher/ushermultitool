rmdir "C:\Temp\sccm" /S /Q
pushd \\tsclient\C\My_Files\Files\Both\
XCOPY \\tsclient\C\My_Files\Files\Both\sccm\* C:\Temp\sccm /s /i
c:
cd C:\Temp\sccm
start ManualIn-P01.bat
pause
rmdir "C:\Temp\sccm" /S /Q
