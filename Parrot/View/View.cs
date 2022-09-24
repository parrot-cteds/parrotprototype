﻿using Parrot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot.ViewActivity
{
    public class View
    {
       public static void ViewUsers(List<User> usersList)
        {
            Console.WriteLine("Lista de usuários: \n");
            foreach (var user in usersList)
            {
                Console.WriteLine($"Usuário: {user.Name} - Lingua nativa: {user.NativeLanguage} - Email: {user.Email}");
            }
            return;
        }

        public static void showchat(string sender, string receiver)
        {
            list<string> chat = new list<string>();
            chat = getchat(sender, receiver);
            console.writeline($"conversa entre {sender} e {receiver}: \n");
            foreach (var item in chat)
            {
                console.writeline(item);
            }
        }
    }

    
}
