using System;
using System.Drawing;
using System.Windows.Forms;

namespace _243557_Library_Stock_Management_System
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
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox9 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnView = new Button();
            textBox10 = new TextBox();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 255, 128);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, viewToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(71, 20);
            addToolStripMenuItem.Text = "Add Book";
            addToolStripMenuItem.Click += btnAdd_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(79, 20);
            viewToolStripMenuItem.Text = "View Books";
            viewToolStripMenuItem.Click += btnView_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(87, 20);
            updateToolStripMenuItem.Text = "Update Book";
            updateToolStripMenuItem.Click += btnUpdate_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(82, 20);
            deleteToolStripMenuItem.Text = "Delete Book";
            deleteToolStripMenuItem.Click += btnDelete_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(80, 20);
            logoutToolStripMenuItem.Text = "Logout/Exit";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(680, 248);
            dataGridView1.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(131, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(131, 137);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(131, 162);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(131, 187);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(131, 212);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(131, 237);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(15, 22);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Book ID (for Update/Del):";
            textBox9.Size = new Size(210, 23);
            textBox9.TabIndex = 17;
            // 
            // label1
            // 
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 16;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.Location = new Point(28, 65);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 15;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.Location = new Point(28, 90);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 14;
            label3.Text = "Publisher:";
            // 
            // label4
            // 
            label4.Location = new Point(28, 115);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 13;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.Location = new Point(28, 140);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 12;
            label5.Text = "ISBN:";
            // 
            // label6
            // 
            label6.Location = new Point(28, 165);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 11;
            label6.Text = "Quantity:";
            // 
            // label7
            // 
            label7.Location = new Point(28, 190);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 10;
            label7.Text = "Price:";
            // 
            // label8
            // 
            label8.Location = new Point(28, 215);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 9;
            label8.Text = "Rack No:";
            // 
            // label9
            // 
            label9.Location = new Point(28, 240);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 8;
            label9.Text = "Date Added:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 224, 192);
            btnAdd.Location = new Point(287, 155);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(125, 59);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Book";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Location = new Point(15, 59);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Book";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(255, 128, 0);
            btnView.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.ForeColor = SystemColors.ControlText;
            btnView.Location = new Point(493, 264);
            btnView.Name = "btnView";
            btnView.Size = new Size(175, 46);
            btnView.TabIndex = 3;
            btnView.Text = "View All";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(15, 19);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = " Search by Book Title, Author, or ISBN";
            textBox10.Size = new Size(210, 23);
            textBox10.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 64, 0);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(15, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(210, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Location = new Point(452, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 100);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 128);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(452, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(240, 113);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "UPDATE / DELETE";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 128, 0);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 35);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(434, 286);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "ADD Books";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(884, 600);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnView);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Library Stock Management System Dashboard";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnView;
        private TextBox textBox10;
        private Button btnSearch;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}