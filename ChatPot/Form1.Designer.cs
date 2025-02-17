using System.Windows.Forms;

namespace ChatPot
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            AusgabeBox = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            contextMenuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Dock = DockStyle.Fill;
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(417, 3);
            button1.Name = "button1";
            button1.Size = new Size(40, 26);
            button1.TabIndex = 2;
            button1.Text = "➜";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(159, 28);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(158, 24);
            toolStripMenuItem1.Text = "Farbwechsel";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Bisque;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 690);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(460, 32);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(460, 722);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(AusgabeBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "FiPi-Chatbot";
            contextMenuStrip1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;

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
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
