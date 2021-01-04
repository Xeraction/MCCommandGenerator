using System;

namespace MCCommandGenerator
{
    partial class SelectorE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            textBox7 = new System.Windows.Forms.TextBox();
            textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            textBox9 = new System.Windows.Forms.TextBox();
            textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            textBox12 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            textBox13 = new System.Windows.Forms.TextBox();
            textBox14 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            textBox15 = new System.Windows.Forms.TextBox();
            textBox16 = new System.Windows.Forms.TextBox();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            radioButton5 = new System.Windows.Forms.RadioButton();
            radioButton6 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            radioButton7 = new System.Windows.Forms.RadioButton();
            radioButton8 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            radioButton9 = new System.Windows.Forms.RadioButton();
            radioButton10 = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            textBox17 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            textBox18 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            textBox19 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            comboBox4 = new System.Windows.Forms.ComboBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            textBox20 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            textBox21 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            comboBox5 = new System.Windows.Forms.ComboBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Advancements:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Distance:";
            // 
            // textBox2
            // 
            this.helpProvider1.SetHelpString(textBox2, "The distance from the target.\nSelect \"From closest\" to start at 0.\n(The value in this box will then be ignored)");
            textBox2.Location = new System.Drawing.Point(71, 47);
            textBox2.Name = "textBox2";
            this.helpProvider1.SetShowHelp(textBox2, true);
            if (MCCommandGenerator.Values.SelectorDistanceFrom == 0F) textBox2.Text = "";
            else textBox2.Text = MCCommandGenerator.Values.SelectorDistanceFrom.ToString();
            textBox2.Size = new System.Drawing.Size(29, 20);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "to";
            // 
            // textBox3
            // 
            this.helpProvider1.SetHelpString(textBox3, "The distance most far away.\nLeave it blank for a specific distance.\nSelect \"To infinite\" to end at infinity.\n(The value in this box will then be ignored)");
            textBox3.Location = new System.Drawing.Point(128, 47);
            textBox3.Name = "textBox3";
            this.helpProvider1.SetShowHelp(textBox3, true);
            if (MCCommandGenerator.Values.SelectorDistanceTo == 0F) textBox3.Text = "";
            else textBox3.Text = MCCommandGenerator.Values.SelectorDistanceTo.ToString();
            textBox3.Size = new System.Drawing.Size(29, 20);
            textBox3.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(1, 1);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(43, 17);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "true";
            if (MCCommandGenerator.Values.SelectorAdvancementTrue == true) radioButton1.Checked = true;
            else radioButton1.Checked = false;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(50, 1);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(47, 17);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "false";
            if (MCCommandGenerator.Values.SelectorAdvancementFalse == true) radioButton2.Checked = true;
            else radioButton2.Checked = false;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(comboBox2, "Sets the advancement the entity needs to have.\nSelect true if the entity should have the advancement.\nSelect false otherwise.");
            comboBox2.Items.AddRange(MCCommandGenerator.Text.Advancements);
            comboBox2.Location = new System.Drawing.Point(98, 13);
            comboBox2.Name = "comboBox2";
            this.helpProvider1.SetShowHelp(comboBox2, true);
            try
            {
                if (MCCommandGenerator.Values.SelectorAdvancement != -1) comboBox2.Text = MCCommandGenerator.Text.Advancements[MCCommandGenerator.Values.SelectorAdvancement];
                else comboBox2.Text = "";
            }
            catch (Exception e)
            {
                comboBox2.Text = "Error: " + e.Message;
            }
            comboBox2.Size = new System.Drawing.Size(153, 21);
            comboBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "x:";
            // 
            // textBox1
            // 
            this.helpProvider1.SetHelpString(textBox1, "The x-position in the world.\nCommonly used with the distance-parameter.");
            textBox1.Location = new System.Drawing.Point(38, 81);
            textBox1.Name = "textBox1";
            this.helpProvider1.SetShowHelp(textBox1, true);
            textBox1.Size = new System.Drawing.Size(27, 20);
            if (MCCommandGenerator.Values.SelectorX == 0F) textBox1.Text = "";
            else textBox1.Text = MCCommandGenerator.Values.SelectorX.ToString();
            textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "dx:";
            // 
            // textBox4
            // 
            this.helpProvider1.SetHelpString(textBox4, "The x-volume the hitbox is in.\nCommonly used with the x-parameter.");
            textBox4.Location = new System.Drawing.Point(106, 81);
            textBox4.Name = "textBox4";
            this.helpProvider1.SetShowHelp(textBox4, true);
            if (MCCommandGenerator.Values.SelectorDX == 0F) textBox4.Text = "";
            else textBox4.Text = MCCommandGenerator.Values.SelectorDX.ToString();
            textBox4.Size = new System.Drawing.Size(27, 20);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.helpProvider1.SetHelpString(textBox5, "The y-position in the world.\nCommonly used with the distance-parameter.");
            textBox5.Location = new System.Drawing.Point(38, 120);
            textBox5.Name = "textBox5";
            this.helpProvider1.SetShowHelp(textBox5, true);
            if (MCCommandGenerator.Values.SelectorY == 0F) textBox5.Text = "";
            else textBox5.Text = MCCommandGenerator.Values.SelectorY.ToString();
            textBox5.Size = new System.Drawing.Size(27, 20);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.helpProvider1.SetHelpString(textBox6, "The y-volume the hitbox is in.\nCommonly used with the y-parameter.");
            textBox6.Location = new System.Drawing.Point(106, 119);
            textBox6.Name = "textBox6";
            this.helpProvider1.SetShowHelp(textBox6, true);
            if (MCCommandGenerator.Values.SelectorDY == 0F) textBox6.Text = "";
            else textBox6.Text = MCCommandGenerator.Values.SelectorDY.ToString();
            textBox6.Size = new System.Drawing.Size(27, 20);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.helpProvider1.SetHelpString(textBox7, "The z-position in the world.\nCommonly used with the distance-paramter.");
            textBox7.Location = new System.Drawing.Point(38, 160);
            textBox7.Name = "textBox7";
            this.helpProvider1.SetShowHelp(textBox7, true);
            if (MCCommandGenerator.Values.SelectorZ == 0F) textBox7.Text = "";
            else textBox7.Text = MCCommandGenerator.Values.SelectorZ.ToString();
            textBox7.Size = new System.Drawing.Size(27, 20);
            textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.helpProvider1.SetHelpString(textBox8, "The z-volume the hitbox is in.\nCommonly used with the z-parameter.");
            textBox8.Location = new System.Drawing.Point(106, 160);
            textBox8.Name = "textBox8";
            this.helpProvider1.SetShowHelp(textBox8, true);
            if (MCCommandGenerator.Values.SelectorDZ == 0F) textBox8.Text = "";
            else textBox8.Text = MCCommandGenerator.Values.SelectorDZ.ToString();
            textBox8.Size = new System.Drawing.Size(27, 20);
            textBox8.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "dy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "z:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "dz:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(comboBox3, "Sets the gamemode the entity must be in.\nEnable \"not\" if the entity should not be in the selected gamemode.\nThis parameter only works if you want to target a player.");
            comboBox3.Items.AddRange(MCCommandGenerator.Text.Gamemodes);
            comboBox3.Location = new System.Drawing.Point(82, 195);
            comboBox3.Name = "comboBox3";
            this.helpProvider1.SetShowHelp(comboBox3, true);
            try
            {
                if (MCCommandGenerator.Values.SelectorGamemode != -1) comboBox3.Text = MCCommandGenerator.Text.Gamemodes[MCCommandGenerator.Values.SelectorGamemode];
                else comboBox3.Text = "";
            }
            catch (Exception e)
            {
                comboBox3.Text = "Error: " + e.Message;
            }
            comboBox3.Size = new System.Drawing.Size(121, 21);
            comboBox3.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Gamemode:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(210, 198);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(80, 17);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "not";
            if (MCCommandGenerator.Values.SelectorGamemodeNot == true) checkBox1.Checked = true;
            else checkBox1.Checked = false;
            checkBox1.UseVisualStyleBackColor = true;
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Level:";
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "to";
            //
            // textBox9
            //
            this.helpProvider1.SetHelpString(textBox9, "The XP-Level the entity should have.\nSelect \"From closest\" to start at 0.\n(The value in this box will then be ignored)");
            textBox9.Location = new System.Drawing.Point(55, 232);
            textBox9.Name = "textBox9";
            this.helpProvider1.SetShowHelp(textBox9, true);
            textBox9.Size = new System.Drawing.Size(27, 20);
            if (MCCommandGenerator.Values.SelectorLevelFrom == 0F) textBox9.Text = "";
            else textBox9.Text = MCCommandGenerator.Values.SelectorLevelFrom.ToString();
            textBox9.TabIndex = 28;
            //
            // textBox10
            //
            this.helpProvider1.SetHelpString(textBox10, "The maximum XP-Level the entity should have.\nLeave it blank for a specific amount.\nSelect \"To infinite\" to end at infinity.\n(The value in this box will then be ignored)");
            textBox10.Location = new System.Drawing.Point(113, 232);
            textBox10.Name = "textBox10";
            this.helpProvider1.SetShowHelp(textBox10, true);
            textBox10.Size = new System.Drawing.Size(27, 20);
            if (MCCommandGenerator.Values.SelectorLevelTo == 0F) textBox10.Text = "";
            else textBox10.Text = MCCommandGenerator.Values.SelectorLevelTo.ToString();
            textBox10.TabIndex = 29;
            //
            // label13
            //
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Limit:";
            //
            // textBox11
            //
            this.helpProvider1.SetHelpString(textBox11, "The maximum amount of entities to select.");
            textBox11.Location = new System.Drawing.Point(50, 272);
            textBox11.Name = "textBox11";
            this.helpProvider1.SetShowHelp(textBox11, true);
            textBox11.Size = new System.Drawing.Size(27, 20);
            if (MCCommandGenerator.Values.SelectorLimit == 0F) textBox11.Text = "";
            else textBox11.Text = MCCommandGenerator.Values.SelectorLimit.ToString();
            textBox11.TabIndex = 31;
            //
            // label14
            //
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Name:";
            //
            // textBox12
            //
            this.helpProvider1.SetHelpString(textBox12, "The name of the entity.\nEnable \"not\" if the entity should not have this name.");
            textBox12.Location = new System.Drawing.Point(55, 312);
            textBox12.Name = "textBox3";
            this.helpProvider1.SetShowHelp(textBox12, true);
            textBox12.Text = MCCommandGenerator.Values.SelectorName;
            textBox12.Size = new System.Drawing.Size(100, 20);
            textBox12.TabIndex = 33;
            //
            // label15
            //
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(150, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "X-Rotation:";
            //
            // label16
            //
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(150, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Y-Rotation:";
            //
            // textBox13
            //
            this.helpProvider1.SetHelpString(textBox13, "The start range of the x-rotation of the entity.\nSelect \"From closest\" to start at 0.\n(The value in this box will then be ignored)");
            textBox13.Location = new System.Drawing.Point(220, 81);
            textBox13.Name = "textBox13";
            this.helpProvider1.SetShowHelp(textBox13, true);
            if (MCCommandGenerator.Values.SelectorXRotationFrom == 0F) textBox13.Text = "";
            else textBox13.Text = MCCommandGenerator.Values.SelectorXRotationFrom.ToString();
            textBox13.Size = new System.Drawing.Size(27, 20);
            textBox13.TabIndex = 36;
            //
            // textBox14
            //
            this.helpProvider1.SetHelpString(textBox14, "The start range of the y-rotation of the entity.\nSelect \"From closest\" to start at 0.\n(The value in this box will then be ignored)");
            textBox14.Location = new System.Drawing.Point(220, 120);
            textBox14.Name = "textBox14";
            this.helpProvider1.SetShowHelp(textBox14, true);
            if (MCCommandGenerator.Values.SelectorYRotationFrom == 0F) textBox14.Text = "";
            else textBox14.Text = MCCommandGenerator.Values.SelectorYRotationFrom.ToString();
            textBox14.Size = new System.Drawing.Size(27, 20);
            textBox14.TabIndex = 37;
            //
            // label17
            //
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(260, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "to";
            //
            // label18
            //
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(260, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "to";
            //
            // textBox15
            //
            this.helpProvider1.SetHelpString(textBox15, "The end range of the x-rotation of the entity.\nLeave it blank for a specific value.\nSelect \"To infinite\" to end at infinity.\n(The value in this box will then be ignored)");
            textBox15.Location = new System.Drawing.Point(287, 81);
            textBox15.Name = "textBox15";
            this.helpProvider1.SetShowHelp(textBox15, true);
            if (MCCommandGenerator.Values.SelectorXRotationTo == 0F) textBox15.Text = "";
            else textBox15.Text = MCCommandGenerator.Values.SelectorXRotationTo.ToString();
            textBox15.Size = new System.Drawing.Size(27, 20);
            textBox15.TabIndex = 40;
            //
            // textBox16
            //
            this.helpProvider1.SetHelpString(textBox16, "The end range of the y-rotation of the entity.\nLeave it blank for a specific value.\nSelect \"To infinite\" to end at infinity.\n(The value in this box will then be ignored)");
            textBox16.Location = new System.Drawing.Point(287, 120);
            textBox16.Name = "textBox16";
            this.helpProvider1.SetShowHelp(textBox16, true);
            if (MCCommandGenerator.Values.SelectorYRotationTo == 0F) textBox16.Text = "";
            else textBox16.Text = MCCommandGenerator.Values.SelectorYRotationTo.ToString();
            textBox16.Size = new System.Drawing.Size(27, 20);
            textBox16.TabIndex = 41;
            //
            // radioButton3
            //
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(1, 1);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(43, 17);
            radioButton3.TabIndex = 800;
            radioButton3.TabStop = true;
            radioButton3.Text = "From closest";
            if (MCCommandGenerator.Values.SelectorDistanceFromClosest == true) radioButton3.Checked = true;
            else radioButton3.Checked = false;
            radioButton3.UseVisualStyleBackColor = true;
            //
            // radioButton4
            //
            radioButton4.AutoSize = true;
            radioButton4.Location = new System.Drawing.Point(90, 1);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(43, 17);
            radioButton4.TabIndex = 800;
            radioButton4.TabStop = true;
            radioButton4.Text = "To infinite";
            if (MCCommandGenerator.Values.SelectorDistanceToInfinite == true) radioButton4.Checked = true;
            else radioButton4.Checked = false;
            radioButton4.UseVisualStyleBackColor = true;
            //
            // panel1
            //
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(257, 13);
            this.panel1.Size = new System.Drawing.Size(100, 10);
            this.panel1.Controls.Add(radioButton1);
            this.panel1.Controls.Add(radioButton2);
            //
            // panel2
            //
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(170, 47);
            this.panel2.Size = new System.Drawing.Size(100, 10);
            this.panel2.Controls.Add(radioButton3);
            this.panel2.Controls.Add(radioButton4);
            //
            // radioButton5
            //
            radioButton5.AutoSize = true;
            radioButton5.Location = new System.Drawing.Point(1, 1);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new System.Drawing.Size(43, 17);
            radioButton5.TabIndex = 800;
            radioButton5.TabStop = true;
            radioButton5.Text = "From closest";
            if (MCCommandGenerator.Values.SelectorLevelFromClosest == true) radioButton5.Checked = true;
            else radioButton5.Checked = false;
            radioButton5.UseVisualStyleBackColor = true;
            //
            // radioButton6
            //
            radioButton6.AutoSize = true;
            radioButton6.Location = new System.Drawing.Point(90, 1);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new System.Drawing.Size(43, 17);
            radioButton6.TabIndex = 800;
            radioButton6.TabStop = true;
            radioButton6.Text = "To infinite";
            if (MCCommandGenerator.Values.SelectorLevelToInfinite == true) radioButton6.Checked = true;
            else radioButton6.Checked = false;
            radioButton6.UseVisualStyleBackColor = true;
            //
            // panel3
            //
            this.panel3.AutoSize = true;
            this.panel3.Location = new System.Drawing.Point(150, 232);
            this.panel3.Size = new System.Drawing.Size(100, 10);
            this.panel3.Controls.Add(radioButton5);
            this.panel3.Controls.Add(radioButton6);
            //
            // panel4
            //
            this.panel4.AutoSize = true;
            this.panel4.Location = new System.Drawing.Point(320, 81);
            this.panel4.Size = new System.Drawing.Size(100, 10);
            this.panel4.Controls.Add(radioButton7);
            this.panel4.Controls.Add(radioButton8);
            //
            // radioButton7
            //
            radioButton7.AutoSize = true;
            radioButton7.Location = new System.Drawing.Point(1, 1);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new System.Drawing.Size(43, 17);
            radioButton7.TabIndex = 800;
            radioButton7.TabStop = true;
            radioButton7.Text = "From closest";
            if (MCCommandGenerator.Values.SelectorXRotationFromClosest == true) radioButton7.Checked = true;
            else radioButton7.Checked = false;
            radioButton7.UseVisualStyleBackColor = true;
            //
            // radioButton8
            //
            radioButton8.AutoSize = true;
            radioButton8.Location = new System.Drawing.Point(90, 1);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new System.Drawing.Size(43, 17);
            radioButton8.TabIndex = 800;
            radioButton8.TabStop = true;
            radioButton8.Text = "To infinite";
            if (MCCommandGenerator.Values.SelectorXRotationToInfinite == true) radioButton8.Checked = true;
            else radioButton8.Checked = false;
            radioButton8.UseVisualStyleBackColor = true;
            //
            // panel5
            //
            this.panel5.AutoSize = true;
            this.panel5.Size = new System.Drawing.Size(100, 10);
            this.panel5.Location = new System.Drawing.Point(320, 120);
            this.panel5.Controls.Add(radioButton9);
            this.panel5.Controls.Add(radioButton10);
            //
            // radioButton9
            //
            radioButton9.AutoSize = true;
            radioButton9.Location = new System.Drawing.Point(1, 1);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new System.Drawing.Size(43, 17);
            radioButton9.TabIndex = 800;
            radioButton9.TabStop = true;
            radioButton9.Text = "From closest";
            if (MCCommandGenerator.Values.SelectorYRotationFromClosest == true) radioButton9.Checked = true;
            else radioButton9.Checked = false;
            radioButton9.UseVisualStyleBackColor = true;
            //
            // radioButton10
            //
            radioButton10.AutoSize = true;
            radioButton10.Location = new System.Drawing.Point(90, 1);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new System.Drawing.Size(43, 17);
            radioButton10.TabIndex = 800;
            radioButton10.TabStop = true;
            radioButton10.Text = "To infinite";
            if (MCCommandGenerator.Values.SelectorYRotationToInfinite == true) radioButton10.Checked = true;
            else radioButton10.Checked = false;
            radioButton10.UseVisualStyleBackColor = true;
            //
            // label19
            //
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 355);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "NBT:";
            //
            // textBox17
            //
            this.helpProvider1.SetHelpString(textBox17, "The NBT-data of the entity.\nA custom NBT-Editor will come in future versions.");
            textBox17.Location = new System.Drawing.Point(50, 353);
            textBox17.Name = "textBox17";
            this.helpProvider1.SetShowHelp(textBox17, true);
            textBox17.Text = MCCommandGenerator.Values.SelectorNBT;
            textBox17.Size = new System.Drawing.Size(100, 20);
            textBox17.TabIndex = 800;
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(13, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 800;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(MCCommandGenerator.SelectorControl.SelectorESave);
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(100, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 800;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(MCCommandGenerator.SelectorControl.SelectorECancel);
            //
            // button3
            //
            this.button3.Location = new System.Drawing.Point(185, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 800;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(MCCommandGenerator.SelectorControl.SelectorEReset);
            //
            // label20
            //
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(220, 315);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 800;
            this.label20.Text = "Predicate:";
            //
            // textBox18
            //
            this.helpProvider1.SetHelpString(textBox18, "The predicate(s) the entity should have.\nA custom Predicate-Editor will come in the future.");
            textBox18.Location = new System.Drawing.Point(280, 312);
            textBox18.Name = "textBox18";
            this.helpProvider1.SetShowHelp(textBox18, true);
            textBox18.Text = MCCommandGenerator.Values.SelectorPredicate;
            textBox18.Size = new System.Drawing.Size(100, 20);
            textBox18.TabIndex = 800;
            //
            // label21
            //
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(170, 355);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 13);
            this.label21.TabIndex = 800;
            this.label21.Text = "Scores:";
            //
            // textBox19
            //
            this.helpProvider1.SetHelpString(textBox19, "The scores of the entity.\nA custom Score-Editor will come in the future.");
            textBox19.Location = new System.Drawing.Point(220, 353);
            textBox19.Name = "textBox19";
            this.helpProvider1.SetShowHelp(textBox19, true);
            textBox19.Text = MCCommandGenerator.Values.SelectorScores;
            textBox19.Size = new System.Drawing.Size(100, 20);
            textBox19.TabIndex = 800;
            //
            // label22
            //
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(392, 315);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 13);
            this.label22.TabIndex = 800;
            this.label22.Text = "Sort:";
            //
            // comboBox4
            //
            comboBox4.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(comboBox4, "Sorts the entities you want to select.\nnearest - The entity nearest to the executing entity\nfurthest - The entity furthest away from the executing entity\nrandom - A random entity\narbitrary - No sorting at all");
            comboBox4.Items.AddRange(MCCommandGenerator.Text.Sorts);
            comboBox4.Location = new System.Drawing.Point(430, 312);
            comboBox4.Name = "comboBox4";
            this.helpProvider1.SetShowHelp(comboBox4, true);
            try
            {
                if (MCCommandGenerator.Values.SelectorSort != -1) comboBox4.Text = MCCommandGenerator.Text.Sorts[MCCommandGenerator.Values.SelectorSort];
                else comboBox4.Text = "";
            }
            catch (Exception e)
            {
                comboBox4.Text = "Error: " + e.Message;
            }
            comboBox4.Size = new System.Drawing.Size(60, 21);
            comboBox4.TabIndex = 800;
            //
            // checkBox2
            //
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(165, 314);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(80, 17);
            checkBox2.TabIndex = 800;
            checkBox2.Text = "not";
            if (MCCommandGenerator.Values.SelectorNameNot == true) checkBox2.Checked = true;
            else checkBox2.Checked = false;
            checkBox2.UseVisualStyleBackColor = true;
            //
            // label23
            //
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(300, 200);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 13);
            this.label23.TabIndex = 800;
            this.label23.Text = "Tags:";
            //
            // textBox20
            //
            this.helpProvider1.SetHelpString(textBox20, "The tags of the entity.\nSeperate multiple tags with a comma.\nSet a \"!\" in front of the tag if the entity should not have this tag.");
            textBox20.Location = new System.Drawing.Point(342, 197);
            textBox20.Name = "textBox20";
            this.helpProvider1.SetShowHelp(textBox20, true);
            textBox20.Text = MCCommandGenerator.Values.SelectorTags;
            textBox20.Size = new System.Drawing.Size(142, 20);
            textBox20.TabIndex = 800;
            //
            // label24
            //
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(320, 235);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 13);
            this.label24.TabIndex = 800;
            this.label24.Text = "Team:";
            //
            // textBox21
            //
            this.helpProvider1.SetHelpString(textBox21, "The team(s) the entity is in.\nSeperate multiple teams with a comma.\nSet a \"!\" in front of the team if the entity should not be in this team.");
            textBox21.Location = new System.Drawing.Point(360, 232);
            textBox21.Name = "textBox21";
            this.helpProvider1.SetShowHelp(textBox21, true);
            textBox21.Text = MCCommandGenerator.Values.SelectorTeam;
            textBox21.Size = new System.Drawing.Size(130, 20);
            textBox21.TabIndex = 800;
            //
            // label25
            //
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(330, 356);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 800;
            this.label25.Text = "Type:";
            //
            // comboBox5
            //
            comboBox5.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(comboBox5, "The entity you want to select.\nEnable \"not\" if you this entity shouldn't be selected.");
            comboBox5.Items.AddRange(MCCommandGenerator.Text.Types);
            comboBox5.Location = new System.Drawing.Point(370, 353);
            comboBox5.Name = "comboBox5";
            this.helpProvider1.SetShowHelp(comboBox5, true);
            try
            {
                if (MCCommandGenerator.Values.SelectorType != -1) comboBox5.Text = MCCommandGenerator.Text.Types[MCCommandGenerator.Values.SelectorType];
                else comboBox5.Text = "";
            }
            catch (Exception e)
            {
                comboBox5.Text = "Error: " + e.Message;
            }
            comboBox5.Size = new System.Drawing.Size(120, 21);
            comboBox5.TabIndex = 800;
            //
            // checkBox3
            //
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(370, 380);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(80, 17);
            checkBox3.TabIndex = 25;
            checkBox3.Text = "not";
            if (MCCommandGenerator.Values.SelectorTypeNot == true) checkBox3.Checked = true;
            else checkBox3.Checked = false;
            checkBox3.UseVisualStyleBackColor = true;
            //
            // SelectorE
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 430);
            this.Controls.Add(checkBox1);
            this.Controls.Add(comboBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(textBox8);
            this.Controls.Add(textBox7);
            this.Controls.Add(textBox6);
            this.Controls.Add(textBox5);
            this.Controls.Add(textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(comboBox2);
            this.Controls.Add(textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(textBox9);
            this.Controls.Add(textBox10);
            this.Controls.Add(this.label13);
            this.Controls.Add(textBox11);
            this.Controls.Add(this.label14);
            this.Controls.Add(textBox12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(textBox13);
            this.Controls.Add(textBox14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(textBox15);
            this.Controls.Add(textBox16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label19);
            this.Controls.Add(textBox17);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label20);
            this.Controls.Add(textBox18);
            this.Controls.Add(this.label21);
            this.Controls.Add(textBox19);
            this.Controls.Add(this.label22);
            this.Controls.Add(comboBox4);
            this.Controls.Add(checkBox2);
            this.Controls.Add(this.label23);
            this.Controls.Add(textBox20);
            this.Controls.Add(this.label24);
            this.Controls.Add(textBox21);
            this.Controls.Add(this.label25);
            this.Controls.Add(comboBox5);
            this.Controls.Add(checkBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.Name = "SelectorE";
            this.Text = "Edit Selector - " + Form1.comboBox2.Text;
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public static System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        public static System.Windows.Forms.TextBox textBox3;
        public static System.Windows.Forms.RadioButton radioButton1;
        public static System.Windows.Forms.RadioButton radioButton2;
        public static System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        public static System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        public static System.Windows.Forms.TextBox textBox4;
        public static System.Windows.Forms.TextBox textBox5;
        public static System.Windows.Forms.TextBox textBox6;
        public static System.Windows.Forms.TextBox textBox7;
        public static System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label10;
        public static System.Windows.Forms.ComboBox comboBox3;
        public static System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public static System.Windows.Forms.TextBox textBox9;
        public static System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        public static System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        public static System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public static System.Windows.Forms.TextBox textBox13;
        public static System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public static System.Windows.Forms.TextBox textBox15;
        public static System.Windows.Forms.TextBox textBox16;
        public static System.Windows.Forms.RadioButton radioButton3;
        public static System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public static System.Windows.Forms.RadioButton radioButton5;
        public static System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Panel panel4;
        public static System.Windows.Forms.RadioButton radioButton7;
        public static System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Panel panel5;
        public static System.Windows.Forms.RadioButton radioButton9;
        public static System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Label label19;
        public static System.Windows.Forms.TextBox textBox17;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label20;
        public static System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label21;
        public static System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label22;
        public static System.Windows.Forms.ComboBox comboBox4;
        public static System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label23;
        public static System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label24;
        public static System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label25;
        public static System.Windows.Forms.ComboBox comboBox5;
        public static System.Windows.Forms.CheckBox checkBox3;
    }
}