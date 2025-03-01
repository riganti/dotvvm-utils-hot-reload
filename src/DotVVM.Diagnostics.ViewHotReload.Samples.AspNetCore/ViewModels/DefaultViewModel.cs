﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;

namespace DotVVM.Diagnostics.ViewHotReload.Samples.AspNetCore.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
		public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

		public DefaultViewModel()
		{
			Title = "Hello from DotVVM!";
		}

        public void ChangeTitle()
        {
            Title = $"This is {FirstName} {LastName}!";
        }
    }
}
