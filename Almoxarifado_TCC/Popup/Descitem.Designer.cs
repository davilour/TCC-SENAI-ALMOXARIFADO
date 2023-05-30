﻿namespace Almoxarifado_TCC.Popup
{
    partial class Descitem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.iconDesc = new FontAwesome.Sharp.IconPictureBox();
            this.PanelItem = new System.Windows.Forms.Panel();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuantTotal = new System.Windows.Forms.Label();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.LinkLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hora_desc = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconDesc)).BeginInit();
            this.PanelItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconDesc
            // 
            this.iconDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconDesc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconDesc.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.iconDesc.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconDesc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDesc.IconSize = 80;
            this.iconDesc.Location = new System.Drawing.Point(54, 37);
            this.iconDesc.Name = "iconDesc";
            this.iconDesc.Size = new System.Drawing.Size(80, 80);
            this.iconDesc.TabIndex = 12;
            this.iconDesc.TabStop = false;
            // 
            // PanelItem
            // 
            this.PanelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.PanelItem.Controls.Add(this.txtObs);
            this.PanelItem.Controls.Add(this.panel2);
            this.PanelItem.Controls.Add(this.lblQuantTotal);
            this.PanelItem.Controls.Add(this.btnMax);
            this.PanelItem.Controls.Add(this.btnMinus);
            this.PanelItem.Controls.Add(this.label1);
            this.PanelItem.Controls.Add(this.panel5);
            this.PanelItem.Controls.Add(this.txtQuant);
            this.PanelItem.Controls.Add(this.txtDescricao);
            this.PanelItem.Controls.Add(this.panel3);
            this.PanelItem.Controls.Add(this.btnCancelar);
            this.PanelItem.Controls.Add(this.txtNome);
            this.PanelItem.Controls.Add(this.btnDescartar);
            this.PanelItem.Controls.Add(this.panel1);
            this.PanelItem.Location = new System.Drawing.Point(2, 149);
            this.PanelItem.Margin = new System.Windows.Forms.Padding(0);
            this.PanelItem.Name = "PanelItem";
            this.PanelItem.Size = new System.Drawing.Size(189, 334);
            this.PanelItem.TabIndex = 13;
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObs.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtObs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtObs.Location = new System.Drawing.Point(28, 211);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(133, 17);
            this.txtObs.TabIndex = 33;
            this.txtObs.Text = "Obs";
            this.txtObs.Enter += new System.EventHandler(this.txtObs_Enter);
            this.txtObs.Leave += new System.EventHandler(this.txtObs_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(28, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 2);
            this.panel2.TabIndex = 34;
            // 
            // lblQuantTotal
            // 
            this.lblQuantTotal.AutoSize = true;
            this.lblQuantTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lblQuantTotal.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.lblQuantTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuantTotal.Location = new System.Drawing.Point(118, 135);
            this.lblQuantTotal.Name = "lblQuantTotal";
            this.lblQuantTotal.Size = new System.Drawing.Size(32, 17);
            this.lblQuantTotal.TabIndex = 32;
            this.lblQuantTotal.Text = "****";
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnMax.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 20;
            this.btnMax.Location = new System.Drawing.Point(129, 165);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(23, 23);
            this.btnMax.TabIndex = 31;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Maroon;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinus.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinus.IconSize = 20;
            this.btnMinus.Location = new System.Drawing.Point(34, 165);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(23, 23);
            this.btnMinus.TabIndex = 30;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(33, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Quantidade:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(63, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 2);
            this.panel5.TabIndex = 27;
            // 
            // txtQuant
            // 
            this.txtQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuant.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtQuant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtQuant.Location = new System.Drawing.Point(63, 168);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(60, 17);
            this.txtQuant.TabIndex = 3;
            this.txtQuant.Text = "0";
            this.txtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDescricao.Location = new System.Drawing.Point(28, 81);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(133, 17);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.Text = "Descrição";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(28, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 2);
            this.panel3.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(70, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(42, 12);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TabStop = true;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCancelar_LinkClicked);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNome.Location = new System.Drawing.Point(28, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(133, 17);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome";
            // 
            // btnDescartar
            // 
            this.btnDescartar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.btnDescartar.FlatAppearance.BorderSize = 0;
            this.btnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescartar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDescartar.Location = new System.Drawing.Point(56, 272);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(75, 23);
            this.btnDescartar.TabIndex = 5;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = false;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(28, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 2);
            this.panel1.TabIndex = 7;
            // 
            // hora_desc
            // 
            this.hora_desc.Tick += new System.EventHandler(this.hora_desc_Tick);
            // 
            // Descitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(193, 485);
            this.Controls.Add(this.iconDesc);
            this.Controls.Add(this.PanelItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Descitem";
            this.Text = "Descitem";
            this.Load += new System.EventHandler(this.Descitem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconDesc)).EndInit();
            this.PanelItem.ResumeLayout(false);
            this.PanelItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconDesc;
        private System.Windows.Forms.Panel PanelItem;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnMinus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel btnCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuantTotal;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer hora_desc;
    }
}