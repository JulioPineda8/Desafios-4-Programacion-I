using System;

public interface INotificable
{
    void Notificar();
}

public class NotificacionEmail : INotificable
{
    private string DireccionEmail;

    public NotificacionEmail(string email)
    {
        this.DireccionEmail = email;
    }

    public void Notificar()
    {
        Console.WriteLine("SE ENVIO UNA NOTIFICACION POR CORREO ELECTRONICO A: " + DireccionEmail);

    }
}
public class NotificacionSMS : INotificable
{
    private string NumeroTelefono;

    public NotificacionSMS(string numeroTelefono)
    {
        this.NumeroTelefono = numeroTelefono;
    }

    public void Notificar()
    {
        Console.WriteLine("SE HA ENVIADO UN SMS AL NUMERO: " + NumeroTelefono);

    }
}
class Program
{
    static void Main(string[] args)
    {
        NotificacionSMS notificacionSMS = new NotificacionSMS("4363-0548");
        notificacionSMS.Notificar();

        NotificacionEmail notificacionEmail = new NotificacionEmail("jpinedad5@miumg.edu.gt");
        notificacionEmail.Notificar();

    }
}
