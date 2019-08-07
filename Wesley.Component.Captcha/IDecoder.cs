﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wesley.Component.Captcha.Events;

namespace Wesley.Component.Captcha
{
    /// <summary>
    /// 验证码识别接口
    /// </summary>
    public interface IDecoder
    {
        Task Decode(string filePath);

        event EventHandler<OnErrorEventArgs> OnError;

        event EventHandler<OnStartedEventArgs> OnStart;

        event EventHandler<OnCompletedEventArgs> OnCompleted;
    }
}
