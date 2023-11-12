namespace HotelOpgave
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Facilitet_Id = new System.Windows.Forms.TextBox();
            this.Hotel_Id = new System.Windows.Forms.TextBox();
            this.Facilitet_Navn = new System.Windows.Forms.TextBox();
            this.FindByFacilitet_Id = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FindByHotel_Id = new System.Windows.Forms.TextBox();
            this.FindById = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FindOnlyByFacilitet_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NewFacilitet_Id = new System.Windows.Forms.TextBox();
            this.NewHotel_Id = new System.Windows.Forms.TextBox();
            this.NewFacilitet_Navn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ShowAllTypes = new System.Windows.Forms.Button();
            this.Facilitet_Navn2 = new System.Windows.Forms.TextBox();
            this.Facilitet_Type = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.DeleteByName = new System.Windows.Forms.Button();
            this.NewFacilitet_Type2 = new System.Windows.Forms.TextBox();
            this.NewFacilitet_Navn2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Update2 = new System.Windows.Forms.Button();
            this.FindByFacilitet_Navn = new System.Windows.Forms.TextBox();
            this.FindByFacilitet_Type = new System.Windows.Forms.TextBox();
            this.FindByFacilitet_Navn_Knap = new System.Windows.Forms.Button();
            this.FindByFacilitet_Type_Knap = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facilitet_Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hotel_Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Facilitet_Navn";
            // 
            // Facilitet_Id
            // 
            this.Facilitet_Id.Location = new System.Drawing.Point(114, 42);
            this.Facilitet_Id.Name = "Facilitet_Id";
            this.Facilitet_Id.Size = new System.Drawing.Size(208, 20);
            this.Facilitet_Id.TabIndex = 3;
            // 
            // Hotel_Id
            // 
            this.Hotel_Id.Location = new System.Drawing.Point(114, 85);
            this.Hotel_Id.Name = "Hotel_Id";
            this.Hotel_Id.Size = new System.Drawing.Size(208, 20);
            this.Hotel_Id.TabIndex = 4;
            // 
            // Facilitet_Navn
            // 
            this.Facilitet_Navn.Location = new System.Drawing.Point(114, 126);
            this.Facilitet_Navn.Name = "Facilitet_Navn";
            this.Facilitet_Navn.Size = new System.Drawing.Size(208, 20);
            this.Facilitet_Navn.TabIndex = 5;
            // 
            // FindByFacilitet_Id
            // 
            this.FindByFacilitet_Id.Location = new System.Drawing.Point(443, 97);
            this.FindByFacilitet_Id.Name = "FindByFacilitet_Id";
            this.FindByFacilitet_Id.Size = new System.Drawing.Size(64, 20);
            this.FindByFacilitet_Id.TabIndex = 6;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(36, 162);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(151, 51);
            this.Create.TabIndex = 7;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(36, 449);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(324, 57);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(36, 229);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(324, 39);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.Lime;
            this.Find.Location = new System.Drawing.Point(637, 85);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(91, 42);
            this.Find.TabIndex = 10;
            this.Find.Text = "Find Facilitet_Id and Hotel_Id";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(209, 162);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(151, 51);
            this.ShowAll.TabIndex = 11;
            this.ShowAll.Text = "Show All";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(1388, 526);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(130, 53);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 373);
            this.dataGridView1.TabIndex = 13;
            // 
            // FindByHotel_Id
            // 
            this.FindByHotel_Id.Location = new System.Drawing.Point(566, 97);
            this.FindByHotel_Id.Name = "FindByHotel_Id";
            this.FindByHotel_Id.Size = new System.Drawing.Size(62, 20);
            this.FindByHotel_Id.TabIndex = 14;
            // 
            // FindById
            // 
            this.FindById.BackColor = System.Drawing.Color.Lime;
            this.FindById.Location = new System.Drawing.Point(637, 39);
            this.FindById.Name = "FindById";
            this.FindById.Size = new System.Drawing.Size(91, 40);
            this.FindById.TabIndex = 16;
            this.FindById.Text = "Find By Facilitet_Id";
            this.FindById.UseVisualStyleBackColor = false;
            this.FindById.Click += new System.EventHandler(this.FindById_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Facilitet_Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hotel_Id";
            // 
            // FindOnlyByFacilitet_Id
            // 
            this.FindOnlyByFacilitet_Id.Location = new System.Drawing.Point(443, 53);
            this.FindOnlyByFacilitet_Id.Name = "FindOnlyByFacilitet_Id";
            this.FindOnlyByFacilitet_Id.Size = new System.Drawing.Size(185, 20);
            this.FindOnlyByFacilitet_Id.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Facilitet_Id";
            // 
            // NewFacilitet_Id
            // 
            this.NewFacilitet_Id.Location = new System.Drawing.Point(136, 333);
            this.NewFacilitet_Id.Name = "NewFacilitet_Id";
            this.NewFacilitet_Id.Size = new System.Drawing.Size(224, 20);
            this.NewFacilitet_Id.TabIndex = 21;
            // 
            // NewHotel_Id
            // 
            this.NewHotel_Id.Location = new System.Drawing.Point(136, 373);
            this.NewHotel_Id.Name = "NewHotel_Id";
            this.NewHotel_Id.Size = new System.Drawing.Size(224, 20);
            this.NewHotel_Id.TabIndex = 22;
            // 
            // NewFacilitet_Navn
            // 
            this.NewFacilitet_Navn.Location = new System.Drawing.Point(136, 409);
            this.NewFacilitet_Navn.Name = "NewFacilitet_Navn";
            this.NewFacilitet_Navn.Size = new System.Drawing.Size(224, 20);
            this.NewFacilitet_Navn.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "New Facilitet_Navn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "New Hotel_Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "New Facilitet_Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "Insert New Update Values";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1129, 147);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(346, 359);
            this.dataGridView2.TabIndex = 28;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ShowAllTypes
            // 
            this.ShowAllTypes.Location = new System.Drawing.Point(951, 160);
            this.ShowAllTypes.Name = "ShowAllTypes";
            this.ShowAllTypes.Size = new System.Drawing.Size(153, 53);
            this.ShowAllTypes.TabIndex = 30;
            this.ShowAllTypes.Text = "Show All Types";
            this.ShowAllTypes.UseVisualStyleBackColor = true;
            this.ShowAllTypes.Click += new System.EventHandler(this.ShowAllTypes_Click);
            // 
            // Facilitet_Navn2
            // 
            this.Facilitet_Navn2.Location = new System.Drawing.Point(872, 77);
            this.Facilitet_Navn2.Name = "Facilitet_Navn2";
            this.Facilitet_Navn2.Size = new System.Drawing.Size(208, 20);
            this.Facilitet_Navn2.TabIndex = 31;
            // 
            // Facilitet_Type
            // 
            this.Facilitet_Type.Location = new System.Drawing.Point(872, 116);
            this.Facilitet_Type.Name = "Facilitet_Type";
            this.Facilitet_Type.Size = new System.Drawing.Size(208, 20);
            this.Facilitet_Type.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(755, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Facilitet_Navn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(755, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Facilitet_Type";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(758, 160);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(152, 53);
            this.Insert.TabIndex = 35;
            this.Insert.Text = "Create";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // DeleteByName
            // 
            this.DeleteByName.Location = new System.Drawing.Point(758, 228);
            this.DeleteByName.Name = "DeleteByName";
            this.DeleteByName.Size = new System.Drawing.Size(346, 40);
            this.DeleteByName.TabIndex = 36;
            this.DeleteByName.Text = "Delete";
            this.DeleteByName.UseVisualStyleBackColor = true;
            this.DeleteByName.Click += new System.EventHandler(this.DeleteByName_Click);
            // 
            // NewFacilitet_Type2
            // 
            this.NewFacilitet_Type2.Location = new System.Drawing.Point(872, 405);
            this.NewFacilitet_Type2.Name = "NewFacilitet_Type2";
            this.NewFacilitet_Type2.Size = new System.Drawing.Size(232, 20);
            this.NewFacilitet_Type2.TabIndex = 37;
            // 
            // NewFacilitet_Navn2
            // 
            this.NewFacilitet_Navn2.Location = new System.Drawing.Point(872, 353);
            this.NewFacilitet_Navn2.Name = "NewFacilitet_Navn2";
            this.NewFacilitet_Navn2.Size = new System.Drawing.Size(232, 20);
            this.NewFacilitet_Navn2.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(766, 356);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "New Facilitet_Navn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(766, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "New Facilitet Type";
            // 
            // Update2
            // 
            this.Update2.Location = new System.Drawing.Point(769, 449);
            this.Update2.Name = "Update2";
            this.Update2.Size = new System.Drawing.Size(335, 57);
            this.Update2.TabIndex = 41;
            this.Update2.Text = "Update";
            this.Update2.UseVisualStyleBackColor = true;
            this.Update2.Click += new System.EventHandler(this.Update2_Click);
            // 
            // FindByFacilitet_Navn
            // 
            this.FindByFacilitet_Navn.Location = new System.Drawing.Point(1207, 43);
            this.FindByFacilitet_Navn.Name = "FindByFacilitet_Navn";
            this.FindByFacilitet_Navn.Size = new System.Drawing.Size(175, 20);
            this.FindByFacilitet_Navn.TabIndex = 42;
            // 
            // FindByFacilitet_Type
            // 
            this.FindByFacilitet_Type.Location = new System.Drawing.Point(1207, 106);
            this.FindByFacilitet_Type.Name = "FindByFacilitet_Type";
            this.FindByFacilitet_Type.Size = new System.Drawing.Size(175, 20);
            this.FindByFacilitet_Type.TabIndex = 43;
            // 
            // FindByFacilitet_Navn_Knap
            // 
            this.FindByFacilitet_Navn_Knap.BackColor = System.Drawing.Color.Lime;
            this.FindByFacilitet_Navn_Knap.Location = new System.Drawing.Point(1388, 34);
            this.FindByFacilitet_Navn_Knap.Name = "FindByFacilitet_Navn_Knap";
            this.FindByFacilitet_Navn_Knap.Size = new System.Drawing.Size(87, 36);
            this.FindByFacilitet_Navn_Knap.TabIndex = 44;
            this.FindByFacilitet_Navn_Knap.Text = "Find By Facilitet_Navn";
            this.FindByFacilitet_Navn_Knap.UseVisualStyleBackColor = false;
            this.FindByFacilitet_Navn_Knap.Click += new System.EventHandler(this.FindByFacilitet_Navn_Knap_Click);
            // 
            // FindByFacilitet_Type_Knap
            // 
            this.FindByFacilitet_Type_Knap.BackColor = System.Drawing.Color.Lime;
            this.FindByFacilitet_Type_Knap.Location = new System.Drawing.Point(1388, 97);
            this.FindByFacilitet_Type_Knap.Name = "FindByFacilitet_Type_Knap";
            this.FindByFacilitet_Type_Knap.Size = new System.Drawing.Size(87, 36);
            this.FindByFacilitet_Type_Knap.TabIndex = 45;
            this.FindByFacilitet_Type_Knap.Text = "Find By Facilitet_Type";
            this.FindByFacilitet_Type_Knap.UseVisualStyleBackColor = false;
            this.FindByFacilitet_Type_Knap.Click += new System.EventHandler(this.FindByFacilitet_Type_Knap_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1126, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Facilitet_Navn";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1128, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "Facilitet_Type";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(282, 23);
            this.label11.TabIndex = 48;
            this.label11.Text = "Facilitet CRUD";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(764, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(301, 25);
            this.label18.TabIndex = 49;
            this.label18.Text = "Facilitet_Type_Aktivitet CRUD";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(820, 299);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(232, 24);
            this.label19.TabIndex = 50;
            this.label19.Text = " Insert New Update Values";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 582);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.FindByFacilitet_Type_Knap);
            this.Controls.Add(this.FindByFacilitet_Navn_Knap);
            this.Controls.Add(this.FindByFacilitet_Type);
            this.Controls.Add(this.FindByFacilitet_Navn);
            this.Controls.Add(this.Update2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NewFacilitet_Navn2);
            this.Controls.Add(this.NewFacilitet_Type2);
            this.Controls.Add(this.DeleteByName);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Facilitet_Type);
            this.Controls.Add(this.Facilitet_Navn2);
            this.Controls.Add(this.ShowAllTypes);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NewFacilitet_Navn);
            this.Controls.Add(this.NewHotel_Id);
            this.Controls.Add(this.NewFacilitet_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FindOnlyByFacilitet_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FindById);
            this.Controls.Add(this.FindByHotel_Id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.FindByFacilitet_Id);
            this.Controls.Add(this.Facilitet_Navn);
            this.Controls.Add(this.Hotel_Id);
            this.Controls.Add(this.Facilitet_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Facilitet_Id;
        private System.Windows.Forms.TextBox Hotel_Id;
        private System.Windows.Forms.TextBox Facilitet_Navn;
        private System.Windows.Forms.TextBox FindByFacilitet_Id;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox FindByHotel_Id;
        private System.Windows.Forms.Button FindById;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FindOnlyByFacilitet_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NewFacilitet_Id;
        private System.Windows.Forms.TextBox NewHotel_Id;
        private System.Windows.Forms.TextBox NewFacilitet_Navn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ShowAllTypes;
        private System.Windows.Forms.TextBox Facilitet_Navn2;
        private System.Windows.Forms.TextBox Facilitet_Type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button DeleteByName;
        private System.Windows.Forms.TextBox NewFacilitet_Type2;
        private System.Windows.Forms.TextBox NewFacilitet_Navn2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Update2;
        private System.Windows.Forms.TextBox FindByFacilitet_Navn;
        private System.Windows.Forms.TextBox FindByFacilitet_Type;
        private System.Windows.Forms.Button FindByFacilitet_Navn_Knap;
        private System.Windows.Forms.Button FindByFacilitet_Type_Knap;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

