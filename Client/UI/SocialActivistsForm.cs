﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SocialActivistsForm : Form
    {
        public SocialActivistsForm(string name, int id)
        {
            InitializeComponent();
            UserName.Text = name;
        }

       
    }
}
