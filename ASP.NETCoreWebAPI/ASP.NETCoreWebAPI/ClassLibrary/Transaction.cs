﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Transaction
    {
        private DateTime date = DateTime.MaxValue;
        private int idCar;
        private decimal debit;
        public DateTime _date
        {
            get { return date; }
            set
            {
                if (value != null)
                    date = value;
            }
        }
        public int _idCar
        {
            get
            {
                return idCar;
            }
        }

        public decimal _debit
        {
            get; set;
        }

        public Transaction(int _idCar, decimal _sum)
        {
            date = DateTime.Now;
            idCar = _idCar;
            debit = _sum;
        }
    }
}
