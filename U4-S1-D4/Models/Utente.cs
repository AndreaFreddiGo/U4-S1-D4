using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace U4_S1_D4.Models
{
    public class Utente
    {
        private string Username { get; set; }
        private string Password { get; set; }
        public bool IsLogged { get; set; } = false;
        private DateTime DataOraLogin { get; set; }
        private List<DateTime> Accessi { get; set; } = new List<DateTime>();

        public Utente(string username, string password)
        {
            Username = username;
            Password = password;
      
        }

        public void Login(string Username,string Password) { 
            if (Username == this.Username && Password == this.Password)
            {
                IsLogged = true;
                Console.WriteLine("\r\nLogin effettuato con successo!");
                DataOraLogin = DateTime.Now;
                Accessi.Add(DataOraLogin);
            }
            else
            {
                Console.WriteLine("\r\nUsername o password errati!");
            }
        }


        public void Logout()
        {
            if (IsLogged)
            {
                IsLogged = false;
                Console.WriteLine("\r\nLogout effettuato con successo!");
            }
            else
            {
                Console.WriteLine("\r\nNon sei loggato!");

            }
        }

        public void VerificaAccesso() {
            if (IsLogged)
            {
                Console.WriteLine($"\r\nData e ora di login: {DataOraLogin}");
            }
            else
            {
                Console.WriteLine("\r\nNon sei loggato!");
            }

        }

        public void ListaAccessi() {
            if (IsLogged)
            {
                Console.WriteLine("\r\nLista degli accessi:");
                foreach (var accesso in Accessi)
                {
                    Console.WriteLine(accesso);
                }
            }
            else
            {
                Console.WriteLine("\r\nNon sei loggato!");
            }

        }
    }

}
