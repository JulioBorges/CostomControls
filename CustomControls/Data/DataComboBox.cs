﻿using System.ComponentModel;
using System.Windows.Forms;
using CustomControls.Contract;

namespace CustomControls.Data
{
    public partial class DataComboBox : ComboBox, IData
    {
        public DataComboBox()
        {
            InitializeComponent();
        }

        #region Implementation of IData

        [Category("Dados")]
        [Description("Campo da base de dados a ser ligado ao componente")]
        public string Campo { get; set; }

        [Category("Dados")]
        [Description("Propriedade do componente a ser ligada")]
        public string Propriedade { get; set; }

        [Category("Dados")]
        [Description("Binding que é a fonte dos dados")]
        public BindingSource FonteDados { get; set; }

        #endregion
    }
}