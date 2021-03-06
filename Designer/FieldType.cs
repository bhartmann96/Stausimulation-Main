﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Designer
{
    public partial class FieldType : Form
    {
        FormMain fr;
        public FieldType(FormMain f)
        {
            fr = f;
            InitializeComponent();
        }

        string result;

        private void cBoxNorden_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxNorden.Checked)
                txtNorden.Enabled = true;
            else
                txtNorden.Enabled = false;

            if (cBoxNorden.Checked || cBoxOsten.Checked || cBoxSüden.Checked || cBoxWesten.Checked)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }
        private void cBoxOsten_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxOsten.Checked)
                txtOsten.Enabled = true;
            else
                txtOsten.Enabled = false;

            if (cBoxNorden.Checked || cBoxOsten.Checked || cBoxSüden.Checked || cBoxWesten.Checked)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }
        private void cBoxSüden_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxSüden.Checked)
                txtSüden.Enabled = true;
            else
                txtSüden.Enabled = false;

            if (cBoxNorden.Checked || cBoxOsten.Checked || cBoxSüden.Checked || cBoxWesten.Checked)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }
        private void cBoxWesten_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxWesten.Checked)
                txtWesten.Enabled = true;
            else
                txtWesten.Enabled = false;

            if (cBoxNorden.Checked || cBoxOsten.Checked || cBoxSüden.Checked || cBoxWesten.Checked)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (combField.Text == "Unterscheidungsfeld")
                result += "U,";
            else if (combField.Text == "Spawnfeld")
                result += "S,";
            else if (combField.Text == "Despawnfeld")
                result += "D,";
            else
            {
                MessageBox.Show("Feld nicht bekannt");
                return;
            }

            if (cBoxNorden.Checked)
            {
                result += "N>" + txtNorden.Text + ",";
            }
            if (cBoxOsten.Checked)
            {
                result += "O>" + txtOsten.Text + ",";
            }
            if (cBoxSüden.Checked)
            {
                result += "S>" + txtSüden.Text + ",";
            }
            if (cBoxWesten.Checked)
            {
                result += "W>" + txtWesten.Text + ",";
            }

            if (result != null)
            {
                fr.Str_map[fr.Pos.X, fr.Pos.Y] = result;
                fr.Bit_map.SetPixel(fr.Pos.X, fr.Pos.Y, Color.Black);                  

                this.Close();
            }
            else
                return;
        }
    }
}
