namespace Poly;

public class OldIF
{
    public void SendNotification(string notificationType, string message)
    {
        if (notificationType == "Email")
        {
            SendEmail(message);
        }
        else if (notificationType == "SMS")
        {
            SendSms(message);
        }
        else if (notificationType == "Push")
        {
            SendPush(message);
        }
    }

    void SendPush(string message)
    {
        //Push Code
        Console.WriteLine("Send Push :" + message);
    }

    void SendSms(string message)
    {
        //SMS Code
        Console.WriteLine("Send SMS :" + message);
    }

    void SendEmail(string message)
    {
        //Email Code
        Console.WriteLine("Send Email :" + message);
    }
}