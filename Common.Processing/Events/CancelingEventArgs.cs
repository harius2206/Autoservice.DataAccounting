using System;

namespace Common.Processing.Events {
    public class CancelingEventArgs : EventArgs {
        public bool Cancel { get; set; }
        public string Message { get; set; }
    }
}
