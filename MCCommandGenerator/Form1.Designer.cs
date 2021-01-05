using System;
using System.Windows.Forms;

namespace MCCommandGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        private void InitializeComponent()
        {
            comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.AlphaLabel = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(MCCommandGenerator.Text.Commands);
            comboBox1.Location = new System.Drawing.Point(93, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(119, 21);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Command:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Use";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UseBtnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click on a textbox and press \"F1\" to display some help.";
            //
            // AlphaLabel
            //
            this.AlphaLabel.AutoSize = true;
            this.AlphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AlphaLabel.Location = new System.Drawing.Point(3, 100);
            this.AlphaLabel.Name = "AlphaLabel";
            this.AlphaLabel.Size = new System.Drawing.Size(277, 13);
            this.AlphaLabel.TabIndex = 2;
            this.AlphaLabel.Text = "Note: This is an early-alpha version of the program.\nIt is far from being complete. It cannot even generate anything yet.\nSo until this is finished, you may want to use another generator.";
            //
            // helpProvider1
            //
            this.helpProvider1.SetShowHelp(comboBox1, true);
            this.helpProvider1.SetHelpString(comboBox1, "Select a command.\nNot much else to say about this.");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlphaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Minecraft Command Generator";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void CheckForCommand()
        {
            switch (comboBox1.Text)
            {
                case "advancement":
                    radioButton1 = new System.Windows.Forms.RadioButton();
                    radioButton1.AutoSize = true;
                    radioButton1.Location = new System.Drawing.Point(230, 21);
                    radioButton1.Name = "radioButton1";
                    radioButton1.Size = new System.Drawing.Size(85, 17);
                    radioButton1.TabIndex = 2;
                    radioButton1.TabStop = true;
                    radioButton1.Text = "give";
                    radioButton1.UseVisualStyleBackColor = true;
                    this.Controls.Add(radioButton1);

                    radioButton2 = new System.Windows.Forms.RadioButton();
                    radioButton2.AutoSize = true;
                    radioButton2.Location = new System.Drawing.Point(290, 21);
                    radioButton2.Name = "radioButton2";
                    radioButton2.Size = new System.Drawing.Size(85, 17);
                    radioButton2.TabIndex = 3;
                    radioButton2.TabStop = true;
                    radioButton2.Text = "remove";
                    radioButton2.UseVisualStyleBackColor = true;
                    this.Controls.Add(radioButton2);

                    this.button2 = new System.Windows.Forms.Button();
                    this.button2.Location = new System.Drawing.Point(480,19);
                    this.button2.Name = "button2";
                    this.button2.Size = new System.Drawing.Size(75, 23);
                    this.button2.Text = "Edit";
                    this.button2.UseVisualStyleBackColor = true;
                    this.button2.Click += new EventHandler(SelectorsBtnClick);
                    this.Controls.Add(this.button2);

                    this.label3 = new System.Windows.Forms.Label();
                    this.label3.AutoSize = true;
                    this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                    this.label3.Location = new System.Drawing.Point(360, 21);
                    this.label3.Name = "label2";
                    this.label3.Size = new System.Drawing.Size(75, 17);
                    this.label3.TabIndex = 1;
                    this.label3.Text = "Selector:";
                    this.Controls.Add(this.label3);

                    comboBox2 = new System.Windows.Forms.ComboBox();
                    this.helpProvider1.SetShowHelp(comboBox2, true);
                    this.helpProvider1.SetHelpString(comboBox2, "Select a selector and click \"Edit\" to edit the parameters.\nYou can only select one selector.\n@a - Every player\n@e - Every entity\n@p - The nearest player\n@r - A random player\n@s - The entity executing the command");
                    comboBox2.FormattingEnabled = true;
                    comboBox2.Items.AddRange(MCCommandGenerator.Text.Selectors);
                    comboBox2.Location = new System.Drawing.Point(424, 20);
                    comboBox2.Name = "comboBox2";
                    comboBox2.Size = new System.Drawing.Size(48, 21);
                    comboBox2.TabIndex = 1;
                    this.Controls.Add(comboBox2);

                    checkBox1.AutoSize = true;
                    checkBox1.Location = new System.Drawing.Point(580, 23);
                    checkBox1.Name = "checkBox1";
                    checkBox1.Size = new System.Drawing.Size(80, 17);
                    checkBox1.TabIndex = 25;
                    checkBox1.Text = "Show advancements";
                    checkBox1.Click += new EventHandler(CheckBox1Changed);
                    if (MCCommandGenerator.Values.AdvancementShowAdvancements == true) checkBox1.Checked = true;
                    else checkBox1.Checked = false;
                    checkBox1.UseVisualStyleBackColor = true;
                    this.Controls.Add(checkBox1);

                    checkBox2.AutoSize = true;
                    checkBox2.Location = new System.Drawing.Point(730, 23);
                    checkBox2.Name = "checkBox2";
                    checkBox2.Size = new System.Drawing.Size(80, 17);
                    checkBox2.TabIndex = 25;
                    checkBox2.Text = "Show Recipes";
                    checkBox2.Click += new EventHandler(CheckBox2Changed);
                    if (MCCommandGenerator.Values.AdvancementShowRecipes == true) checkBox2.Checked = true;
                    else checkBox2.Checked = false;
                    checkBox2.UseVisualStyleBackColor = true;
                    this.Controls.Add(checkBox2);
                    break;
                default:
                    MessageBox.Show("This command is not supported yet. Please wait for a new release.", "No", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        private void UseBtnClick(object sender, EventArgs e)
        {
            CheckForCommand();
        }
        private void SelectorsBtnClick(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "@a":
                    SelectorControl.CurrentSelector = 1;
                    if (SelectorControl.Changed()) SelectorControl.ResetAll();
                    SelectorA s = new SelectorA();
                    s.Show();
                    break;
                case "@e":
                    SelectorControl.CurrentSelector = 2;
                    if (SelectorControl.Changed()) SelectorControl.ResetAll();
                    SelectorE f = new SelectorE();
                    f.Show();
                    break;
                case "@p":
                    SelectorControl.CurrentSelector = 3;
                    if (SelectorControl.Changed()) SelectorControl.ResetAll();
                    SelectorA a = new SelectorA();
                    a.Show();
                    break;
                case "@r":
                    SelectorControl.CurrentSelector = 4;
                    if (SelectorControl.Changed()) SelectorControl.ResetAll();
                    SelectorA b = new SelectorA();
                    b.Show();
                    break;
                case "@s":
                    SelectorControl.CurrentSelector = 5;
                    if (SelectorControl.Changed()) SelectorControl.ResetAll();
                    SelectorE c = new SelectorE();
                    c.Show();
                    break;
                default: break;
            }
        }
        private void CheckBox1Changed(object sender, EventArgs e)
        {
            if (checkBox1.Checked) checkBox2.Checked = false;
        }
        private void CheckBox2Changed(object sender, EventArgs e)
        {
            if (checkBox2.Checked) checkBox1.Checked = false;
        }

        #endregion

        public static System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        public static System.Windows.Forms.RadioButton radioButton1;
        public static System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        public static System.Windows.Forms.ComboBox comboBox2;
        public static System.Windows.Forms.CheckBox checkBox1;
        public static System.Windows.Forms.CheckBox checkBox2;

        private System.Windows.Forms.Label AlphaLabel;
    }
}

