﻿namespace GaleriaZwierzat
{
    partial class Gallery
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonAddPicture = new Button();
            panelPicture = new Panel();
            panelTitle = new Panel();
            textBoxTitle = new TextBox();
            buttonCancelTitle = new Button();
            buttonSaveTitle = new Button();
            buttonSavePicture = new Button();
            buttonCancelPicture = new Button();
            buttonUploadPicture = new Button();
            buttonAddTitle = new Button();
            panelPicture.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(426, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonAddPicture
            // 
            buttonAddPicture.Location = new Point(515, 36);
            buttonAddPicture.Name = "buttonAddPicture";
            buttonAddPicture.Size = new Size(136, 29);
            buttonAddPicture.TabIndex = 1;
            buttonAddPicture.Text = "dodaj zdjęcie";
            buttonAddPicture.UseVisualStyleBackColor = true;
            buttonAddPicture.Click += buttonAddPicture_Click;
            // 
            // panelPicture
            // 
            panelPicture.Controls.Add(panelTitle);
            panelPicture.Controls.Add(buttonSavePicture);
            panelPicture.Controls.Add(buttonCancelPicture);
            panelPicture.Controls.Add(buttonUploadPicture);
            panelPicture.Controls.Add(buttonAddTitle);
            panelPicture.Location = new Point(459, 116);
            panelPicture.Name = "panelPicture";
            panelPicture.Size = new Size(250, 297);
            panelPicture.TabIndex = 2;
            panelPicture.Visible = false;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(textBoxTitle);
            panelTitle.Controls.Add(buttonCancelTitle);
            panelTitle.Controls.Add(buttonSaveTitle);
            panelTitle.Location = new Point(30, 66);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(197, 113);
            panelTitle.TabIndex = 4;
            panelTitle.Visible = false;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(26, 16);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(125, 27);
            textBoxTitle.TabIndex = 4;
            // 
            // buttonCancelTitle
            // 
            buttonCancelTitle.Location = new Point(100, 68);
            buttonCancelTitle.Name = "buttonCancelTitle";
            buttonCancelTitle.Size = new Size(81, 29);
            buttonCancelTitle.TabIndex = 3;
            buttonCancelTitle.Text = "anuluj";
            buttonCancelTitle.UseVisualStyleBackColor = true;
            buttonCancelTitle.Click += buttonCancelTitle_Click;
            // 
            // buttonSaveTitle
            // 
            buttonSaveTitle.Location = new Point(15, 68);
            buttonSaveTitle.Name = "buttonSaveTitle";
            buttonSaveTitle.Size = new Size(79, 29);
            buttonSaveTitle.TabIndex = 3;
            buttonSaveTitle.Text = "zapisz";
            buttonSaveTitle.UseVisualStyleBackColor = true;
            buttonSaveTitle.Click += buttonSaveTitle_Click;
            // 
            // buttonSavePicture
            // 
            buttonSavePicture.Location = new Point(21, 250);
            buttonSavePicture.Name = "buttonSavePicture";
            buttonSavePicture.Size = new Size(79, 29);
            buttonSavePicture.TabIndex = 3;
            buttonSavePicture.Text = "zapisz";
            buttonSavePicture.UseVisualStyleBackColor = true;
            buttonSavePicture.Click += buttonSavePicture_Click;
            // 
            // buttonCancelPicture
            // 
            buttonCancelPicture.Location = new Point(130, 250);
            buttonCancelPicture.Name = "buttonCancelPicture";
            buttonCancelPicture.Size = new Size(97, 29);
            buttonCancelPicture.TabIndex = 3;
            buttonCancelPicture.Text = "anuluj";
            buttonCancelPicture.UseVisualStyleBackColor = true;
            buttonCancelPicture.Click += buttonCancelPicture_Click;
            // 
            // buttonUploadPicture
            // 
            buttonUploadPicture.Location = new Point(56, 201);
            buttonUploadPicture.Name = "buttonUploadPicture";
            buttonUploadPicture.Size = new Size(136, 29);
            buttonUploadPicture.TabIndex = 3;
            buttonUploadPicture.Text = "wgraj zdjęcie";
            buttonUploadPicture.UseVisualStyleBackColor = true;
            buttonUploadPicture.Click += buttonUploadPicture_Click;
            // 
            // buttonAddTitle
            // 
            buttonAddTitle.Location = new Point(53, 19);
            buttonAddTitle.Name = "buttonAddTitle";
            buttonAddTitle.Size = new Size(136, 29);
            buttonAddTitle.TabIndex = 3;
            buttonAddTitle.Text = "dodaj tytuł";
            buttonAddTitle.UseVisualStyleBackColor = true;
            buttonAddTitle.Click += buttonAddTitle_Click;
            // 
            // Gallery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPicture);
            Controls.Add(buttonAddPicture);
            Controls.Add(tableLayoutPanel1);
            Name = "Gallery";
            Text = "Galeria Zwierząt";
            panelPicture.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAddPicture;
        private Panel panelPicture;
        private Button buttonAddTitle;
        private Panel panelTitle;
        private TextBox textBoxTitle;
        private Button buttonCancelTitle;
        private Button buttonSaveTitle;
        private Button buttonSavePicture;
        private Button buttonCancelPicture;
        private Button buttonUploadPicture;
    }
}