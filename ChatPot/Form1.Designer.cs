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
            textBox1 = new TextBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Bisque;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(0, 695);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(460, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(422, 695);
            button1.Name = "button1";
            button1.Size = new Size(38, 27);
            button1.TabIndex = 2;
            button1.Text = "➜";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.PeachPuff;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(460, 695);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(460, 722);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "FiPi-Chatbot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
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
        private RichTextBox richTextBox1;
    }
}
