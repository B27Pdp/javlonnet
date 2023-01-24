﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OOP_10.uyga_vazifa_enum._3_masala_tg;

/* Laptop klass, record, struct hosil qiling va unga,
Ram - (init)readonly, 
Memory ,
CPU - (init)readonly, 
Model - (init)readonly , 
Color - enum va (init)readonly xossalarini va 
On(), 
Off(), 
Restart() */
namespace OOP_10.uyga_vazifa_enum._3_masala_tg
{
    internal class Laptop_Class
    {
        public byte _RAM { get; init; }
        public int _memory { get; set; } 
        public byte _CPU { get; init; }
        public string _model { get; init; }
        public Colors  _color { get; init; }
        public void On()
        {
            Console.WriteLine("Computer burned");
        }
        public void Off()
        {
            Console.WriteLine("Computer turned off");
        }
        public void Restart()
        {
            Console.WriteLine("Computer rebooted");
        }

        public Laptop_Class(byte rAM, int memory, byte cPU, string model,Colors color )
        {
            _RAM = rAM;
            _memory = memory;
            _CPU = cPU;
            _model = model;
            _color = color;
        }
    }
    public enum Colors
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black,
        White,
        Gray,
    }
}
