using Bridge;

var notification1 = new EmailNotification(new PlainTextFormatter());
var notification2 = new PushNotification(new JSONFormatter());
var notification3 = new SMSNotification(new HTMLFormatter());

notification1.Send("Yarik is the best");
notification2.Send("Yarik is the best");
notification3.Send("Yarik is the best");