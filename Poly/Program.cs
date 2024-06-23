using Poly;

//Example Useing Normal IF 
OldIF notificationService = new();
notificationService.SendNotification("Email", "Hello aia Email");
notificationService.SendNotification("SMS", "Hello via SMS");
notificationService.SendNotification("Push", "Hello via Push");



Console.ReadLine();
