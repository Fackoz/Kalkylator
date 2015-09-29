namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.buttonOne = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaProgrammetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klippUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klistraInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOne.Location = new System.Drawing.Point(12, 196);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(35, 35);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.button_click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(12, 47);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(158, 20);
            this.textBox_result.TabIndex = 1;
            this.textBox_result.Text = "0";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menyToolStripMenuItem,
            this.redigeraToolStripMenuItem,
            this.hjälpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(182, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menyToolStripMenuItem
            // 
            this.menyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avslutaProgrammetToolStripMenuItem});
            this.menyToolStripMenuItem.Name = "menyToolStripMenuItem";
            this.menyToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.menyToolStripMenuItem.Text = "Arkiv";
            this.menyToolStripMenuItem.Click += new System.EventHandler(this.menyToolStripMenuItem_Click);
            // 
            // avslutaProgrammetToolStripMenuItem
            // 
            this.avslutaProgrammetToolStripMenuItem.Name = "avslutaProgrammetToolStripMenuItem";
            this.avslutaProgrammetToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.avslutaProgrammetToolStripMenuItem.Text = "Avsluta programmet";
            this.avslutaProgrammetToolStripMenuItem.Click += new System.EventHandler(this.avslutaProgrammetToolStripMenuItem_Click);
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klippUtToolStripMenuItem,
            this.klistraInToolStripMenuItem});
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // klippUtToolStripMenuItem
            // 
            this.klippUtToolStripMenuItem.Name = "klippUtToolStripMenuItem";
            this.klippUtToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.klippUtToolStripMenuItem.Text = "Klipp ut";
            // 
            // klistraInToolStripMenuItem
            // 
            this.klistraInToolStripMenuItem.Name = "klistraInToolStripMenuItem";
            this.klistraInToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.klistraInToolStripMenuItem.Text = "Klistra in";
            // 
            // hjälpToolStripMenuItem
            // 
            this.hjälpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explorerToolStripMenuItem});
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.hjälpToolStripMenuItem.Text = "Hjälp";
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.explorerToolStripMenuItem.Text = "Utforskare";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTwo.Location = new System.Drawing.Point(53, 196);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(35, 35);
            this.buttonTwo.TabIndex = 3;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.button_click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFour.Location = new System.Drawing.Point(12, 155);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(35, 35);
            this.buttonFour.TabIndex = 5;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.button_click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFive.Location = new System.Drawing.Point(53, 155);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(35, 35);
            this.buttonFive.TabIndex = 6;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.button_click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSix.Location = new System.Drawing.Point(94, 155);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(35, 35);
            this.buttonSix.TabIndex = 7;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.button_click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSeven.Location = new System.Drawing.Point(12, 114);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(35, 35);
            this.buttonSeven.TabIndex = 8;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.button_click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEight.Location = new System.Drawing.Point(53, 114);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(35, 35);
            this.buttonEight.TabIndex = 9;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.button_click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNine.Location = new System.Drawing.Point(94, 114);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(35, 35);
            this.buttonNine.TabIndex = 10;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.button_click);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonZero.Location = new System.Drawing.Point(12, 237);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(76, 35);
            this.buttonZero.TabIndex = 11;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.button_click);
            // 
            // buttonComma
            // 
            this.buttonComma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonComma.Location = new System.Drawing.Point(94, 237);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(35, 35);
            this.buttonComma.TabIndex = 13;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = false;
            this.buttonComma.Click += new System.EventHandler(this.button_click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMinus.Location = new System.Drawing.Point(53, 73);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(35, 35);
            this.buttonMinus.TabIndex = 14;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlus.Location = new System.Drawing.Point(12, 73);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(35, 35);
            this.buttonPlus.TabIndex = 15;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEquals.Location = new System.Drawing.Point(135, 196);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(35, 76);
            this.buttonEquals.TabIndex = 17;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMultiply.Location = new System.Drawing.Point(94, 73);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(35, 35);
            this.buttonMultiply.TabIndex = 18;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDivision.Location = new System.Drawing.Point(135, 73);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(35, 35);
            this.buttonDivision.TabIndex = 19;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClear.Location = new System.Drawing.Point(135, 114);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(35, 35);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.Control;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCurrentOperation.Location = new System.Drawing.Point(15, 31);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 16);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClearEntry.Location = new System.Drawing.Point(135, 155);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(35, 35);
            this.buttonClearEntry.TabIndex = 22;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            this.buttonClearEntry.Click += new System.EventHandler(this.buttonClearEntry_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonThree.Location = new System.Drawing.Point(94, 196);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(35, 35);
            this.buttonThree.TabIndex = 23;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(182, 293);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonComma);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kalkylator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaProgrammetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klippUtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klistraInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
    }
}

