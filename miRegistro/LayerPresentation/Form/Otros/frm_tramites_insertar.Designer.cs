﻿namespace LayerPresentation
{
    partial class frm_tramites_insertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tramites_insertar));
            this.barra_titulo = new System.Windows.Forms.Panel();
            this.lbl_tittle = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.comboBox_tipoError = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_procesados = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_empleados = new System.Windows.Forms.ComboBox();
            this.dateTime_fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_tramites = new System.Windows.Forms.ComboBox();
            this.textBox_dominio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_observaciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_errores = new System.Windows.Forms.CheckBox();
            this.barra_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // barra_titulo
            // 
            this.barra_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.barra_titulo.Controls.Add(this.lbl_tittle);
            this.barra_titulo.Controls.Add(this.btn_close);
            this.barra_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra_titulo.Location = new System.Drawing.Point(0, 0);
            this.barra_titulo.Name = "barra_titulo";
            this.barra_titulo.Size = new System.Drawing.Size(365, 32);
            this.barra_titulo.TabIndex = 1;
            this.barra_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_titulo_MouseDown);
            // 
            // lbl_tittle
            // 
            this.lbl_tittle.AutoSize = true;
            this.lbl_tittle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tittle.Location = new System.Drawing.Point(62, 6);
            this.lbl_tittle.Name = "lbl_tittle";
            this.lbl_tittle.Size = new System.Drawing.Size(213, 21);
            this.lbl_tittle.TabIndex = 8;
            this.lbl_tittle.Text = "Ingresar un nuevo tramite";
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::LayerPresentation.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Location = new System.Drawing.Point(342, 7);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(17, 19);
            this.btn_close.TabIndex = 3;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // comboBox_tipoError
            // 
            this.comboBox_tipoError.BackColor = System.Drawing.Color.White;
            this.comboBox_tipoError.DisplayMember = "Nombre";
            this.comboBox_tipoError.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_tipoError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipoError.FormattingEnabled = true;
            this.comboBox_tipoError.Location = new System.Drawing.Point(55, 333);
            this.comboBox_tipoError.Name = "comboBox_tipoError";
            this.comboBox_tipoError.Size = new System.Drawing.Size(118, 25);
            this.comboBox_tipoError.TabIndex = 1;
            this.comboBox_tipoError.ValueMember = "Cod_Errores";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(179, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 16);
            this.label9.TabIndex = 70;
            this.label9.Text = "*Seleccione en caso de error\r\n";
            // 
            // checkBox_procesados
            // 
            this.checkBox_procesados.AutoSize = true;
            this.checkBox_procesados.Checked = true;
            this.checkBox_procesados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_procesados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_procesados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_procesados.Location = new System.Drawing.Point(56, 262);
            this.checkBox_procesados.Name = "checkBox_procesados";
            this.checkBox_procesados.Size = new System.Drawing.Size(246, 21);
            this.checkBox_procesados.TabIndex = 69;
            this.checkBox_procesados.Text = "Tramites en la etapa (Procesados)";
            this.checkBox_procesados.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(57, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingrese una fecha ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(52, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Seleccione en caso de error";
            // 
            // comboBox_empleados
            // 
            this.comboBox_empleados.DisplayMember = "Nombre";
            this.comboBox_empleados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_empleados.FormattingEnabled = true;
            this.comboBox_empleados.Location = new System.Drawing.Point(53, 212);
            this.comboBox_empleados.Name = "comboBox_empleados";
            this.comboBox_empleados.Size = new System.Drawing.Size(252, 25);
            this.comboBox_empleados.TabIndex = 66;
            this.comboBox_empleados.ValueMember = "Cod_empleado";
            // 
            // dateTime_fecha
            // 
            this.dateTime_fecha.CustomFormat = "MM/dd/yyyy";
            this.dateTime_fecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_fecha.Location = new System.Drawing.Point(53, 115);
            this.dateTime_fecha.Name = "dateTime_fecha";
            this.dateTime_fecha.Size = new System.Drawing.Size(252, 23);
            this.dateTime_fecha.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(53, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Seleccione la etapa";
            // 
            // comboBox_tramites
            // 
            this.comboBox_tramites.DisplayMember = "Nombre";
            this.comboBox_tramites.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tramites.FormattingEnabled = true;
            this.comboBox_tramites.Location = new System.Drawing.Point(53, 162);
            this.comboBox_tramites.Name = "comboBox_tramites";
            this.comboBox_tramites.Size = new System.Drawing.Size(252, 25);
            this.comboBox_tramites.TabIndex = 61;
            this.comboBox_tramites.ValueMember = "Cod_tipo";
            // 
            // textBox_dominio
            // 
            this.textBox_dominio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dominio.Location = new System.Drawing.Point(53, 67);
            this.textBox_dominio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox_dominio.Name = "textBox_dominio";
            this.textBox_dominio.Size = new System.Drawing.Size(252, 22);
            this.textBox_dominio.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(51, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccione el nombre del empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(57, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingrese el dominio (Ej: \"AA032XT\")";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(53, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seleccione el nombre del tramite";
            // 
            // btn_cargar
            // 
            this.btn_cargar.BackColor = System.Drawing.Color.White;
            this.btn_cargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.btn_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cargar.Image = global::LayerPresentation.Properties.Resources.upload;
            this.btn_cargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cargar.Location = new System.Drawing.Point(49, 490);
            this.btn_cargar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.btn_cargar.Size = new System.Drawing.Size(253, 28);
            this.btn_cargar.TabIndex = 75;
            this.btn_cargar.Text = "Añadir nuevo tramite";
            this.btn_cargar.UseVisualStyleBackColor = false;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(48, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 16);
            this.label11.TabIndex = 77;
            this.label11.Text = "*Especifique en caso de error u otra observacion";
            // 
            // textBox_observaciones
            // 
            this.textBox_observaciones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_observaciones.Location = new System.Drawing.Point(51, 409);
            this.textBox_observaciones.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox_observaciones.Multiline = true;
            this.textBox_observaciones.Name = "textBox_observaciones";
            this.textBox_observaciones.Size = new System.Drawing.Size(251, 74);
            this.textBox_observaciones.TabIndex = 74;
            this.textBox_observaciones.Text = "No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(51, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 76;
            this.label8.Text = "Observaciones";
            // 
            // checkBox_errores
            // 
            this.checkBox_errores.AutoSize = true;
            this.checkBox_errores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_errores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_errores.Location = new System.Drawing.Point(56, 308);
            this.checkBox_errores.Name = "checkBox_errores";
            this.checkBox_errores.Size = new System.Drawing.Size(74, 21);
            this.checkBox_errores.TabIndex = 78;
            this.checkBox_errores.Text = "Error/es";
            this.checkBox_errores.UseVisualStyleBackColor = true;
            // 
            // frm_tramites_insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 529);
            this.Controls.Add(this.checkBox_errores);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_observaciones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_tipoError);
            this.Controls.Add(this.barra_titulo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_dominio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_procesados);
            this.Controls.Add(this.dateTime_fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_tramites);
            this.Controls.Add(this.comboBox_empleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_tramites_insertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_tramites_insertar";
            this.Load += new System.EventHandler(this.frm_tramites_insertar_Load);
            this.barra_titulo.ResumeLayout(false);
            this.barra_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barra_titulo;
        private System.Windows.Forms.Label lbl_tittle;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.ComboBox comboBox_tipoError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_procesados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_empleados;
        public System.Windows.Forms.DateTimePicker dateTime_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_tramites;
        private System.Windows.Forms.TextBox textBox_dominio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_observaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_errores;
    }
}