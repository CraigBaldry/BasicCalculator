// 
// Author: Craig Baldry M203210 
// Create Date: 1/08/18
// Version Control: 1.0
//
namespace Calculator
{
    partial class CalculatorForm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSQRT = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMakesNegative = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(42, 34);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 42);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(179, 20);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = "0";
            this.txtDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDisplay_KeyPress);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 69);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 35);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(80, 69);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 35);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(149, 69);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 35);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(149, 110);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(42, 34);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(80, 110);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 34);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 110);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 34);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(149, 150);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 39);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(80, 150);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 39);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 150);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(42, 39);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(80, 195);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(42, 34);
            this.btnZero.TabIndex = 11;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(12, 195);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(42, 34);
            this.btnDecimal.TabIndex = 12;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(209, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(209, 69);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(42, 35);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(209, 109);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(42, 35);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(209, 150);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(42, 35);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(209, 195);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(42, 81);
            this.btnEqual.TabIndex = 17;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // btnSQRT
            // 
            this.btnSQRT.Location = new System.Drawing.Point(268, 27);
            this.btnSQRT.Name = "btnSQRT";
            this.btnSQRT.Size = new System.Drawing.Size(56, 35);
            this.btnSQRT.TabIndex = 18;
            this.btnSQRT.Text = "SQRT";
            this.btnSQRT.UseVisualStyleBackColor = true;
            this.btnSQRT.Click += new System.EventHandler(this.BtnSQRT_Click);
            // 
            // btnCube
            // 
            this.btnCube.Location = new System.Drawing.Point(268, 69);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(56, 35);
            this.btnCube.TabIndex = 19;
            this.btnCube.Text = "CubeRT";
            this.btnCube.UseVisualStyleBackColor = true;
            this.btnCube.Click += new System.EventHandler(this.BtnCube_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(268, 110);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(56, 35);
            this.btnInverse.TabIndex = 20;
            this.btnInverse.Text = "Inv";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.BtnInverse_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(268, 163);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(56, 35);
            this.btnTan.TabIndex = 21;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.BtnTan_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(268, 204);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(56, 35);
            this.btnSin.TabIndex = 22;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.BtnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(268, 241);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(56, 35);
            this.btnCos.TabIndex = 23;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(336, 24);
            this.menu.TabIndex = 24;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitMenuItem,
            this.clearMenuItem});
            this.fileMenuItem.Name = "fileToolStripMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitMenuItem.Name = "quitToolStripMenuItem";
            this.quitMenuItem.Size = new System.Drawing.Size(101, 22);
            this.quitMenuItem.Text = "Quit";
            this.quitMenuItem.Click += new System.EventHandler(this.QuitMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearMenuItem.Name = "clearToolStripMenuItem";
            this.clearMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearMenuItem.Text = "Clear";
            this.clearMenuItem.Click += new System.EventHandler(this.ClearMenuItem_Click);
            // 
            // btnMakesNegative
            // 
            this.btnMakesNegative.Location = new System.Drawing.Point(149, 195);
            this.btnMakesNegative.Name = "btnMakesNegative";
            this.btnMakesNegative.Size = new System.Drawing.Size(42, 34);
            this.btnMakesNegative.TabIndex = 25;
            this.btnMakesNegative.Text = "-";
            this.btnMakesNegative.UseVisualStyleBackColor = true;
            this.btnMakesNegative.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 292);
            this.Controls.Add(this.btnMakesNegative);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.btnSQRT);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSQRT;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.Button btnMakesNegative;
    }
}

