﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerSoporte.Cache
{
    public static class UserLoginCache
    {
        // User
        public static int IdUser { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Priveleges { get; set; }
        public static string RespuestaSecurity { get; set; }
        public static int isRoot { get; set; }
        
        // Employee
        public static string Nombre { get; set; }
        public static string Nombre_Corto { get; set; }
        public static string City { get; set; }
        public static string Email { get; set; }
        public static DateTime Fecha_nacimiento { get; set; }
        public static DateTime Fecha_UltimoAcceso { get; set; }
        public static int imageDefault { get; set; }
    }
}