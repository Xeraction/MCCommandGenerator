using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace MCCommandGenerator
{
    public static class SelectorControl
    {
        public static byte CurrentSelector = 0;
        public static byte LastSelector = 0;
        public static bool Changed()
        {
            if (CurrentSelector == LastSelector) return false;
            else return true;
        }
        public static void ResetAll()
        {
            Values.SelectorAdvancement = -1;
            Values.SelectorAdvancementFalse = false;
            Values.SelectorAdvancementTrue = false;
            Values.SelectorDistanceFrom = 0F;
            Values.SelectorDistanceFromClosest = false;
            Values.SelectorDistanceTo = 0F;
            Values.SelectorDistanceToInfinite = false;
            Values.SelectorDX = 0F;
            Values.SelectorDY = 0F;
            Values.SelectorDZ = 0F;
            Values.SelectorGamemode = -1;
            Values.SelectorGamemodeNot = false;
            Values.SelectorLevelFrom = 0F;
            Values.SelectorLevelFromClosest = false;
            Values.SelectorLevelTo = 0F;
            Values.SelectorLevelToInfinite = false;
            Values.SelectorLimit = 0F;
            Values.SelectorName = "";
            Values.SelectorNameNot = false;
            Values.SelectorNBT = "";
            Values.SelectorPredicate = "";
            Values.SelectorScores = "";
            Values.SelectorSort = -1;
            Values.SelectorTags = "";
            Values.SelectorTeam = "";
            Values.SelectorType = -1;
            Values.SelectorTypeNot = false;
            Values.SelectorX = 0F;
            Values.SelectorXRotationFrom = 0F;
            Values.SelectorXRotationFromClosest = false;
            Values.SelectorXRotationTo = 0F;
            Values.SelectorXRotationToInfinite = false;
            Values.SelectorY = 0F;
            Values.SelectorYRotationFrom = 0F;
            Values.SelectorYRotationFromClosest = false;
            Values.SelectorYRotationTo = 0F;
            Values.SelectorYRotationToInfinite = false;
            Values.SelectorZ = 0F;
        }
        public static void SelectorASave(object sender, EventArgs e)
        {
            for (int i = 0; i < Text.Advancements.Length; i++)
            {
                if (SelectorA.comboBox2.Text == Text.Advancements[i])
                {
                    Values.SelectorAdvancement = (short)i;
                    break;
                }
                else Values.SelectorAdvancement = -1;
            }
            for (int i = 0; i < Text.Gamemodes.Length; i++)
            {
                if (SelectorA.comboBox3.Text == Text.Gamemodes[i])
                {
                    Values.SelectorGamemode = (short)i;
                    break;
                }
                else Values.SelectorGamemode = -1;
            }
            for (int i = 0; i < Text.Sorts.Length; i++)
            {
                if (SelectorA.comboBox4.Text == Text.Sorts[i])
                {
                    Values.SelectorSort = (short)i;
                    break;
                }
                else Values.SelectorSort = -1;
            }
            if (SelectorA.radioButton1.Checked) Values.SelectorAdvancementTrue = true;
            else Values.SelectorAdvancementTrue = false;
            if (SelectorA.radioButton2.Checked) Values.SelectorAdvancementFalse = true;
            else Values.SelectorAdvancementFalse = false;
            if (SelectorA.radioButton3.Checked) Values.SelectorDistanceFromClosest = true;
            else Values.SelectorDistanceFromClosest = false;
            if (SelectorA.radioButton4.Checked) Values.SelectorDistanceToInfinite = true;
            else Values.SelectorDistanceToInfinite = false;
            if (SelectorA.radioButton5.Checked) Values.SelectorLevelFromClosest = true;
            else Values.SelectorLevelFromClosest = false;
            if (SelectorA.radioButton6.Checked) Values.SelectorLevelToInfinite = true;
            else Values.SelectorLevelToInfinite = false;
            if (SelectorA.radioButton7.Checked) Values.SelectorXRotationFromClosest = true;
            else Values.SelectorXRotationFromClosest = false;
            if (SelectorA.radioButton8.Checked) Values.SelectorXRotationToInfinite = true;
            else Values.SelectorXRotationToInfinite = false;
            if (SelectorA.radioButton9.Checked) Values.SelectorYRotationFromClosest = true;
            else Values.SelectorYRotationFromClosest = false;
            if (SelectorA.radioButton10.Checked) Values.SelectorYRotationToInfinite = true;
            else Values.SelectorYRotationToInfinite = false;
            try
            {
                if (SelectorA.textBox1.Text != "") Values.SelectorX = float.Parse(SelectorA.textBox1.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox1.Text == "") Values.SelectorX = 0F;
                if (SelectorA.textBox2.Text != "") Values.SelectorDistanceFrom = float.Parse(SelectorA.textBox2.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox2.Text == "") Values.SelectorDistanceFrom = 0F;
                if (SelectorA.textBox3.Text != "") Values.SelectorDistanceTo = float.Parse(SelectorA.textBox3.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox3.Text == "") Values.SelectorDistanceTo = 0F;
                if (SelectorA.textBox4.Text != "") Values.SelectorDX = float.Parse(SelectorA.textBox4.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox4.Text == "") Values.SelectorDX = 0F;
                if (SelectorA.textBox5.Text != "") Values.SelectorY = float.Parse(SelectorA.textBox5.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox5.Text == "") Values.SelectorY = 0F;
                if (SelectorA.textBox6.Text != "") Values.SelectorDY = float.Parse(SelectorA.textBox6.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox6.Text == "") Values.SelectorDY = 0F;
                if (SelectorA.textBox7.Text != "") Values.SelectorZ = float.Parse(SelectorA.textBox7.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox7.Text == "") Values.SelectorZ = 0F;
                if (SelectorA.textBox8.Text != "") Values.SelectorDZ = float.Parse(SelectorA.textBox8.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox8.Text == "") Values.SelectorDZ = 0F;
                if (SelectorA.textBox9.Text != "") Values.SelectorLevelFrom = float.Parse(SelectorA.textBox9.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox9.Text == "") Values.SelectorLevelFrom = 0F;
                if (SelectorA.textBox10.Text != "") Values.SelectorLevelTo = float.Parse(SelectorA.textBox10.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox10.Text == "") Values.SelectorLevelTo = 0F;
                if (SelectorA.textBox11.Text != "") Values.SelectorLimit = float.Parse(SelectorA.textBox11.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox11.Text == "") Values.SelectorLimit = 0F;
                if (SelectorA.textBox13.Text != "") Values.SelectorXRotationFrom = float.Parse(SelectorA.textBox13.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox13.Text == "") Values.SelectorXRotationFrom = 0F;
                if (SelectorA.textBox14.Text != "") Values.SelectorYRotationFrom = float.Parse(SelectorA.textBox14.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox14.Text == "") Values.SelectorYRotationFrom = 0F;
                if (SelectorA.textBox15.Text != "") Values.SelectorXRotationTo = float.Parse(SelectorA.textBox15.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox15.Text == "") Values.SelectorXRotationTo = 0F;
                if (SelectorA.textBox16.Text != "") Values.SelectorYRotationTo = float.Parse(SelectorA.textBox16.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorA.textBox16.Text == "") Values.SelectorYRotationTo = 0F;
            }
            catch (Exception i)
            {
                MessageBox.Show("Error: " + i.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Values.SelectorName = SelectorA.textBox12.Text;
            Values.SelectorNBT = SelectorA.textBox17.Text;
            Values.SelectorPredicate = SelectorA.textBox18.Text;
            Values.SelectorScores = SelectorA.textBox19.Text;
            Values.SelectorTags = SelectorA.textBox20.Text;
            Values.SelectorTeam = SelectorA.textBox21.Text;
            if (SelectorA.checkBox1.Checked) Values.SelectorGamemodeNot = true;
            else Values.SelectorGamemodeNot = false;
            if (SelectorA.checkBox2.Checked) Values.SelectorNameNot = true;
            else Values.SelectorNameNot = false;
            LastSelector = 1;
            SelectorA.ActiveForm.Close();
        }
        public static void SelectorACancel(object sender, EventArgs e)
        {
            LastSelector = 1;
            SelectorA.ActiveForm.Close();
        }
        public static void SelectorAReset(object sender, EventArgs e)
        {
            SelectorA.comboBox2.Text = "";
            SelectorA.comboBox3.Text = "";
            SelectorA.comboBox4.Text = "";
            SelectorA.checkBox1.Checked = false;
            SelectorA.checkBox2.Checked = false;
            SelectorA.textBox1.Text = "";
            SelectorA.textBox2.Text = "";
            SelectorA.textBox3.Text = "";
            SelectorA.textBox4.Text = "";
            SelectorA.textBox5.Text = "";
            SelectorA.textBox6.Text = "";
            SelectorA.textBox7.Text = "";
            SelectorA.textBox8.Text = "";
            SelectorA.textBox9.Text = "";
            SelectorA.textBox10.Text = "";
            SelectorA.textBox11.Text = "";
            SelectorA.textBox12.Text = "";
            SelectorA.textBox13.Text = "";
            SelectorA.textBox14.Text = "";
            SelectorA.textBox15.Text = "";
            SelectorA.textBox16.Text = "";
            SelectorA.textBox17.Text = "";
            SelectorA.textBox18.Text = "";
            SelectorA.textBox19.Text = "";
            SelectorA.textBox20.Text = "";
            SelectorA.textBox21.Text = "";
            SelectorA.radioButton1.Checked = false;
            SelectorA.radioButton2.Checked = false;
            SelectorA.radioButton3.Checked = false;
            SelectorA.radioButton4.Checked = false;
            SelectorA.radioButton5.Checked = false;
            SelectorA.radioButton6.Checked = false;
            SelectorA.radioButton7.Checked = false;
            SelectorA.radioButton8.Checked = false;
            SelectorA.radioButton9.Checked = false;
            SelectorA.radioButton10.Checked = false;
        }
        public static void SelectorESave(object sender, EventArgs e)
        {
            for (int i = 0; i < Text.Advancements.Length; i++)
            {
                if (SelectorE.comboBox2.Text == Text.Advancements[i])
                {
                    Values.SelectorAdvancement = (short)i;
                    break;
                }
                else Values.SelectorAdvancement = -1;
            }
            for (int i = 0; i < Text.Gamemodes.Length; i++)
            {
                if (SelectorE.comboBox3.Text == Text.Gamemodes[i])
                {
                    Values.SelectorGamemode = (short)i;
                    break;
                }
                else Values.SelectorGamemode = -1;
            }
            for (int i = 0; i < Text.Sorts.Length; i++)
            {
                if (SelectorE.comboBox4.Text == Text.Sorts[i])
                {
                    Values.SelectorSort = (short)i;
                    break;
                }
                else Values.SelectorSort = -1;
            }
            for (int i = 0; i < Text.Types.Length; i++)
            {
                if (SelectorE.comboBox5.Text == Text.Types[i])
                {
                    Values.SelectorType = (short)i;
                    break;
                }
                else Values.SelectorType = -1;
            }
            if (SelectorE.radioButton1.Checked) Values.SelectorAdvancementTrue = true;
            else Values.SelectorAdvancementTrue = false;
            if (SelectorE.radioButton2.Checked) Values.SelectorAdvancementFalse = true;
            else Values.SelectorAdvancementFalse = false;
            if (SelectorE.radioButton3.Checked) Values.SelectorDistanceFromClosest = true;
            else Values.SelectorDistanceFromClosest = false;
            if (SelectorE.radioButton4.Checked) Values.SelectorDistanceToInfinite = true;
            else Values.SelectorDistanceToInfinite = false;
            if (SelectorE.radioButton5.Checked) Values.SelectorLevelFromClosest = true;
            else Values.SelectorLevelFromClosest = false;
            if (SelectorE.radioButton6.Checked) Values.SelectorLevelToInfinite = true;
            else Values.SelectorLevelToInfinite = false;
            if (SelectorE.radioButton7.Checked) Values.SelectorXRotationFromClosest = true;
            else Values.SelectorXRotationFromClosest = false;
            if (SelectorE.radioButton8.Checked) Values.SelectorXRotationToInfinite = true;
            else Values.SelectorXRotationToInfinite = false;
            if (SelectorE.radioButton9.Checked) Values.SelectorYRotationFromClosest = true;
            else Values.SelectorYRotationFromClosest = false;
            if (SelectorE.radioButton10.Checked) Values.SelectorYRotationToInfinite = true;
            else Values.SelectorYRotationToInfinite = false;
            try
            {
                if (SelectorE.textBox1.Text != "") Values.SelectorX = float.Parse(SelectorE.textBox1.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox1.Text == "") Values.SelectorX = 0F;
                if (SelectorE.textBox2.Text != "") Values.SelectorDistanceFrom = float.Parse(SelectorE.textBox2.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox2.Text == "") Values.SelectorDistanceFrom = 0F;
                if (SelectorE.textBox3.Text != "") Values.SelectorDistanceTo = float.Parse(SelectorE.textBox3.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox3.Text == "") Values.SelectorDistanceTo = 0F;
                if (SelectorE.textBox4.Text != "") Values.SelectorDX = float.Parse(SelectorE.textBox4.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox4.Text == "") Values.SelectorDX = 0F;
                if (SelectorE.textBox5.Text != "") Values.SelectorY = float.Parse(SelectorE.textBox5.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox5.Text == "") Values.SelectorY = 0F;
                if (SelectorE.textBox6.Text != "") Values.SelectorDY = float.Parse(SelectorE.textBox6.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox6.Text == "") Values.SelectorDY = 0F;
                if (SelectorE.textBox7.Text != "") Values.SelectorZ = float.Parse(SelectorE.textBox7.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox7.Text == "") Values.SelectorZ = 0F;
                if (SelectorE.textBox8.Text != "") Values.SelectorDZ = float.Parse(SelectorE.textBox8.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox8.Text == "") Values.SelectorDZ = 0F;
                if (SelectorE.textBox9.Text != "") Values.SelectorLevelFrom = float.Parse(SelectorE.textBox9.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox9.Text == "") Values.SelectorLevelFrom = 0F;
                if (SelectorE.textBox10.Text != "") Values.SelectorLevelTo = float.Parse(SelectorE.textBox10.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox10.Text == "") Values.SelectorLevelTo = 0F;
                if (SelectorE.textBox11.Text != "") Values.SelectorLimit = float.Parse(SelectorE.textBox11.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox11.Text == "") Values.SelectorLimit = 0F;
                if (SelectorE.textBox13.Text != "") Values.SelectorXRotationFrom = float.Parse(SelectorE.textBox13.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox13.Text == "") Values.SelectorXRotationFrom = 0F;
                if (SelectorE.textBox14.Text != "") Values.SelectorYRotationFrom = float.Parse(SelectorE.textBox14.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox14.Text == "") Values.SelectorYRotationFrom = 0F;
                if (SelectorE.textBox15.Text != "") Values.SelectorXRotationTo = float.Parse(SelectorE.textBox15.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox15.Text == "") Values.SelectorXRotationTo = 0F;
                if (SelectorE.textBox16.Text != "") Values.SelectorYRotationTo = float.Parse(SelectorE.textBox16.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (SelectorE.textBox16.Text == "") Values.SelectorYRotationTo = 0F;
            }
            catch (Exception i)
            {
                MessageBox.Show("Error: " + i.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Values.SelectorName = SelectorE.textBox12.Text;
            Values.SelectorNBT = SelectorE.textBox17.Text;
            Values.SelectorPredicate = SelectorE.textBox18.Text;
            Values.SelectorScores = SelectorE.textBox19.Text;
            Values.SelectorTags = SelectorE.textBox20.Text;
            Values.SelectorTeam = SelectorE.textBox21.Text;
            if (SelectorE.checkBox1.Checked) Values.SelectorGamemodeNot = true;
            else Values.SelectorGamemodeNot = false;
            if (SelectorE.checkBox2.Checked) Values.SelectorNameNot = true;
            else Values.SelectorNameNot = false;
            if (SelectorE.checkBox3.Checked) Values.SelectorTypeNot = true;
            else Values.SelectorTypeNot = false;
            LastSelector = 2;
            SelectorE.ActiveForm.Close();
        }
        public static void SelectorECancel(object sender, EventArgs e)
        {
            LastSelector = 2;
            SelectorE.ActiveForm.Close();
        }
        public static void SelectorEReset(object sender, EventArgs e)
        {
            SelectorE.comboBox2.Text = "";
            SelectorE.comboBox3.Text = "";
            SelectorE.comboBox4.Text = "";
            SelectorE.comboBox5.Text = "";
            SelectorE.checkBox1.Checked = false;
            SelectorE.checkBox2.Checked = false;
            SelectorE.checkBox3.Checked = false;
            SelectorE.textBox1.Text = "";
            SelectorE.textBox2.Text = "";
            SelectorE.textBox3.Text = "";
            SelectorE.textBox4.Text = "";
            SelectorE.textBox5.Text = "";
            SelectorE.textBox6.Text = "";
            SelectorE.textBox7.Text = "";
            SelectorE.textBox8.Text = "";
            SelectorE.textBox9.Text = "";
            SelectorE.textBox10.Text = "";
            SelectorE.textBox11.Text = "";
            SelectorE.textBox12.Text = "";
            SelectorE.textBox13.Text = "";
            SelectorE.textBox14.Text = "";
            SelectorE.textBox15.Text = "";
            SelectorE.textBox16.Text = "";
            SelectorE.textBox17.Text = "";
            SelectorE.textBox18.Text = "";
            SelectorE.textBox19.Text = "";
            SelectorE.textBox20.Text = "";
            SelectorE.textBox21.Text = "";
            SelectorE.radioButton1.Checked = false;
            SelectorE.radioButton2.Checked = false;
            SelectorE.radioButton3.Checked = false;
            SelectorE.radioButton4.Checked = false;
            SelectorE.radioButton5.Checked = false;
            SelectorE.radioButton6.Checked = false;
            SelectorE.radioButton7.Checked = false;
            SelectorE.radioButton8.Checked = false;
            SelectorE.radioButton9.Checked = false;
            SelectorE.radioButton10.Checked = false;
        }
    }
}
