﻿using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome To AddressBook Management");

            Contacts person = new Contacts();
            AddressBook.AddContact();
            AddressBook.ContactsDisplay();
            AddressBook.EditContact();
            AddressBook.ContactsDisplay();
        }
    }
}