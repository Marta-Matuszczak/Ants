namespace ant_colony
{
    partial class ant_colony_s_path
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
            this.Draw_button = new System.Windows.Forms.Button();
            this.alpha_Box = new System.Windows.Forms.TextBox();
            this.beta_Box = new System.Windows.Forms.TextBox();
            this.rho_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.random_cities_button = new System.Windows.Forms.Button();
            this.define_cities_Button = new System.Windows.Forms.Button();
            this.number_Cities_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.number_Ants_Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iterationBox = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.Best_Tour_Box = new System.Windows.Forms.Label();
            this.brute_force_button = new System.Windows.Forms.Button();
            this.brute_length_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.totalTimeBrute = new System.Windows.Forms.Label();
            this.timeBruteLabel = new System.Windows.Forms.Label();
            this.antColonyTimeLabel = new System.Windows.Forms.Label();
            this.totalTimeACO = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.get_saved_cities_button = new System.Windows.Forms.Button();
            this.given_cities_button = new System.Windows.Forms.Button();
            this.save_cities_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Insertion_algorithm_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.textBoxSkok = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxWybor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxZestawDanych = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxAcoLimit = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pherom_const_Box = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxZestawDanychStop = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Draw_button
            // 
            this.Draw_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Draw_button.Location = new System.Drawing.Point(11, 19);
            this.Draw_button.Name = "Draw_button";
            this.Draw_button.Size = new System.Drawing.Size(174, 35);
            this.Draw_button.TabIndex = 10;
            this.Draw_button.Text = "Algorytm mrówkowy";
            this.Draw_button.UseVisualStyleBackColor = true;
            this.Draw_button.Click += new System.EventHandler(this.Draw_button_Click);
            // 
            // alpha_Box
            // 
            this.alpha_Box.Location = new System.Drawing.Point(95, 125);
            this.alpha_Box.Name = "alpha_Box";
            this.alpha_Box.Size = new System.Drawing.Size(45, 20);
            this.alpha_Box.TabIndex = 4;
            this.alpha_Box.Text = "1";
            // 
            // beta_Box
            // 
            this.beta_Box.Location = new System.Drawing.Point(95, 159);
            this.beta_Box.Name = "beta_Box";
            this.beta_Box.Size = new System.Drawing.Size(45, 20);
            this.beta_Box.TabIndex = 5;
            this.beta_Box.Text = "1";
            // 
            // rho_Box
            // 
            this.rho_Box.Location = new System.Drawing.Point(95, 193);
            this.rho_Box.Name = "rho_Box";
            this.rho_Box.Size = new System.Drawing.Size(45, 20);
            this.rho_Box.TabIndex = 6;
            this.rho_Box.Text = "0,5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alfa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Beta: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wspó³czynnik\r\nwyparowywania:";
            // 
            // random_cities_button
            // 
            this.random_cities_button.Location = new System.Drawing.Point(21, 23);
            this.random_cities_button.Name = "random_cities_button";
            this.random_cities_button.Size = new System.Drawing.Size(115, 23);
            this.random_cities_button.TabIndex = 7;
            this.random_cities_button.Text = "Losowe";
            this.random_cities_button.UseVisualStyleBackColor = true;
            this.random_cities_button.Click += new System.EventHandler(this.random_cities_button_Click);
            // 
            // define_cities_Button
            // 
            this.define_cities_Button.Location = new System.Drawing.Point(21, 59);
            this.define_cities_Button.Name = "define_cities_Button";
            this.define_cities_Button.Size = new System.Drawing.Size(115, 23);
            this.define_cities_Button.TabIndex = 8;
            this.define_cities_Button.Text = "Rêczne";
            this.define_cities_Button.UseVisualStyleBackColor = true;
            this.define_cities_Button.Click += new System.EventHandler(this.define_cities_Button_Click);
            // 
            // number_Cities_Box
            // 
            this.number_Cities_Box.Location = new System.Drawing.Point(95, 23);
            this.number_Cities_Box.Name = "number_Cities_Box";
            this.number_Cities_Box.Size = new System.Drawing.Size(45, 20);
            this.number_Cities_Box.TabIndex = 1;
            this.number_Cities_Box.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Liczba miast:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Liczba mrówek:";
            // 
            // number_Ants_Box
            // 
            this.number_Ants_Box.Location = new System.Drawing.Point(95, 57);
            this.number_Ants_Box.Name = "number_Ants_Box";
            this.number_Ants_Box.Size = new System.Drawing.Size(45, 20);
            this.number_Ants_Box.TabIndex = 2;
            this.number_Ants_Box.Text = "90";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Liczba iteracji:";
            // 
            // iterationBox
            // 
            this.iterationBox.Location = new System.Drawing.Point(95, 91);
            this.iterationBox.Name = "iterationBox";
            this.iterationBox.Size = new System.Drawing.Size(45, 20);
            this.iterationBox.TabIndex = 3;
            this.iterationBox.Text = "110";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(21, 95);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(115, 23);
            this.clear_button.TabIndex = 9;
            this.clear_button.Text = "Wyczyœæ";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "D³ugoœæ œcie¿ki:";
            // 
            // Best_Tour_Box
            // 
            this.Best_Tour_Box.AutoSize = true;
            this.Best_Tour_Box.Location = new System.Drawing.Point(94, 27);
            this.Best_Tour_Box.Name = "Best_Tour_Box";
            this.Best_Tour_Box.Size = new System.Drawing.Size(13, 13);
            this.Best_Tour_Box.TabIndex = 18;
            this.Best_Tour_Box.Text = "0";
            // 
            // brute_force_button
            // 
            this.brute_force_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brute_force_button.Location = new System.Drawing.Point(202, 19);
            this.brute_force_button.Name = "brute_force_button";
            this.brute_force_button.Size = new System.Drawing.Size(174, 35);
            this.brute_force_button.TabIndex = 11;
            this.brute_force_button.Text = "Wyszukiwanie wyczerpuj¹ce";
            this.brute_force_button.UseVisualStyleBackColor = true;
            this.brute_force_button.Click += new System.EventHandler(this.brute_force_button_Click);
            // 
            // brute_length_label
            // 
            this.brute_length_label.AutoSize = true;
            this.brute_length_label.Location = new System.Drawing.Point(93, 27);
            this.brute_length_label.Name = "brute_length_label";
            this.brute_length_label.Size = new System.Drawing.Size(13, 13);
            this.brute_length_label.TabIndex = 21;
            this.brute_length_label.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "D³ugoœæ œcie¿ki:";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // totalTimeBrute
            // 
            this.totalTimeBrute.AutoSize = true;
            this.totalTimeBrute.Location = new System.Drawing.Point(93, 50);
            this.totalTimeBrute.Name = "totalTimeBrute";
            this.totalTimeBrute.Size = new System.Drawing.Size(13, 13);
            this.totalTimeBrute.TabIndex = 22;
            this.totalTimeBrute.Text = "0";
            // 
            // timeBruteLabel
            // 
            this.timeBruteLabel.AutoSize = true;
            this.timeBruteLabel.Location = new System.Drawing.Point(46, 50);
            this.timeBruteLabel.Name = "timeBruteLabel";
            this.timeBruteLabel.Size = new System.Drawing.Size(47, 13);
            this.timeBruteLabel.TabIndex = 23;
            this.timeBruteLabel.Text = "Czas (s):";
            // 
            // antColonyTimeLabel
            // 
            this.antColonyTimeLabel.AutoSize = true;
            this.antColonyTimeLabel.Location = new System.Drawing.Point(47, 50);
            this.antColonyTimeLabel.Name = "antColonyTimeLabel";
            this.antColonyTimeLabel.Size = new System.Drawing.Size(47, 13);
            this.antColonyTimeLabel.TabIndex = 24;
            this.antColonyTimeLabel.Text = "Czas (s):";
            // 
            // totalTimeACO
            // 
            this.totalTimeACO.AutoSize = true;
            this.totalTimeACO.Location = new System.Drawing.Point(94, 50);
            this.totalTimeACO.Name = "totalTimeACO";
            this.totalTimeACO.Size = new System.Drawing.Size(13, 13);
            this.totalTimeACO.TabIndex = 25;
            this.totalTimeACO.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(192, 382);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(388, 23);
            this.progressBar1.TabIndex = 26;
            this.progressBar1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.iterationBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rho_Box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.number_Ants_Box);
            this.groupBox1.Controls.Add(this.beta_Box);
            this.groupBox1.Controls.Add(this.alpha_Box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.number_Cities_Box);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 262);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "parametry";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 220);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 26);
            this.label20.TabIndex = 15;
            this.label20.Text = "Sta³a\r\nferomony:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.get_saved_cities_button);
            this.groupBox2.Controls.Add(this.clear_button);
            this.groupBox2.Controls.Add(this.given_cities_button);
            this.groupBox2.Controls.Add(this.define_cities_Button);
            this.groupBox2.Controls.Add(this.save_cities_button);
            this.groupBox2.Controls.Add(this.random_cities_button);
            this.groupBox2.Location = new System.Drawing.Point(18, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 276);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "po³o¿enie miast";
            // 
            // get_saved_cities_button
            // 
            this.get_saved_cities_button.Location = new System.Drawing.Point(21, 179);
            this.get_saved_cities_button.Name = "get_saved_cities_button";
            this.get_saved_cities_button.Size = new System.Drawing.Size(115, 35);
            this.get_saved_cities_button.TabIndex = 36;
            this.get_saved_cities_button.Text = "Wczytaj\r\nw³asny wzorzec";
            this.get_saved_cities_button.UseVisualStyleBackColor = true;
            this.get_saved_cities_button.Click += new System.EventHandler(this.get_saved_cities_button_Click);
            // 
            // given_cities_button
            // 
            this.given_cities_button.Location = new System.Drawing.Point(21, 131);
            this.given_cities_button.Name = "given_cities_button";
            this.given_cities_button.Size = new System.Drawing.Size(115, 35);
            this.given_cities_button.TabIndex = 34;
            this.given_cities_button.Text = "Wczytaj\r\ndomyœlny wzorzec";
            this.given_cities_button.UseVisualStyleBackColor = true;
            this.given_cities_button.Click += new System.EventHandler(this.given_cities_button_Click);
            // 
            // save_cities_button
            // 
            this.save_cities_button.Location = new System.Drawing.Point(21, 227);
            this.save_cities_button.Name = "save_cities_button";
            this.save_cities_button.Size = new System.Drawing.Size(115, 35);
            this.save_cities_button.TabIndex = 34;
            this.save_cities_button.Text = "Zapisz\r\nw³asny wzorzec";
            this.save_cities_button.UseVisualStyleBackColor = true;
            this.save_cities_button.Click += new System.EventHandler(this.save_cities_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Insertion_algorithm_button);
            this.groupBox3.Controls.Add(this.Draw_button);
            this.groupBox3.Controls.Add(this.brute_force_button);
            this.groupBox3.Location = new System.Drawing.Point(193, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 64);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "uruchom";
            // 
            // Insertion_algorithm_button
            // 
            this.Insertion_algorithm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Insertion_algorithm_button.Location = new System.Drawing.Point(393, 19);
            this.Insertion_algorithm_button.Name = "Insertion_algorithm_button";
            this.Insertion_algorithm_button.Size = new System.Drawing.Size(174, 35);
            this.Insertion_algorithm_button.TabIndex = 12;
            this.Insertion_algorithm_button.Text = "Algorytm w³¹czania";
            this.Insertion_algorithm_button.UseVisualStyleBackColor = true;
            this.Insertion_algorithm_button.Click += new System.EventHandler(this.Insertion_algorithm_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(14, 564);
            this.label9.MinimumSize = new System.Drawing.Size(590, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(590, 18);
            this.label9.TabIndex = 31;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.totalTimeACO);
            this.groupBox4.Controls.Add(this.antColonyTimeLabel);
            this.groupBox4.Controls.Add(this.Best_Tour_Box);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(193, 482);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 74);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "algorytm mrówkowy";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.timeBruteLabel);
            this.groupBox5.Controls.Add(this.totalTimeBrute);
            this.groupBox5.Controls.Add(this.brute_length_label);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(395, 482);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(185, 74);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "wyszukiwanie wyczerpuj¹ce";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(842, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(100, 751);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1019, 38);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(100, 751);
            this.textBox2.TabIndex = 35;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(597, 482);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(185, 74);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "algorytm w³¹czania";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Czas (s):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(94, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "D³ugoœæ œcie¿ki:";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(113, 616);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 36;
            this.textBoxOd.Text = "0";
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(113, 643);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 37;
            this.textBoxDo.Text = "5";
            // 
            // textBoxSkok
            // 
            this.textBoxSkok.Location = new System.Drawing.Point(113, 669);
            this.textBoxSkok.Name = "textBoxSkok";
            this.textBoxSkok.Size = new System.Drawing.Size(100, 20);
            this.textBoxSkok.TabIndex = 38;
            this.textBoxSkok.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 619);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Od";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(45, 646);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Do";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(45, 672);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Skok";
            // 
            // textBoxWybor
            // 
            this.textBoxWybor.Location = new System.Drawing.Point(278, 616);
            this.textBoxWybor.Name = "textBoxWybor";
            this.textBoxWybor.Size = new System.Drawing.Size(100, 20);
            this.textBoxWybor.TabIndex = 42;
            this.textBoxWybor.Text = "3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(281, 643);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 91);
            this.label17.TabIndex = 43;
            this.label17.Text = "0-nic\r\n1-mrówki\r\n2-iteracje\r\n3-alfa\r\n4-beta\r\n5-rho\r\n6-sta³a feromonowa";
            // 
            // textBoxZestawDanych
            // 
            this.textBoxZestawDanych.Location = new System.Drawing.Point(441, 616);
            this.textBoxZestawDanych.Name = "textBoxZestawDanych";
            this.textBoxZestawDanych.Size = new System.Drawing.Size(100, 20);
            this.textBoxZestawDanych.TabIndex = 44;
            this.textBoxZestawDanych.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(442, 643);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 26);
            this.label18.TabIndex = 45;
            this.label18.Text = "Zestaw danych 1-4\r\npocz¹tkowy";
            // 
            // textBoxAcoLimit
            // 
            this.textBoxAcoLimit.Location = new System.Drawing.Point(608, 616);
            this.textBoxAcoLimit.Name = "textBoxAcoLimit";
            this.textBoxAcoLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxAcoLimit.TabIndex = 46;
            this.textBoxAcoLimit.Text = "30";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(610, 643);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 39);
            this.label19.TabIndex = 47;
            this.label19.Text = "Iloœæ powtórzeñ\r\ndla jednego zestawu\r\ndanych";
            // 
            // pherom_const_Box
            // 
            this.pherom_const_Box.Location = new System.Drawing.Point(113, 236);
            this.pherom_const_Box.Name = "pherom_const_Box";
            this.pherom_const_Box.Size = new System.Drawing.Size(45, 20);
            this.pherom_const_Box.TabIndex = 48;
            this.pherom_const_Box.Text = "100";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(441, 708);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 26);
            this.label21.TabIndex = 49;
            this.label21.Text = "Zestaw danych 1-4\r\nkoñcowy";
            // 
            // textBoxZestawDanychStop
            // 
            this.textBoxZestawDanychStop.Location = new System.Drawing.Point(440, 682);
            this.textBoxZestawDanychStop.Name = "textBoxZestawDanychStop";
            this.textBoxZestawDanychStop.Size = new System.Drawing.Size(100, 20);
            this.textBoxZestawDanychStop.TabIndex = 50;
            this.textBoxZestawDanychStop.Text = "4";
            // 
            // ant_colony_s_path
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1177, 812);
            this.Controls.Add(this.textBoxZestawDanychStop);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pherom_const_Box);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxAcoLimit);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxZestawDanych);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxWybor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxSkok);
            this.Controls.Add(this.textBoxDo);
            this.Controls.Add(this.textBoxOd);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Name = "ant_colony_s_path";
            this.Text = "Algorymt mrówkowy (Ant Colony Optimization Algorithm)";
            this.Load += new System.EventHandler(this.ant_colony_s_path_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw_button;
        private System.Windows.Forms.TextBox alpha_Box;
        private System.Windows.Forms.TextBox beta_Box;
        private System.Windows.Forms.TextBox rho_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button random_cities_button;
        private System.Windows.Forms.Button define_cities_Button;
        private System.Windows.Forms.TextBox number_Cities_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox number_Ants_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox iterationBox;
        private System.Windows.Forms.Button clear_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Best_Tour_Box;
        private System.Windows.Forms.Button brute_force_button;
        private System.Windows.Forms.Label brute_length_label;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label totalTimeBrute;
        private System.Windows.Forms.Label timeBruteLabel;
        private System.Windows.Forms.Label antColonyTimeLabel;
        private System.Windows.Forms.Label totalTimeACO;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button given_cities_button;
        private System.Windows.Forms.Button save_cities_button;
        private System.Windows.Forms.Button get_saved_cities_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Insertion_algorithm_button;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxSkok;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxWybor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxZestawDanych;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxAcoLimit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox pherom_const_Box;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxZestawDanychStop;
    }
}

