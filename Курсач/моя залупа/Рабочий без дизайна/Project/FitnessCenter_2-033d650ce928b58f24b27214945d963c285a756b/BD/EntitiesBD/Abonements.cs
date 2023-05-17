﻿using FitnessCenter.BD.EntitiesBD.Repositories;
using FitnessCenter.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.BD.EntitiesBD
{
    public class Abonements : ObservableObject
    {
        private Guid _id;
        private string? _title;
        private int? _age;
        private string? _validity;
        private string? _visitingTime;
        private int? _amount;
        private int? _price;
        private string? _photo;

        public override string ToString()
        {
            return $"<b>Название:</b> {_title}<br>" +
                    $"<b>Возраст:</b> {_age}<br>" +
                    $"<b>Срок действия:</b> {_validity}<br>" +
                    $"<b>Время посещения:</b> {_visitingTime}<br>" +
                    $"<b>Доступное количество:</b> {_amount}<br>" +
                    $"<b>Стоимость:</b> {_price}<br>";
        }

        
        public Guid Id
        {
            get => _id; 

            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }
        public string? Title
        {
            get => _title;

            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }
        public int? Age 
        {
            get => _age;

            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }
        public string? Validity 
        {
            get => _validity;

            set
            {
                _validity = value;
                OnPropertyChanged("Validity");
            }
        }
        public string? VisitingTime 
        {
            get => _visitingTime;

            set
            {
                _visitingTime = value;
                OnPropertyChanged("VisitingTime");
            }
        }
        public int? Amount 
        {
            get => _amount;

            set
            {
                _amount = value;
                OnPropertyChanged("Amount");
            }
        }

        public string? Photo 
        {
            get => _photo;

            set
            {
                _photo = value;
                OnPropertyChanged("Photo");
            }
        }

        public int? Price 
        {
            get => _price;

            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }


        private ObservableCollection<Services>? _services = new ObservableCollection<Services>();
        public virtual ICollection<Orders>? Orders { get; set; }



        public virtual ObservableCollection<Services>? Services 
        {
            get => _services;

            set
            {
                _services = value;
                OnPropertyChanged("Services");
            }
        }

        public void ResetData(Abonements some)
        {
            Id = some.Id;
            Title = some.Title;
            Age = some.Age;
            Validity = some.Validity;
            VisitingTime = some.VisitingTime;
            Amount = some.Amount;

            Price = some.Price;
            Photo = some.Photo;
        }

        public bool AbonementsEquals(Abonements obj)
        {
            if (
                Id == obj.Id &&
            Title == obj.Title &&
            Age == obj.Age &&
            Validity == obj.Validity &&
            VisitingTime == obj.VisitingTime &&
            Amount == obj.Amount &&

            Price == obj.Price &&
            Photo == obj.Photo

            //Services.SequenceEqual(obj.Services)
                ) 
            {
                return true;
            }

            return false;
        }
    }
}
