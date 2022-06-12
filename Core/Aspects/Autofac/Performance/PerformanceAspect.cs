using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Mail;

namespace Core.Aspects.Autofac.Performance
{
    public class PerformanceAspect : MethodInterception
    {
        private int _interval;
        private Stopwatch _stopwatch;

        public PerformanceAspect(int interval)
        {
            _interval = interval;
            _stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }


        protected override void OnBefore(IInvocation invocation)
        {
            _stopwatch.Start();
        }

        protected override void OnAfter(IInvocation invocation)
        {
            if (_stopwatch.Elapsed.TotalSeconds > _interval)
            {
                string to = "emailto@gmail.com";
                string from = "emailfrom@gmail.com";
                string password = "pass";

                MailMessage message = new MailMessage(from, to);
                message.Subject = "Performans Problemi Hk.";
                message.Body = @$"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}";

                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(from, password);
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Port = 587;

                client.Send(message);
                // Debug.WriteLine($"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}");
            }
            _stopwatch.Reset();
        }
    }
}
