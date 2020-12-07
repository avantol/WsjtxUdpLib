# WsjtxUdpLib
.NET Standard library for unpacking WSJT-X UDP datagrams

So far, this branch adds the capability to send various 
messages *to* WSJT-X.

Several additional classes
(HaltMessage, ClearMessage, ReplyMessage, FreeTexMessage) 
now implement GetBytes(), which is required for creating
inbound UDP packets to WSJT-X. These methods were previously 
"not implemented yet".
