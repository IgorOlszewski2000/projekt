
namespace ProjektZPI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSEND = new System.Windows.Forms.Button();
            this.textBoxRFIDtag = new System.Windows.Forms.TextBox();
            this.labelNazwa = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.textBoxIpBroker = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.comboBoxTest = new System.Windows.Forms.ComboBox();
            this.buttonF5 = new System.Windows.Forms.Button();
            this.comboBoxRoomList = new System.Windows.Forms.ComboBox();
            this.buttonDostep = new System.Windows.Forms.Button();
            this.labelJestDostep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "WŁAŚNIE ZESKANOWANY TAG";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSEND
            // 
            this.buttonSEND.Location = new System.Drawing.Point(166, 151);
            this.buttonSEND.Name = "buttonSEND";
            this.buttonSEND.Size = new System.Drawing.Size(75, 23);
            this.buttonSEND.TabIndex = 2;
            this.buttonSEND.Text = "SEND";
            this.buttonSEND.UseVisualStyleBackColor = true;
            this.buttonSEND.Click += new System.EventHandler(this.buttonSEND_Click);
            // 
            // textBoxRFIDtag
            // 
            this.textBoxRFIDtag.Location = new System.Drawing.Point(33, 98);
            this.textBoxRFIDtag.Name = "textBoxRFIDtag";
            this.textBoxRFIDtag.Size = new System.Drawing.Size(145, 20);
            this.textBoxRFIDtag.TabIndex = 3;
            this.textBoxRFIDtag.TextChanged += new System.EventHandler(this.textBoxRFIDtag_TextChanged);
            // 
            // labelNazwa
            // 
            this.labelNazwa.AutoSize = true;
            this.labelNazwa.Location = new System.Drawing.Point(266, 71);
            this.labelNazwa.Name = "labelNazwa";
            this.labelNazwa.Size = new System.Drawing.Size(47, 13);
            this.labelNazwa.TabIndex = 5;
            this.labelNazwa.Text = "NAZWA";
            this.labelNazwa.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOPIC";
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(566, 98);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(131, 20);
            this.textBoxTopic.TabIndex = 7;
            this.textBoxTopic.Text = "ESP8266-1";
            // 
            // textBoxIpBroker
            // 
            this.textBoxIpBroker.Location = new System.Drawing.Point(566, 151);
            this.textBoxIpBroker.Name = "textBoxIpBroker";
            this.textBoxIpBroker.Size = new System.Drawing.Size(131, 20);
            this.textBoxIpBroker.TabIndex = 8;
            this.textBoxIpBroker.Text = "192.168.1.167";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "IP BROKER";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(582, 188);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(96, 23);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "START SUB";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(582, 230);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(96, 23);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.Text = "STOP SUB";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(223, 98);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(142, 20);
            this.textBoxNazwa.TabIndex = 12;
            // 
            // comboBoxTest
            // 
            this.comboBoxTest.FormattingEnabled = true;
            this.comboBoxTest.Location = new System.Drawing.Point(24, 199);
            this.comboBoxTest.Name = "comboBoxTest";
            this.comboBoxTest.Size = new System.Drawing.Size(417, 21);
            this.comboBoxTest.TabIndex = 13;
            this.comboBoxTest.SelectedIndexChanged += new System.EventHandler(this.comboBoxTest_SelectedIndexChanged);
            // 
            // buttonF5
            // 
            this.buttonF5.Location = new System.Drawing.Point(141, 242);
            this.buttonF5.Name = "buttonF5";
            this.buttonF5.Size = new System.Drawing.Size(121, 23);
            this.buttonF5.TabIndex = 14;
            this.buttonF5.Text = "PRZEŁADUJ";
            this.buttonF5.UseVisualStyleBackColor = true;
            this.buttonF5.Click += new System.EventHandler(this.buttonF5_Click);
            // 
            // comboBoxRoomList
            // 
            this.comboBoxRoomList.FormattingEnabled = true;
            this.comboBoxRoomList.Location = new System.Drawing.Point(24, 313);
            this.comboBoxRoomList.Name = "comboBoxRoomList";
            this.comboBoxRoomList.Size = new System.Drawing.Size(417, 21);
            this.comboBoxRoomList.TabIndex = 15;
            // 
            // buttonDostep
            // 
            this.buttonDostep.Location = new System.Drawing.Point(141, 366);
            this.buttonDostep.Name = "buttonDostep";
            this.buttonDostep.Size = new System.Drawing.Size(121, 23);
            this.buttonDostep.TabIndex = 16;
            this.buttonDostep.Text = "WEJDZ";
            this.buttonDostep.UseVisualStyleBackColor = true;
            this.buttonDostep.Click += new System.EventHandler(this.buttonDostep_Click);
            // 
            // labelJestDostep
            // 
            this.labelJestDostep.AutoSize = true;
            this.labelJestDostep.Location = new System.Drawing.Point(509, 313);
            this.labelJestDostep.Name = "labelJestDostep";
            this.labelJestDostep.Size = new System.Drawing.Size(34, 13);
            this.labelJestDostep.TabIndex = 17;
            this.labelJestDostep.Text = "         ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelJestDostep);
            this.Controls.Add(this.buttonDostep);
            this.Controls.Add(this.comboBoxRoomList);
            this.Controls.Add(this.buttonF5);
            this.Controls.Add(this.comboBoxTest);
            this.Controls.Add(this.textBoxNazwa);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxIpBroker);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNazwa);
            this.Controls.Add(this.textBoxRFIDtag);
            this.Controls.Add(this.buttonSEND);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSEND;
        private System.Windows.Forms.TextBox textBoxRFIDtag;
        private System.Windows.Forms.Label labelNazwa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.TextBox textBoxIpBroker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.ComboBox comboBoxTest;
        private System.Windows.Forms.Button buttonF5;
        private System.Windows.Forms.ComboBox comboBoxRoomList;
        private System.Windows.Forms.Button buttonDostep;
        private System.Windows.Forms.Label labelJestDostep;
    }
}

