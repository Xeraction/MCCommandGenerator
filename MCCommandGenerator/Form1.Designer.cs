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
            this.label2.Location = new System.Drawing.Point(3, 590);
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
            try
            {
                this.Icon = new System.Drawing.Icon("C:/ProgramData/MCCG/icon.ico");
            }
            catch { }
            this.ShowIcon = true;
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
                    this.label3.Name = "label3";
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
                    checkBox1.UseVisualStyleBackColor = true;
                    this.Controls.Add(checkBox1);

                    checkBox2.AutoSize = true;
                    checkBox2.Location = new System.Drawing.Point(730, 23);
                    checkBox2.Name = "checkBox2";
                    checkBox2.Size = new System.Drawing.Size(80, 17);
                    checkBox2.TabIndex = 25;
                    checkBox2.Text = "Show Recipes";
                    checkBox2.Click += new EventHandler(CheckBox2Changed);
                    checkBox2.UseVisualStyleBackColor = true;
                    this.Controls.Add(checkBox2);

                    comboBox3 = new System.Windows.Forms.ComboBox();
                    this.helpProvider1.SetShowHelp(comboBox3, true);
                    this.helpProvider1.SetHelpString(comboBox3, "Select the advancement you want the player to give/remove.");
                    comboBox3.FormattingEnabled = true;
                    comboBox3.Items.AddRange(MCCommandGenerator.Text.Advancements);
                    comboBox3.Location = new System.Drawing.Point(580, 42);
                    comboBox3.Name = "comboBox3";
                    comboBox3.Size = new System.Drawing.Size(200, 21);
                    comboBox3.TabIndex = 1;

                    comboBox4 = new System.Windows.Forms.ComboBox();
                    this.helpProvider1.SetShowHelp(comboBox4, true);
                    this.helpProvider1.SetHelpString(comboBox4, "Select the recipe you want the player to give/remove.");
                    comboBox4.FormattingEnabled = true;
                    comboBox4.Items.AddRange(MCCommandGenerator.Text.RecipesBuilding);
                    comboBox4.Location = new System.Drawing.Point(695, 42);
                    comboBox4.Name = "comboBox4";
                    comboBox4.Size = new System.Drawing.Size(400, 21);
                    comboBox4.TabIndex = 1;

                    this.label4 = new System.Windows.Forms.Label();
                    this.label4.AutoSize = true;
                    this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                    this.label4.Location = new System.Drawing.Point(610, 45);
                    this.label4.Name = "label4";
                    this.label4.Size = new System.Drawing.Size(75, 17);
                    this.label4.TabIndex = 1;
                    this.label4.Text = "Building Blocks:";

                    comboBox5 = new System.Windows.Forms.ComboBox();
                    this.helpProvider1.SetShowHelp(comboBox5, true);
                    this.helpProvider1.SetHelpString(comboBox5, "Select the recipe you want the player to give/remove.");
                    comboBox5.FormattingEnabled = true;
                    comboBox5.Items.AddRange(MCCommandGenerator.Text.RecipesDecoration);
                    comboBox5.Location = new System.Drawing.Point(695, 70);
                    comboBox5.Name = "comboBox5";
                    comboBox5.Size = new System.Drawing.Size(400, 21);
                    comboBox5.TabIndex = 1;

                    this.label5 = new System.Windows.Forms.Label();
                    this.label5.AutoSize = true;
                    this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                    this.label5.Location = new System.Drawing.Point(595, 73);
                    this.label5.Name = "label5";
                    this.label5.Size = new System.Drawing.Size(75, 17);
                    this.label5.TabIndex = 1;
                    this.label5.Text = "Decoration Blocks:";

                    comboBox6 = new System.Windows.Forms.ComboBox();
                    this.helpProvider1.SetShowHelp(comboBox6, true);
                    this.helpProvider1.SetHelpString(comboBox6, "Select the recipe you want the player to give/remove.");
                    comboBox6.FormattingEnabled = true;
                    comboBox6.Items.AddRange(MCCommandGenerator.Text.RecipesRedstone);
                    comboBox6.Location = new System.Drawing.Point(695, 98);
                    comboBox6.Name = "comboBox6";
                    comboBox6.Size = new System.Drawing.Size(400, 21);
                    comboBox6.TabIndex = 1;

                    this.label6 = new System.Windows.Forms.Label();
                    this.label6.AutoSize = true;
                    this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                    this.label6.Location = new System.Drawing.Point(636, 101);
                    this.label6.Name = "label6";
                    this.label6.Size = new System.Drawing.Size(75, 17);
                    this.label6.TabIndex = 1;
                    this.label6.Text = "Redstone:";

                    comboBox7 = new System.Windows.Forms.ComboBox();
                    this.helpProvider1.SetShowHelp(comboBox7, true);
                    this.helpProvider1.SetHelpString(comboBox7, "Select the recipe you want the player to give/remove.");
                    comboBox7.FormattingEnabled = true;
                    comboBox7.Items.AddRange(MCCommandGenerator.Text.RecipesTransportation);
                    comboBox7.Location = new System.Drawing.Point(695, 126);
                    comboBox7.Name = "comboBox7";
                    comboBox7.Size = new System.Drawing.Size(400, 21);
                    comboBox7.TabIndex = 1;

                    this.label7 = new System.Windows.Forms.Label();
                    this.label7.AutoSize = true;
                    this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                    this.label7.Location = new System.Drawing.Point(614, 129);
                    this.label7.Name = "label7";
                    this.label7.Size = new System.Drawing.Size(75, 17);
                    this.label7.TabIndex = 1;
                    this.label7.Text = "Transportation:";

                    comboBox8 = new System.Windows.Forms.ComboBox();
                    this.helpProvider1.SetShowHelp(comboBox8, true);
                    this.helpProvider1.SetHelpString(comboBox8, "Select the recipe you want the player to give/remove.");
                    comboBox8.FormattingEnabled = true;
                    comboBox8.Items.AddRange(MCCommandGenerator.Text.RecipesMisc);
                    comboBox8.Location = new System.Drawing.Point(695, 154);
                    comboBox8.Name = "comboBox8";
                    comboBox8.Size = new System.Drawing.Size(400, 21);
                    comboBox8.TabIndex = 1;

                    this.label8 = new System.Windows.Forms.Label();
                    this.label8.AutoSize = true;
                    this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                    this.label8.Location = new System.Drawing.Point(615, 157);
                    this.label8.Name = "label8";
                    this.label8.Size = new System.Drawing.Size(75, 17);
                    this.label8.TabIndex = 1;
                    this.label8.Text = "Miscellaneous:";

                    comboBox9 = new System.Windows.Forms.ComboBox();
                    this.helpProvider1.SetShowHelp(comboBox9, true);
                    this.helpProvider1.SetHelpString(comboBox9, "Select the recipe you want the player to give/remove.");
                    comboBox9.FormattingEnabled = true;
                    comboBox9.Items.AddRange(MCCommandGenerator.Text.RecipesFood);
                    comboBox9.Location = new System.Drawing.Point(695, 182);
                    comboBox9.Name = "comboBox9";
                    comboBox9.Size = new System.Drawing.Size(400, 21);
                    comboBox9.TabIndex = 1;

                    this.label9 = new System.Windows.Forms.Label();
                    this.label9.AutoSize = true;
                    this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                    this.label9.Location = new System.Drawing.Point(638, 185);
                    this.label9.Name = "label9";
                    this.label9.Size = new System.Drawing.Size(75, 17);
                    this.label9.TabIndex = 1;
                    this.label9.Text = "Foodstuff:";

                    comboBox10 = new System.Windows.Forms.ComboBox();
                    this.helpProvider1.SetShowHelp(comboBox10, true);
                    this.helpProvider1.SetHelpString(comboBox10, "Select the recipe you want the player to give/remove.");
                    comboBox10.FormattingEnabled = true;
                    comboBox10.Items.AddRange(MCCommandGenerator.Text.RecipesTools);
                    comboBox10.Location = new System.Drawing.Point(695, 210);
                    comboBox10.Name = "comboBox10";
                    comboBox10.Size = new System.Drawing.Size(400, 21);
                    comboBox10.TabIndex = 1;

                    this.label10 = new System.Windows.Forms.Label();
                    this.label10.AutoSize = true;
                    this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                    this.label10.Location = new System.Drawing.Point(655, 213);
                    this.label10.Name = "label10";
                    this.label10.Size = new System.Drawing.Size(75, 17);
                    this.label10.TabIndex = 1;
                    this.label10.Text = "Tools:";

                    comboBox11 = new System.Windows.Forms.ComboBox();
                    this.helpProvider1.SetShowHelp(comboBox11, true);
                    this.helpProvider1.SetHelpString(comboBox11, "Select the recipe you want the player to give/remove.");
                    comboBox11.FormattingEnabled = true;
                    comboBox11.Items.AddRange(MCCommandGenerator.Text.RecipesCombat);
                    comboBox11.Location = new System.Drawing.Point(695, 238);
                    comboBox11.Name = "comboBox11";
                    comboBox11.Size = new System.Drawing.Size(400, 21);
                    comboBox11.TabIndex = 1;

                    this.label11 = new System.Windows.Forms.Label();
                    this.label11.AutoSize = true;
                    this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                    this.label11.Location = new System.Drawing.Point(646, 241);
                    this.label11.Name = "label11";
                    this.label11.Size = new System.Drawing.Size(75, 17);
                    this.label11.TabIndex = 1;
                    this.label11.Text = "Combat:";

                    comboBox12 = new System.Windows.Forms.ComboBox();
                    this.helpProvider1.SetShowHelp(comboBox12, true);
                    this.helpProvider1.SetHelpString(comboBox12, "Select the recipe you want the player to give/remove.");
                    comboBox12.FormattingEnabled = true;
                    comboBox12.Items.AddRange(MCCommandGenerator.Text.RecipesBrewing);
                    comboBox12.Location = new System.Drawing.Point(695, 266);
                    comboBox12.Name = "comboBox12";
                    comboBox12.Size = new System.Drawing.Size(400, 21);
                    comboBox12.TabIndex = 1;

                    this.label12 = new System.Windows.Forms.Label();
                    this.label12.AutoSize = true;
                    this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
                    this.label12.Location = new System.Drawing.Point(644, 269);
                    this.label12.Name = "label12";
                    this.label12.Size = new System.Drawing.Size(75, 17);
                    this.label12.TabIndex = 1;
                    this.label12.Text = "Brewing:";
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
                default: MessageBox.Show("Please choose an option out of the dropdown box.", "No!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
            }
        }
        private void CheckBox1Changed(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                this.Controls.Add(comboBox3);
                this.Controls.Remove(comboBox4);
                this.Controls.Remove(this.label4);
                this.Controls.Remove(comboBox5);
                this.Controls.Remove(this.label5);
                this.Controls.Remove(comboBox6);
                this.Controls.Remove(this.label6);
                this.Controls.Remove(comboBox7);
                this.Controls.Remove(this.label7);
                this.Controls.Remove(comboBox8);
                this.Controls.Remove(this.label8);
                this.Controls.Remove(comboBox9);
                this.Controls.Remove(this.label9);
                this.Controls.Remove(comboBox10);
                this.Controls.Remove(this.label10);
                this.Controls.Remove(comboBox11);
                this.Controls.Remove(this.label11);
                this.Controls.Remove(comboBox12);
                this.Controls.Remove(this.label12);
            }
            else
            {
                this.Controls.Remove(comboBox3);
            }
        }
        private void CheckBox2Changed(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                this.Controls.Add(comboBox4);
                this.Controls.Add(this.label4);
                this.Controls.Add(comboBox5);
                this.Controls.Add(this.label5);
                this.Controls.Add(comboBox6);
                this.Controls.Add(this.label6);
                this.Controls.Add(comboBox7);
                this.Controls.Add(this.label7);
                this.Controls.Add(comboBox8);
                this.Controls.Add(this.label8);
                this.Controls.Add(comboBox9);
                this.Controls.Add(this.label9);
                this.Controls.Add(comboBox10);
                this.Controls.Add(this.label10);
                this.Controls.Add(comboBox11);
                this.Controls.Add(this.label11);
                this.Controls.Add(comboBox12);
                this.Controls.Add(this.label12);
                this.Controls.Remove(comboBox3);
            }
            else
            {
                this.Controls.Remove(comboBox4);
                this.Controls.Remove(this.label4);
                this.Controls.Remove(comboBox5);
                this.Controls.Remove(this.label5);
                this.Controls.Remove(comboBox6);
                this.Controls.Remove(this.label6);
                this.Controls.Remove(comboBox7);
                this.Controls.Remove(this.label7);
                this.Controls.Remove(comboBox8);
                this.Controls.Remove(this.label8);
                this.Controls.Remove(comboBox9);
                this.Controls.Remove(this.label9);
                this.Controls.Remove(comboBox10);
                this.Controls.Remove(this.label10);
                this.Controls.Remove(comboBox11);
                this.Controls.Remove(this.label11);
                this.Controls.Remove(comboBox12);
                this.Controls.Remove(this.label12);
            }
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
        public static System.Windows.Forms.ComboBox comboBox3;
        public static System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        public static System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        public static System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label6;
        public static System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label7;
        public static System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label8;
        public static System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label9;
        public static System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label10;
        public static System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label11;
        public static System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label AlphaLabel;
    }
}

