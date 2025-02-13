using U4_S1_D4.Models;

Utente utente1 = new Utente("mario.rossi", "123456");

OperazioniAccesso(utente1);

static void OperazioniAccesso(Utente utente)
{
    Console.WriteLine("\r\n===============OPERAZIONI==============\r\nScegli l'operazione da effettuare:\r\n1.: Login\r\n2.: Logout\r\n3.: Verifica ora e data di login\r\n4.: Lista degli accessi\r\n5.: Esci\r\n=======================================\r\n");
    string scelta = Console.ReadLine();
    if (scelta == "1")
    {
        if (utente.IsLogged == false)
        {
            Console.Write("\r\nInserisci username: ");
            string username = Console.ReadLine();
            Console.Write("\r\nInserisci password: ");
            string password = Console.ReadLine();
            utente.Login(username, password);
            OperazioniAccesso(utente);
        }
        else
        {
            Console.WriteLine("\r\nSei già loggato!");
            OperazioniAccesso(utente);
        }
    }
    else if (scelta == "2")
    {
        utente.Logout();
        OperazioniAccesso(utente);
    }
    else if (scelta == "3")
    {
        utente.VerificaAccesso();
        OperazioniAccesso(utente);
    }
    else if (scelta == "4")
    {
        utente.ListaAccessi();
        OperazioniAccesso(utente);
    }
    else if (scelta == "5")
    {
        Console.WriteLine("\r\nArrivederci!");
    }
    else
    {
        Console.WriteLine("\r\nScelta non valida!");
        OperazioniAccesso(utente);
    }
}
