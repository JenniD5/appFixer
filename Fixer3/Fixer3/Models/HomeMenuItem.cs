using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer3.Models
{
    public enum MenuItemType
    {

        Home,
        Notifications,
        Mensajes,
        Intereses,
        Configuracion
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
