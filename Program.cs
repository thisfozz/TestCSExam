﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginNamespace;
using UserRegistrationNamespace;

namespace TestCSExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration registration = new UserRegistration();
            Login login = new Login();

            Console.WriteLine("1. Регистрация нового пользователя");
            Console.WriteLine("2. Вход");
            Console.WriteLine("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите логин:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Введите пароль:");
                    string password = Console.ReadLine();
                    Console.WriteLine("Введите дату рождения (дд-мм-гггг):");
                    DateTime birthdate = DateTime.Parse(Console.ReadLine());

                    registration.Register(username, password, birthdate);
                    break;
                case "2":
                    login.LoginUser();
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }

            Console.ReadLine();
        }
    }
}