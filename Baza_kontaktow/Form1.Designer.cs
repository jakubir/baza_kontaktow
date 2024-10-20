namespace Contacts
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            slNumberOfPeople = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            slActive = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            kontaktyToolStripMenuItem = new ToolStripMenuItem();
            miNewContacts = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            miAddContact = new ToolStripMenuItem();
            miDeleteContact = new ToolStripMenuItem();
            miEditContact = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            miSave = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            miEnd = new ToolStripMenuItem();
            sortowanieToolStripMenuItem = new ToolStripMenuItem();
            miSortByName = new ToolStripMenuItem();
            miSortBySurname = new ToolStripMenuItem();
            miSortByDate = new ToolStripMenuItem();
            miPomoc = new ToolStripMenuItem();
            miHelp = new ToolStripMenuItem();
            miAuthor = new ToolStripMenuItem();
            miSearch = new ToolStripMenuItem();
            pContactData = new Panel();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lName = new Label();
            groupBox3 = new GroupBox();
            lSurname = new Label();
            groupBox4 = new GroupBox();
            lDate = new Label();
            groupBox1 = new GroupBox();
            lPhone = new Label();
            lbContacts = new ListBox();
            panel2 = new Panel();
            label1 = new Label();
            pEditContact = new Panel();
            pSearch = new Panel();
            bSearch = new Button();
            label3 = new Label();
            groupBox9 = new GroupBox();
            tbSearch = new TextBox();
            bSubmit = new Button();
            lTitle = new Label();
            gbName = new GroupBox();
            tbName = new TextBox();
            gbSurname = new GroupBox();
            tbSurname = new TextBox();
            gbDate = new GroupBox();
            dtpDate = new DateTimePicker();
            gbPhone = new GroupBox();
            tbPhone = new TextBox();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            pContactData.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            pEditContact.SuspendLayout();
            pSearch.SuspendLayout();
            groupBox9.SuspendLayout();
            gbName.SuspendLayout();
            gbSurname.SuspendLayout();
            gbDate.SuspendLayout();
            gbPhone.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.White;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, slNumberOfPeople, toolStripStatusLabel2, slActive });
            statusStrip1.Location = new Point(0, 414);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(63, 17);
            toolStripStatusLabel1.Text = "Ilość osób:";
            // 
            // slNumberOfPeople
            // 
            slNumberOfPeople.AutoSize = false;
            slNumberOfPeople.Name = "slNumberOfPeople";
            slNumberOfPeople.Size = new Size(37, 17);
            slNumberOfPeople.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(56, 17);
            toolStripStatusLabel2.Text = "Aktywny:";
            // 
            // slActive
            // 
            slActive.Name = "slActive";
            slActive.Size = new Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { kontaktyToolStripMenuItem, sortowanieToolStripMenuItem, miPomoc });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // kontaktyToolStripMenuItem
            // 
            kontaktyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miNewContacts, toolStripSeparator3, miAddContact, miDeleteContact, miEditContact, toolStripSeparator1, miSave, toolStripSeparator2, miEnd });
            kontaktyToolStripMenuItem.Name = "kontaktyToolStripMenuItem";
            kontaktyToolStripMenuItem.Size = new Size(66, 20);
            kontaktyToolStripMenuItem.Text = "Kontakty";
            // 
            // miNewContacts
            // 
            miNewContacts.Name = "miNewContacts";
            miNewContacts.Size = new Size(191, 22);
            miNewContacts.Text = "Nowa baza kontaktów";
            miNewContacts.Click += ClearFileStorage;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(188, 6);
            // 
            // miAddContact
            // 
            miAddContact.Name = "miAddContact";
            miAddContact.Size = new Size(191, 22);
            miAddContact.Text = "Dodaj osobę";
            miAddContact.Click += AddContact;
            // 
            // miDeleteContact
            // 
            miDeleteContact.Name = "miDeleteContact";
            miDeleteContact.Size = new Size(191, 22);
            miDeleteContact.Text = "Usuń osobę";
            miDeleteContact.Click += DeleteContact;
            // 
            // miEditContact
            // 
            miEditContact.Name = "miEditContact";
            miEditContact.Size = new Size(191, 22);
            miEditContact.Text = "Edytuj osobę";
            miEditContact.Click += EditContact;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(188, 6);
            // 
            // miSave
            // 
            miSave.Name = "miSave";
            miSave.Size = new Size(191, 22);
            miSave.Text = "Zapisz";
            miSave.Click += SaveToFile;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(188, 6);
            // 
            // miEnd
            // 
            miEnd.Name = "miEnd";
            miEnd.Size = new Size(191, 22);
            miEnd.Text = "Koniec";
            miEnd.Click += Exit;
            // 
            // sortowanieToolStripMenuItem
            // 
            sortowanieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miSortByName, miSortBySurname, miSortByDate });
            sortowanieToolStripMenuItem.Name = "sortowanieToolStripMenuItem";
            sortowanieToolStripMenuItem.Size = new Size(78, 20);
            sortowanieToolStripMenuItem.Text = "Sortowanie";
            // 
            // miSortByName
            // 
            miSortByName.Checked = true;
            miSortByName.CheckState = CheckState.Checked;
            miSortByName.Name = "miSortByName";
            miSortByName.Size = new Size(153, 22);
            miSortByName.Text = "Imię";
            miSortByName.Click += ByNameClick;
            // 
            // miSortBySurname
            // 
            miSortBySurname.Name = "miSortBySurname";
            miSortBySurname.Size = new Size(153, 22);
            miSortBySurname.Text = "Nazwisko";
            miSortBySurname.Click += BySurnameClick;
            // 
            // miSortByDate
            // 
            miSortByDate.Name = "miSortByDate";
            miSortByDate.Size = new Size(153, 22);
            miSortByDate.Text = "Datę urodzenia";
            miSortByDate.Click += ByDateClick;
            // 
            // miPomoc
            // 
            miPomoc.DropDownItems.AddRange(new ToolStripItem[] { miHelp, miAuthor, miSearch });
            miPomoc.Name = "miPomoc";
            miPomoc.Size = new Size(50, 20);
            miPomoc.Text = "Opcje";
            // 
            // miHelp
            // 
            miHelp.Name = "miHelp";
            miHelp.Size = new Size(180, 22);
            miHelp.Text = "Pomoc";
            miHelp.Click += OpenHelpFile;
            // 
            // miAuthor
            // 
            miAuthor.Name = "miAuthor";
            miAuthor.Size = new Size(180, 22);
            miAuthor.Text = "O autorze";
            // 
            // miSearch
            // 
            miSearch.Name = "miSearch";
            miSearch.Size = new Size(180, 22);
            miSearch.Text = "Wyszukaj";
            miSearch.Click += Search;
            // 
            // pContactData
            // 
            pContactData.BackColor = Color.Transparent;
            pContactData.Controls.Add(label2);
            pContactData.Controls.Add(groupBox2);
            pContactData.Controls.Add(groupBox3);
            pContactData.Controls.Add(groupBox4);
            pContactData.Controls.Add(groupBox1);
            pContactData.Location = new Point(282, 24);
            pContactData.Name = "pContactData";
            pContactData.Size = new Size(518, 390);
            pContactData.TabIndex = 2;
            pContactData.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(33, 30);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 11;
            label2.Text = "Dane kontaktowe:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lName);
            groupBox2.Location = new Point(33, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 47);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Imię";
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.Location = new Point(6, 19);
            lName.Name = "lName";
            lName.Size = new Size(0, 15);
            lName.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lSurname);
            groupBox3.Location = new Point(33, 134);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(241, 47);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nazwisko";
            // 
            // lSurname
            // 
            lSurname.AutoSize = true;
            lSurname.Location = new Point(6, 19);
            lSurname.Name = "lSurname";
            lSurname.Size = new Size(0, 15);
            lSurname.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lDate);
            groupBox4.Location = new Point(33, 197);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(241, 47);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Data urodzenia";
            // 
            // lDate
            // 
            lDate.AutoSize = true;
            lDate.Location = new Point(6, 19);
            lDate.Name = "lDate";
            lDate.Size = new Size(0, 15);
            lDate.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lPhone);
            groupBox1.Location = new Point(33, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 47);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Telefon";
            // 
            // lPhone
            // 
            lPhone.AutoSize = true;
            lPhone.Location = new Point(6, 19);
            lPhone.Name = "lPhone";
            lPhone.Size = new Size(0, 15);
            lPhone.TabIndex = 3;
            // 
            // lbContacts
            // 
            lbContacts.BackColor = Color.FromArgb(55, 56, 68);
            lbContacts.BorderStyle = BorderStyle.None;
            lbContacts.ForeColor = Color.White;
            lbContacts.FormattingEnabled = true;
            lbContacts.ItemHeight = 15;
            lbContacts.Location = new Point(12, 30);
            lbContacts.Name = "lbContacts";
            lbContacts.Size = new Size(264, 360);
            lbContacts.TabIndex = 0;
            lbContacts.Click += ContactSelected;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(55, 56, 68);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lbContacts);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 390);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ImageAlign = ContentAlignment.BottomRight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(276, 27);
            label1.TabIndex = 1;
            label1.Text = "Lista kontaktów:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pEditContact
            // 
            pEditContact.BackColor = Color.Transparent;
            pEditContact.Controls.Add(pSearch);
            pEditContact.Controls.Add(bSubmit);
            pEditContact.Controls.Add(lTitle);
            pEditContact.Controls.Add(gbName);
            pEditContact.Controls.Add(gbSurname);
            pEditContact.Controls.Add(gbDate);
            pEditContact.Controls.Add(gbPhone);
            pEditContact.Location = new Point(282, 24);
            pEditContact.Name = "pEditContact";
            pEditContact.Size = new Size(518, 390);
            pEditContact.TabIndex = 12;
            pEditContact.Visible = false;
            // 
            // pSearch
            // 
            pSearch.BackColor = Color.Transparent;
            pSearch.Controls.Add(bSearch);
            pSearch.Controls.Add(label3);
            pSearch.Controls.Add(groupBox9);
            pSearch.Location = new Point(0, 0);
            pSearch.Name = "pSearch";
            pSearch.Size = new Size(518, 390);
            pSearch.TabIndex = 13;
            pSearch.Visible = false;
            // 
            // bSearch
            // 
            bSearch.BackColor = Color.Transparent;
            bSearch.Location = new Point(15, 337);
            bSearch.Name = "bSearch";
            bSearch.Size = new Size(491, 36);
            bSearch.TabIndex = 12;
            bSearch.Text = "Szukaj";
            bSearch.UseVisualStyleBackColor = false;
            bSearch.Click += SearchSubmit;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(33, 30);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 11;
            label3.Text = "Szukaj:";
            // 
            // groupBox9
            // 
            groupBox9.BackColor = Color.Transparent;
            groupBox9.Controls.Add(tbSearch);
            groupBox9.Location = new Point(33, 71);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(457, 47);
            groupBox9.TabIndex = 4;
            groupBox9.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = SystemColors.Window;
            tbSearch.Location = new Point(6, 16);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Wyszukaj...";
            tbSearch.Size = new Size(445, 23);
            tbSearch.TabIndex = 13;
            // 
            // bSubmit
            // 
            bSubmit.BackColor = Color.Transparent;
            bSubmit.Location = new Point(15, 337);
            bSubmit.Name = "bSubmit";
            bSubmit.Size = new Size(491, 36);
            bSubmit.TabIndex = 12;
            bSubmit.Text = "Dodaj";
            bSubmit.UseVisualStyleBackColor = false;
            bSubmit.Click += AddContactSubmit;
            // 
            // lTitle
            // 
            lTitle.AutoSize = true;
            lTitle.Font = new Font("Segoe UI", 15F);
            lTitle.Location = new Point(33, 30);
            lTitle.Name = "lTitle";
            lTitle.Size = new Size(141, 28);
            lTitle.TabIndex = 11;
            lTitle.Text = "Dodaj kontakt:";
            // 
            // gbName
            // 
            gbName.Controls.Add(tbName);
            gbName.ForeColor = Color.Black;
            gbName.Location = new Point(33, 71);
            gbName.Name = "gbName";
            gbName.Size = new Size(241, 47);
            gbName.TabIndex = 4;
            gbName.TabStop = false;
            gbName.Text = "Imię";
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.Window;
            tbName.Location = new Point(6, 16);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Podaj imię...";
            tbName.Size = new Size(229, 23);
            tbName.TabIndex = 13;
            // 
            // gbSurname
            // 
            gbSurname.Controls.Add(tbSurname);
            gbSurname.Location = new Point(33, 134);
            gbSurname.Name = "gbSurname";
            gbSurname.Size = new Size(241, 47);
            gbSurname.TabIndex = 0;
            gbSurname.TabStop = false;
            gbSurname.Text = "Nazwisko";
            // 
            // tbSurname
            // 
            tbSurname.BackColor = SystemColors.Window;
            tbSurname.Location = new Point(6, 16);
            tbSurname.Name = "tbSurname";
            tbSurname.PlaceholderText = "Podaj nazwisko...";
            tbSurname.Size = new Size(229, 23);
            tbSurname.TabIndex = 14;
            // 
            // gbDate
            // 
            gbDate.Controls.Add(dtpDate);
            gbDate.Location = new Point(33, 197);
            gbDate.Name = "gbDate";
            gbDate.Size = new Size(241, 47);
            gbDate.TabIndex = 0;
            gbDate.TabStop = false;
            gbDate.Text = "Data urodzenia";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(6, 18);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(229, 23);
            dtpDate.TabIndex = 15;
            // 
            // gbPhone
            // 
            gbPhone.Controls.Add(tbPhone);
            gbPhone.Location = new Point(33, 266);
            gbPhone.Name = "gbPhone";
            gbPhone.Size = new Size(241, 47);
            gbPhone.TabIndex = 10;
            gbPhone.TabStop = false;
            gbPhone.Text = "Telefon";
            // 
            // tbPhone
            // 
            tbPhone.BackColor = SystemColors.Window;
            tbPhone.Location = new Point(6, 16);
            tbPhone.MaxLength = 11;
            tbPhone.Name = "tbPhone";
            tbPhone.PlaceholderText = "Podaj numer telefonu...";
            tbPhone.Size = new Size(229, 23);
            tbPhone.TabIndex = 15;
            tbPhone.KeyPress += PhoneInput;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 174, 188);
            ClientSize = new Size(800, 436);
            Controls.Add(pEditContact);
            Controls.Add(panel2);
            Controls.Add(pContactData);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Kontakty Jakub I.";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pContactData.ResumeLayout(false);
            pContactData.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            pEditContact.ResumeLayout(false);
            pEditContact.PerformLayout();
            pSearch.ResumeLayout(false);
            pSearch.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            gbName.ResumeLayout(false);
            gbName.PerformLayout();
            gbSurname.ResumeLayout(false);
            gbSurname.PerformLayout();
            gbDate.ResumeLayout(false);
            gbPhone.ResumeLayout(false);
            gbPhone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kontaktyToolStripMenuItem;
        private ToolStripMenuItem miNewContacts;
        private ToolStripMenuItem miAddContact;
        private ToolStripMenuItem miDeleteContact;
        private ToolStripMenuItem miEditContact;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem miSave;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem miEnd;
        private ToolStripMenuItem sortowanieToolStripMenuItem;
        private ToolStripMenuItem miSortByName;
        private ToolStripMenuItem miSortBySurname;
        private ToolStripMenuItem miSortByDate;
        private ToolStripMenuItem miPomoc;
        private ToolStripMenuItem miHelp;
        private ToolStripMenuItem miAuthor;
        private ToolStripMenuItem miSearch;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel slNumberOfPeople;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel slActive;
        private Panel pContactData;
        private ListBox lbContacts;
        private Panel panel2;
        private Label label1;
        private GroupBox groupBox2;
        private Label lName;
        private GroupBox groupBox3;
        private Label lSurname;
        private GroupBox groupBox4;
        private Label lDate;
        private GroupBox groupBox1;
        private Label lPhone;
        private ToolStripSeparator toolStripSeparator3;
        private Label label2;
        private Panel pEditContact;
        private Label lTitle;
        private GroupBox gbName;
        private GroupBox gbSurname;
        private GroupBox gbDate;
        private GroupBox gbPhone;
        private Button bSubmit;
        private TextBox tbName;
        private TextBox tbSurname;
        private TextBox tbPhone;
        private DateTimePicker dtpDate;
        private Panel pSearch;
        private Button bSearch;
        private Label label3;
        private GroupBox groupBox9;
        private TextBox tbSearch;
    }
}
