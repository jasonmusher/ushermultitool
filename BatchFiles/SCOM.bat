rmdir "C:\Temp\scom" /S /Q
pushd \\tsclient\C\My_Files\Files\64bit\
XCOPY \\tsclient\C\My_Files\Files\64bit\x64_SCOM_2012_Agent\* C:\Temp\scom /s /i
c:
cd C:\Temp\scom
start SCOM.bat
pause
rmdir "C:\Temp\scom" /S /Q