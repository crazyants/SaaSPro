﻿namespace SaaSPro.Infrastructure.Configuration
{
    public interface IApplicationSettings
    {
        string APIKey { get; }
        string MailServer { get; }
        string MailUserName { get; }
        string MailPassword { get; }
        bool MailSSL { get; }
        bool SendEmail { get; }
        string SendEmailTo { get; }
        bool EnableOptimizations { get; }
    }
}
