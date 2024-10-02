using Hackaton.Application.Contracts.Services.Email;
using System.Net.Mail;
using System.Net;

namespace Hackaton.Infrastructure.Services.Email
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            // Configurações do e-mail
            string remetente = "email@email.com";

            // Configurações do servidor SMTP
            string smtpServidor = "smtp.gmail.com";
            int smtpPorta = 587;
            string usuario = "email@email.com";
            string senha = "suaSenha";

            // Criação da mensagem
            MailMessage mensagem = new MailMessage(remetente, email);
            mensagem.Subject = subject;
            mensagem.Body = message;
            mensagem.IsBodyHtml = false; // Define como true se o corpo do e-mail contiver HTML

            // Configuração do cliente SMTP
            SmtpClient smtpClient = new SmtpClient(smtpServidor, smtpPorta);
            smtpClient.Credentials = new NetworkCredential(usuario, senha);
            smtpClient.EnableSsl = true;

            // Envio do e-mail
            //smtpClient.Send(mensagem);
        }
    }
}