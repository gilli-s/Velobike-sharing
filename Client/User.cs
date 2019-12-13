﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Client
{
    [DataContract]
    public class User
    {
        //Поля
        private string username;
        private string fio;
        private DateTime birthday;
        private string passport;
        private string card;
        private string password;
        //конструктор для ввода полей
        public User(string _username, string _fio , DateTime _birthday,string _passport, string _card,string _password)
        {
            Username = _username;
            FIO = _fio;
            Birthday = _birthday;
            Passport = _passport;
            Card = _card;
            Password = _password;
        }
        //Свойства 
        [DataMember]
        public string Password { get => password; set => password = value; }
        [DataMember]
        public string Username {
            get
            {
                return username;
            }
            set
            {
                
                    this.username = value;
            
            }
        }
        [DataMember]
        public string FIO {
            get
            {
                return fio;
            }
            set
            {
                
                    this.fio = value;
               
                
            }
        }
        [DataMember]
        public DateTime Birthday { get; set; }
        [DataMember]
        public string Passport { get; set; }
        [DataMember]
        public string Card { get; set; }
       
    }
}
