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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // EingebeBestaetigung
            // 
            EingebeBestaetigung.BackColor = SystemColors.Desktop;
            EingebeBestaetigung.Dock = DockStyle.Fill;
            EingebeBestaetigung.ForeColor = Color.Lime;
            EingebeBestaetigung.Location = new Point(362, 0);
            EingebeBestaetigung.Margin = new Padding(0);
            EingebeBestaetigung.MaximumSize = new Size(40, 29);
            EingebeBestaetigung.MinimumSize = new Size(40, 29);
            EingebeBestaetigung.Name = "EingebeBestaetigung";
            EingebeBestaetigung.Size = new Size(40, 29);
            EingebeBestaetigung.TabIndex = 2;
            EingebeBestaetigung.Text = "➜";
            EingebeBestaetigung.UseVisualStyleBackColor = false;
            EingebeBestaetigung.Click += EingabeBestaetigung_Click;
            // 
            // AusgabeBox
            // 
            AusgabeBox.BackColor = Color.PeachPuff;
            AusgabeBox.Dock = DockStyle.Fill;
            AusgabeBox.Location = new Point(3, 2);
            AusgabeBox.Margin = new Padding(3, 2, 3, 2);
            AusgabeBox.Name = "AusgabeBox";
            AusgabeBox.ReadOnly = true;
            AusgabeBox.Size = new Size(396, 512);
            AusgabeBox.TabIndex = 99;
            AusgabeBox.TabStop = false;
            AusgabeBox.Text = "";
            // 
            // EingabeBenutzer
            // 
            EingabeBenutzer.BackColor = Color.Bisque;
            EingabeBenutzer.BorderStyle = BorderStyle.FixedSingle;
            EingabeBenutzer.Dock = DockStyle.Fill;
            EingabeBenutzer.Location = new Point(0, 0);
            EingabeBenutzer.Margin = new Padding(0);
            EingabeBenutzer.Name = "EingabeBenutzer";
            EingabeBenutzer.Size = new Size(362, 23);
            EingabeBenutzer.TabIndex = 0;
            EingabeBenutzer.KeyDown += EingabeBenutzer_KeyDown;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(EingebeBestaetigung, 1, 0);
            tableLayoutPanel1.Controls.Add(EingabeBenutzer, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 516);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(402, 26);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(AusgabeBox, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0, 0, 0, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 95.3F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.7F));
            tableLayoutPanel2.Size = new Size(402, 542);
            tableLayoutPanel2.TabIndex = 100;
            // 
            // Chatbotbeispiel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(402, 542);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Chatbotbeispiel";
            Text = "FiPi-Chatbot";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel2;
    }
}
