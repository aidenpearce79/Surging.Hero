﻿namespace Surging.Core.CPlatform.Messages
{
    /// <summary>
    /// 远程调用结果消息。
    /// </summary>
    public class RemoteInvokeResultMessage
    {
        /// <summary>
        /// 异常消息。
        /// </summary>
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        public StatusCode StatusCode { get; set; } = StatusCode.OK;
        /// <summary>
        /// 结果内容。
        /// </summary>
        public object Result { get; set; }
    }
}