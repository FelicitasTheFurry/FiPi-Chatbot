using System.Windows.Forms;

namespace ChatPot
{
    partial class Chatbotbeispiel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chatbotbeispiel));
            EingebeBestaetigung = new Button();
            AusgabeBox = new RichTextBox();
            EingabeBenutzer = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // EingebeBestaetigung
            // 
            EingebeBestaetigung.BackColor = SystemColors.Desktop;
            EingebeBestaetigung.Dock = DockStyle.Fill;
            EingebeBestaetigung.ForeColor = Color.Lime;
            EingebeBestaetigung.Location = new Point(417, 3);
            EingebeBestaetigung.Name = "EingebeBestaetigung";
            EingebeBestaetigung.Size = new Size(40, 26);
            EingebeBestaetigung.TabIndex = 2;
            EingebeBestaetigung.Text = "➜";
            EingebeBestaetigung.UseVisualStyleBackColor = false;
            EingebeBestaetigung.Click += EingabeBestaetigung_Click;
            // 
            // AusgabeBox
            // 
            AusgabeBox.BackColor = Color.PeachPuff;
            AusgabeBox.Dock = DockStyle.Fill;
            AusgabeBox.Location = new Point(0, 0);
            AusgabeBox.Name = "AusgabeBox";
            AusgabeBox.ReadOnly = true;
            AusgabeBox.Size = new Size(460, 722);
            AusgabeBox.TabIndex = 99;
            AusgabeBox.TabStop = false;
            AusgabeBox.Text = "";
            // 
            // EingabeBenutzer
            // 
            EingabeBenutzer.BackColor = Color.Bisque;
            EingabeBenutzer.Dock = DockStyle.Fill;
            EingabeBenutzer.Location = new Point(3, 3);
            EingabeBenutzer.Name = "EingabeBenutzer";
            EingabeBenutzer.Size = new Size(408, 27);
            EingabeBenutzer.TabIndex = 0;
            EingabeBenutzer.KeyDown += EingabeBenutzer_KeyDown;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Controls.Add(EingebeBestaetigung, 1, 0);
            tableLayoutPanel1.Controls.Add(EingabeBenutzer, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 690);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(460, 32);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // Chatbotbeispiel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(460, 722);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(AusgabeBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Chatbotbeispiel";
            Text = "FiPi-Chatbot";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button EingebeBestaetigung;

        //private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    if (e.Index >= 0)
        //    {
        //        string itemText = listBox1.Items[e.Index].ToString();
        //        e.DrawBackground(); // Hintergrund zeichnen

        //        using (Brush textBrush = new SolidBrush(e.ForeColor))
        //        {
        //            // Zeichne den Text. Wenn der Text zu lang ist, wird er automatisch umgebrochen.
        //            e.Graphics.DrawString(itemText, e.Font, textBrush, e.Bounds);
        //        }

        //        e.DrawFocusRectangle(); // Fokusrahmen zeichnen, falls erforderlich
        //    }
        //}

        //private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        //{
        //    if (e.Index >= 0)
        //    {
        //        string itemText = listBox1.Items[e.Index].ToString();
        //        // Berechne die Höhe des Items, basierend auf dem Textinhalt
        //        int itemHeight = TextRenderer.MeasureText(itemText, listBox1.Font).Height;
        //        e.ItemHeight = itemHeight; // Setze die Höhe für das aktuelle Item
        //    }
        //}
        private RichTextBox AusgabeBox;
        private TextBox EingabeBenutzer;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
