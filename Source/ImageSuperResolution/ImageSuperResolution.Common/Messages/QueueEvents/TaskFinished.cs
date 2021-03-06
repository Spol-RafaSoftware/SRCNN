﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ImageSuperResolution.Common.Messages.QueueEvents
{
    public class TaskFinished: QueueMessageBase
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public TimeSpan ElapsedTime { get; set; }

        public byte[] Image { get; set; }
    }
}
