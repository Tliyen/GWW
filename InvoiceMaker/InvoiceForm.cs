﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMaker
{
    public partial class InvoiceForm : Form
    {
        String[] a = new String[50];
        int i = 0;
        public InvoiceForm()
        {
            InitializeComponent();
            int x = 30;
            int y = 80;
            
            /*
            Panel p = new Panel();
            p.Size = new Size(950, 550);
            p.Location = new Point(25, 25);
            this.Controls.Add(p);
            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { p.VerticalScroll.Value = vScrollBar1.Value; };
            p.Controls.Add(vScrollBar1);
            */

            Label qtyLabel = new Label();
            qtyLabel.Text = "Qty";
            qtyLabel.Location = new Point(x, y);
            qtyLabel.AutoSize = true;
            qtyLabel.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(qtyLabel);

            Label itemNoLabel = new Label();
            itemNoLabel.Text = "Item Number";
            itemNoLabel.Location = new Point(x+50, y);
            itemNoLabel.AutoSize = true;
            itemNoLabel.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(itemNoLabel);

            Label descLabel = new Label();
            descLabel.Text = "Description";
            descLabel.Location = new Point(x+170, y);
            descLabel.AutoSize = true;
            descLabel.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(descLabel);

            Label costLabel = new Label();
            costLabel.Text = "Cost";
            costLabel.Location = new Point(x + 390, y);
            costLabel.AutoSize = true;
            costLabel.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(costLabel);

            Label amountLabel = new Label();
            amountLabel.Text = "Amount";
            amountLabel.Location = new Point(x + 460, y);
            amountLabel.AutoSize = true;
            amountLabel.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(amountLabel);

            
            TextBox qty = new TextBox();
            qty.Location = new Point(0, 0 + i * 25);
            qty.Size = new Size(30, 25);
            qty.Name = "qty" + i;
            qty.TextChanged += Qty_TextChanged;
            qty.AccessibleName = "" + i;
            panel1.Controls.Add(qty);

            ComboBox itemNumber = new ComboBox();
            itemNumber.Location = new Point(50, 0 + i * 25);
            itemNumber.Size = new Size(100, 25);
            itemNumber.TextUpdate += C_TextUpdated;
            itemNumber.TextChanged += C_TextChanged;
            itemNumber.Name = "itemNumber" + i;
            itemNumber.AccessibleName = "" + i;
            panel1.Controls.Add(itemNumber);

            TextBox desc = new TextBox();
            desc.Location = new Point(170, 0 + i * 25);
            desc.Size = new Size(200, 25);
            desc.ReadOnly = true;
            desc.Enter += Desc_Enter;
            desc.Name = "desc" + i;
            desc.AccessibleName = "" + i;
            panel1.Controls.Add(desc);

            TextBox cost = new TextBox();
            cost.Location = new Point(390, 0 + i * 25);
            cost.Size = new Size(50, 25);
            cost.ReadOnly = true;
            cost.Enter += Desc_Enter;
            cost.Name = "cost" + i;
            cost.AccessibleName = "" + i;
            panel1.Controls.Add(cost);

            TextBox amount = new TextBox();
            amount.Location = new Point(460, 0 + i * 25);
            amount.Size = new Size(50, 25);
            amount.ReadOnly = true;
            amount.Enter += Desc_Enter;
            amount.Name = "amount" + i;
            amount.AccessibleName = "" + i;
            panel1.Controls.Add(amount);

            

        }

        private void Qty_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            this.panel1.Controls["amount" + t.AccessibleName].Text = "amount here";

            if(Int32.Parse(t.AccessibleName) == i)
            {
                i++;
                TextBox qty = new TextBox();
                qty.Location = new Point(0, 0 + i * 25);
                qty.Size = new Size(30, 25);
                qty.Name = "qty" + i;
                qty.TextChanged += Qty_TextChanged;
                qty.AccessibleName = "" + i;
                panel1.Controls.Add(qty);

                ComboBox itemNumber = new ComboBox();
                itemNumber.Location = new Point(50, 0 + i * 25);
                itemNumber.Size = new Size(100, 25);
                itemNumber.TextUpdate += C_TextUpdated;
                itemNumber.TextChanged += C_TextChanged;
                itemNumber.Name = "itemNumber" + i;
                itemNumber.AccessibleName = "" + i;
                panel1.Controls.Add(itemNumber);

                TextBox desc = new TextBox();
                desc.Location = new Point(170, 0 + i * 25);
                desc.Size = new Size(200, 25);
                desc.ReadOnly = true;
                desc.Enter += Desc_Enter;
                desc.Name = "desc" + i;
                desc.AccessibleName = "" + i;
                panel1.Controls.Add(desc);

                TextBox cost = new TextBox();
                cost.Location = new Point(390, 0 + i * 25);
                cost.Size = new Size(50, 25);
                cost.ReadOnly = true;
                cost.Enter += Desc_Enter;
                cost.Name = "cost" + i;
                cost.AccessibleName = "" + i;
                panel1.Controls.Add(cost);

                TextBox amount = new TextBox();
                amount.Location = new Point(460, 0 + i * 25);
                amount.Size = new Size(50, 25);
                amount.ReadOnly = true;
                amount.Enter += Desc_Enter;
                amount.Name = "amount" + i;
                amount.AccessibleName = "" + i;
                panel1.Controls.Add(amount);
            }
        }

        private void C_TextChanged(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            this.panel1.Controls["desc" + c.AccessibleName].Text = "description here";
            this.panel1.Controls["cost" + c.AccessibleName].Text = "cost here";
            this.panel1.Controls["amount" + c.AccessibleName].Text = "amount here";
        }

        private void Desc_Enter(object sender, EventArgs e)
        {
            
            SendKeys.Send("{TAB}");
        }

        private void C_TextUpdated(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            c.DroppedDown = true;

            c.Items.Clear();
            c.SelectionLength = 0;

            c.SelectionStart = c.Text.Length;

            c.Items.AddRange(new object[] {
            "212",
            "212a",
            "10222",
            "10222a",
            "101"});

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}