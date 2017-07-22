rmdir "C:\Temp\x64_SEP_No_NTP_12.1.6_MP5" /S /Q
pushd \\tsclient\C\My_Files\Files\64bit\
XCOPY \\tsclient\C\My_Files\Files\64bit\x64_SEP_No_NTP_12.1.6_MP5\* C:\Temp\x64_SEP_No_NTP_12.1.6_MP5 /s /i
c:
cd C:\Temp\x64_SEP_No_NTP_12.1.6_MP5
start Sep64.msi
pause
rmdir "C:\Temp\x64_SEP_No_NTP_12.1.6_MP5" /S /Q