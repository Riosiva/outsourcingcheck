using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TwilioWhatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            TwilioClient.Init("AC5b5d180dedb28ac0068713160b83415f", "ecec103501330dead13a8be97e27f0aa");
            var messageOptions = new CreateMessageOptions(
            new PhoneNumber("whatsapp:+919080669216"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            messageOptions.Body = "Your Yummy Cupcakes Company order of 1 dozen frosted cupcakes has shipped and should be delivered on July 10, 2019. Details: http://www.yummycupcakes.com/";
            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);
            Console.ReadLine();
        }
    }
}
