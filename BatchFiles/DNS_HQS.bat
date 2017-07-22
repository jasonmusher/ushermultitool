@ECHO OFF
SETLOCAL EnableDelayedExpansion

SET adapterName=

FOR /F "tokens=* delims=:" %%a IN ('IPCONFIG ^| FIND /I "ETHERNET ADAPTER"') DO (
SET adapterName=%%a

REM Removes "Ethernet adapter" from the front of the adapter name
SET adapterName=!adapterName:~17!

REM Removes the colon from the end of the adapter name
SET adapterName=!adapterName:~0,-1!

netsh interface ip delete dns name="!adapterName!" all
netsh interface ipv4 set dns name="!adapterName!" static 10.192.224.196 primary
netsh interface ip add dns name="!adapterName!" 10.162.192.15 index=2
netsh interface ip add dns name="!adapterName!" 57.22.97.201 index=3
)
ipconfig /flushdns
EXIT