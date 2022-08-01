using Twilio.Rest.Api.V2010.Account;

namespace SendSMSWithTwillo.Services
{
    public interface ISMSService
    {
        MessageResource Send(string MobileNumber, string body);

    }
}
