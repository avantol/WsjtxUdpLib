﻿namespace M0LTE.WsjtxUdpLib.Messages
{
    public class StatusMessage : WsjtxMessage
    {
        /*
         * Status        Out       1                      quint32
         *                         Id (unique key)        utf8
         *                         Dial Frequency (Hz)    quint64
         *                         Mode                   utf8
         *                         DX call                utf8
         *                         Report                 utf8
         *                         Tx Mode                utf8
         *                         Tx Enabled             bool
         *                         Transmitting           bool
         *                         Decoding               bool
         *                         Rx DF                  quint32
         *                         Tx DF                  quint32
         *                         DE call                utf8
         *                         DE grid                utf8
         *                         DX grid                utf8
         *                         Tx Watchdog            bool
         *                         Sub-mode               utf8
         *                         Fast mode              bool
         *                         Special Operation Mode quint8
         *                         Frequency Tolerance    quint32
         *                         T/R Period             quint32
         *                         Configuration Name     utf8
         *
         *    WSJT-X  sends this  status message  when various  internal state
         *    changes to allow the server to  track the relevant state of each
         *    client without the need for  polling commands. The current state
         *    changes that generate status messages are:
         *
         *      Application start up,
         *      "Enable Tx" button status changes,
         *      dial frequency changes,
         *      changes to the "DX Call" field,
         *      operating mode, sub-mode or fast mode changes,
         *      transmit mode changed (in dual JT9+JT65 mode),
         *      changes to the "Rpt" spinner,
         *      after an old decodes replay sequence (see Replay below),
         *      when switching between Tx and Rx mode,
         *      at the start and end of decoding,
         *      when the Rx DF changes,
         *      when the Tx DF changes,
         *      when settings are exited,
         *      when the DX call or grid changes,
         *      when the Tx watchdog is set or reset,
         *      when the frequency tolerance is changed,
         *      when the T/R period is changed,
         *      when the configuration name changes.
         *
         *    The Special operation mode is  an enumeration that indicates the
         *    setting  selected  in  the  WSJT-X  "Settings->Advanced->Special
         *    operating activity" panel. The values are as follows:
         *
         *       0 -> NONE
         *       1 -> NA VHF
         *       2 -> EU VHF
         *       3 -> FIELD DAY
         *       4 -> RTTY RU
         *       5 -> WW DIGI
         *       6 -> FOX
         *       7 -> HOUND
         *
         *    The Frequency Tolerance  and T/R period fields may  have a value
         *    of  the maximum  quint32 value  which implies  the field  is not
         *    applicable.
         */
        public static new WsjtxMessage Parse(byte[] message)
        {
            return null;
        }
    }
}