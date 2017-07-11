﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreensRepo.Models
{
    public class Menu
    {
        public Menu() {
            MenuItemList = new List<MenuItem>();
            MenuItem mainView = new MenuItem("Main");
            MenuItemList.Add(mainView);
            MenuItem otherView = new MenuItem("Other");
            MenuItemList.Add(otherView);
            MenuItem recordView = new MenuItem("Record");
            MenuItemList.Add(recordView);

        }

        public List<MenuItem> MenuItemList { get; }
        static Menu instance;
        public static Menu Instance
        {
            get
            {
                if (instance == null)
                    instance = new Menu();
                return instance;
            }

        }
    }
}