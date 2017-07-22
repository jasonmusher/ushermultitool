[InstallShield Silent]
Version=v7.00
File=Response File
[File Transfer]
OverwrittenReadOnly=NoToAll
[{132F7D38-FA45-11D5-BDC3-00104B938A09}-DlgOrder]
Dlg0={132F7D38-FA45-11D5-BDC3-00104B938A09}-SdWelcome-0
Count=10
Dlg1={132F7D38-FA45-11D5-BDC3-00104B938A09}-SdLicense-0
Dlg2={132F7D38-FA45-11D5-BDC3-00104B938A09}-SdAskDestPath-0
Dlg3={132F7D38-FA45-11D5-BDC3-00104B938A09}-SdShowDlgEdit1-0
Dlg4={132F7D38-FA45-11D5-BDC3-00104B938A09}-SdFinish-0
Dlg5={132F7D38-FA45-11D5-BDC3-00104B938A09}-AskOptions-0
Dlg6={132F7D38-FA45-11D5-BDC3-00104B938A09}-SdShowDlgEdit1-1
Dlg7={132F7D38-FA45-11D5-BDC3-00104B938A09}-SdShowDlgEdit1-2
Dlg8={132F7D38-FA45-11D5-BDC3-00104B938A09}-SdShowDlgEdit1-3
Dlg9={132F7D38-FA45-11D5-BDC3-00104B938A09}-SdShowDlgEdit1-4
[{132F7D38-FA45-11D5-BDC3-00104B938A09}-SdWelcome-0]
Result=1
[{132F7D38-FA45-11D5-BDC3-00104B938A09}-SdLicense-0]
Result=1
[{132F7D38-FA45-11D5-BDC3-00104B938A09}-SdAskDestPath-0]
; --------------------------
; Change this line for the installation directory.
; szDir=<install dir>
; --------------------------
szDir=C:\Program Files (x86)\OPNET
Result=1
[{132F7D38-FA45-11D5-BDC3-00104B938A09}-SdShowDlgEdit1-0]
; --------------------------
; Change this line for the Application Capture port number.
; szEdit1=<port number>
; --------------------------
szEdit1=27401
Result=1
[Application]
Name=OPNET Application Capture Agent 3.9
Version=3.9
Company=OPNET Technologies
Lang=0009
[{132F7D38-FA45-11D5-BDC3-00104B938A09}-SdShowDlgEdit1-1]
; --------------------------
; Set szEdit1=TRUE to automatically uninstall the prior installation of WinPcap installed by Agent, if detected. 
; Set szEdit1=FALSE to not uninstall the prior installation of WinPcap installed by the agent, if detected.  
; szEdit1=[TRUE|FALSE]
; --------------------------
szEdit1=TRUE
Result=1
[{132F7D38-FA45-11D5-BDC3-00104B938A09}-SdFinish-0]
Result=1
bOpt1=0
bOpt2=0
[{132F7D38-FA45-11D5-BDC3-00104B938A09}-AskOptions-0]
Result=1
; ---------------------
; Change Application Capture Agent Service to automatic or manual mode.
; Sel-0=1 & Sel-1=0 : for Automatic
; Sel-0=0 & Sel-1=1 : for Manual
; ---------------------
Sel-0=1
Sel-1=0
[{646192E7-325F-4AE4-B322-BFFE4688468B}-DlgOrder]
Count=0
