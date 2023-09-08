namespace 코딩타자연습게임
{
    partial class Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.grpScore = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.rbtnEasy = new System.Windows.Forms.RadioButton();
            this.grpSpeed = new System.Windows.Forms.GroupBox();
            this.tkBarSpeed = new System.Windows.Forms.TrackBar();
            this.grpTutorial = new System.Windows.Forms.GroupBox();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.wBugImg3 = new System.Windows.Forms.PictureBox();
            this.wBugImg2 = new System.Windows.Forms.PictureBox();
            this.wBugImg1 = new System.Windows.Forms.PictureBox();
            this.bBugImg = new System.Windows.Forms.PictureBox();
            this.tumblerImg = new System.Windows.Forms.PictureBox();
            this.coffeeImg = new System.Windows.Forms.PictureBox();
            this.keyboardImg = new System.Windows.Forms.PictureBox();
            this.languageImg = new System.Windows.Forms.PictureBox();
            this.laptopImg = new System.Windows.Forms.PictureBox();
            this.lblWords = new System.Windows.Forms.Label();
            this.txtBoxTyping = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.pgBarBattery = new System.Windows.Forms.ProgressBar();
            this.lblLogo = new System.Windows.Forms.Label();
            this.tmrWords = new System.Windows.Forms.Timer(this.components);
            this.lblBattery = new System.Windows.Forms.Label();
            this.batteryImage = new System.Windows.Forms.PictureBox();
            this.grpbBug = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbtnbOff = new System.Windows.Forms.RadioButton();
            this.rbtnbOn = new System.Windows.Forms.RadioButton();
            this.grpScore.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.grpSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkBarSpeed)).BeginInit();
            this.grpTutorial.SuspendLayout();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wBugImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wBugImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wBugImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBugImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumblerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteryImage)).BeginInit();
            this.grpbBug.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpScore
            // 
            this.grpScore.Controls.Add(this.lblTime);
            this.grpScore.Controls.Add(this.lblAvg);
            this.grpScore.Controls.Add(this.lblTotal);
            this.grpScore.Controls.Add(this.lblWrong);
            this.grpScore.Controls.Add(this.lblCorrect);
            this.grpScore.Controls.Add(this.label5);
            this.grpScore.Controls.Add(this.label4);
            this.grpScore.Controls.Add(this.label3);
            this.grpScore.Controls.Add(this.label2);
            this.grpScore.Controls.Add(this.label1);
            this.grpScore.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grpScore.Location = new System.Drawing.Point(487, 53);
            this.grpScore.Name = "grpScore";
            this.grpScore.Size = new System.Drawing.Size(178, 222);
            this.grpScore.TabIndex = 2;
            this.grpScore.TabStop = false;
            this.grpScore.Text = "Total Score";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.ForeColor = System.Drawing.Color.Snow;
            this.lblTime.Location = new System.Drawing.Point(93, 170);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(2, 21);
            this.lblTime.TabIndex = 18;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvg.ForeColor = System.Drawing.Color.Snow;
            this.lblAvg.Location = new System.Drawing.Point(93, 141);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(2, 21);
            this.lblAvg.TabIndex = 17;
            this.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.ForeColor = System.Drawing.Color.Snow;
            this.lblTotal.Location = new System.Drawing.Point(93, 100);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 21);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWrong
            // 
            this.lblWrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWrong.AutoSize = true;
            this.lblWrong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWrong.ForeColor = System.Drawing.Color.Snow;
            this.lblWrong.Location = new System.Drawing.Point(93, 74);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(19, 21);
            this.lblWrong.TabIndex = 15;
            this.lblWrong.Text = "0";
            this.lblWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrong.TextChanged += new System.EventHandler(this.lblWrong_TextChanged);
            // 
            // lblCorrect
            // 
            this.lblCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCorrect.ForeColor = System.Drawing.Color.Snow;
            this.lblCorrect.Location = new System.Drawing.Point(93, 46);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(19, 21);
            this.lblCorrect.TabIndex = 14;
            this.lblCorrect.Text = "0";
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("함초롬돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(14, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "연습 시간 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("함초롬돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(14, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "평균 타수 :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("함초롬돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "누적 점수 :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "틀린 개수 :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "맞힌 개수 :";
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.rbtnHard);
            this.grpMode.Controls.Add(this.rbtnEasy);
            this.grpMode.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grpMode.Location = new System.Drawing.Point(487, 276);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(87, 100);
            this.grpMode.TabIndex = 3;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Mode";
            // 
            // rbtnHard
            // 
            this.rbtnHard.AutoSize = true;
            this.rbtnHard.Location = new System.Drawing.Point(13, 58);
            this.rbtnHard.Name = "rbtnHard";
            this.rbtnHard.Size = new System.Drawing.Size(59, 23);
            this.rbtnHard.TabIndex = 1;
            this.rbtnHard.TabStop = true;
            this.rbtnHard.Text = "Hard";
            this.rbtnHard.UseVisualStyleBackColor = true;
            // 
            // rbtnEasy
            // 
            this.rbtnEasy.AutoSize = true;
            this.rbtnEasy.Location = new System.Drawing.Point(13, 32);
            this.rbtnEasy.Name = "rbtnEasy";
            this.rbtnEasy.Size = new System.Drawing.Size(59, 23);
            this.rbtnEasy.TabIndex = 0;
            this.rbtnEasy.TabStop = true;
            this.rbtnEasy.Text = "Easy";
            this.rbtnEasy.UseVisualStyleBackColor = true;
            // 
            // grpSpeed
            // 
            this.grpSpeed.Controls.Add(this.tkBarSpeed);
            this.grpSpeed.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpSpeed.Location = new System.Drawing.Point(487, 375);
            this.grpSpeed.Name = "grpSpeed";
            this.grpSpeed.Size = new System.Drawing.Size(178, 76);
            this.grpSpeed.TabIndex = 4;
            this.grpSpeed.TabStop = false;
            this.grpSpeed.Text = "Speed";
            // 
            // tkBarSpeed
            // 
            this.tkBarSpeed.BackColor = System.Drawing.SystemColors.Desktop;
            this.tkBarSpeed.Location = new System.Drawing.Point(41, 26);
            this.tkBarSpeed.Maximum = 5;
            this.tkBarSpeed.Minimum = 1;
            this.tkBarSpeed.Name = "tkBarSpeed";
            this.tkBarSpeed.Size = new System.Drawing.Size(104, 45);
            this.tkBarSpeed.TabIndex = 0;
            this.tkBarSpeed.Value = 1;
            this.tkBarSpeed.Scroll += new System.EventHandler(this.tkBarSpeed_Scroll);
            // 
            // grpTutorial
            // 
            this.grpTutorial.Controls.Add(this.lblTutorial);
            this.grpTutorial.Controls.Add(this.label8);
            this.grpTutorial.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpTutorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpTutorial.Location = new System.Drawing.Point(487, 454);
            this.grpTutorial.Name = "grpTutorial";
            this.grpTutorial.Size = new System.Drawing.Size(178, 234);
            this.grpTutorial.TabIndex = 3;
            this.grpTutorial.TabStop = false;
            this.grpTutorial.Text = "Tutorial";
            // 
            // lblTutorial
            // 
            this.lblTutorial.AutoSize = true;
            this.lblTutorial.Font = new System.Drawing.Font("함초롬돋움", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTutorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTutorial.Location = new System.Drawing.Point(39, 29);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(98, 30);
            this.lblTutorial.TabIndex = 1;
            this.lblTutorial.Text = "떨어지는 문자열을\r\n빠르게 입력하자!";
            this.lblTutorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("함초롬돋움", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 150);
            this.label8.TabIndex = 0;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // grpMain
            // 
            this.grpMain.BackColor = System.Drawing.Color.Snow;
            this.grpMain.Controls.Add(this.wBugImg3);
            this.grpMain.Controls.Add(this.wBugImg2);
            this.grpMain.Controls.Add(this.wBugImg1);
            this.grpMain.Controls.Add(this.bBugImg);
            this.grpMain.Controls.Add(this.tumblerImg);
            this.grpMain.Controls.Add(this.coffeeImg);
            this.grpMain.Controls.Add(this.keyboardImg);
            this.grpMain.Controls.Add(this.languageImg);
            this.grpMain.Controls.Add(this.laptopImg);
            this.grpMain.Controls.Add(this.lblWords);
            this.grpMain.Location = new System.Drawing.Point(22, 60);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(445, 629);
            this.grpMain.TabIndex = 5;
            this.grpMain.TabStop = false;
            // 
            // wBugImg3
            // 
            this.wBugImg3.Image = global::코딩타자연습게임.Properties.Resources.bug_white;
            this.wBugImg3.Location = new System.Drawing.Point(289, 592);
            this.wBugImg3.Name = "wBugImg3";
            this.wBugImg3.Size = new System.Drawing.Size(36, 38);
            this.wBugImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wBugImg3.TabIndex = 23;
            this.wBugImg3.TabStop = false;
            // 
            // wBugImg2
            // 
            this.wBugImg2.Image = global::코딩타자연습게임.Properties.Resources.bug_white;
            this.wBugImg2.Location = new System.Drawing.Point(248, 592);
            this.wBugImg2.Name = "wBugImg2";
            this.wBugImg2.Size = new System.Drawing.Size(36, 38);
            this.wBugImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wBugImg2.TabIndex = 22;
            this.wBugImg2.TabStop = false;
            // 
            // wBugImg1
            // 
            this.wBugImg1.Image = global::코딩타자연습게임.Properties.Resources.bug_white;
            this.wBugImg1.Location = new System.Drawing.Point(208, 592);
            this.wBugImg1.Name = "wBugImg1";
            this.wBugImg1.Size = new System.Drawing.Size(36, 38);
            this.wBugImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wBugImg1.TabIndex = 21;
            this.wBugImg1.TabStop = false;
            // 
            // bBugImg
            // 
            this.bBugImg.Image = global::코딩타자연습게임.Properties.Resources.bug_black;
            this.bBugImg.Location = new System.Drawing.Point(101, 221);
            this.bBugImg.Name = "bBugImg";
            this.bBugImg.Size = new System.Drawing.Size(53, 54);
            this.bBugImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bBugImg.TabIndex = 20;
            this.bBugImg.TabStop = false;
            // 
            // tumblerImg
            // 
            this.tumblerImg.Image = global::코딩타자연습게임.Properties.Resources.tumbler;
            this.tumblerImg.Location = new System.Drawing.Point(158, 574);
            this.tumblerImg.Name = "tumblerImg";
            this.tumblerImg.Size = new System.Drawing.Size(43, 51);
            this.tumblerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tumblerImg.TabIndex = 19;
            this.tumblerImg.TabStop = false;
            // 
            // coffeeImg
            // 
            this.coffeeImg.Image = global::코딩타자연습게임.Properties.Resources.iced_coffee;
            this.coffeeImg.Location = new System.Drawing.Point(124, 534);
            this.coffeeImg.Name = "coffeeImg";
            this.coffeeImg.Size = new System.Drawing.Size(33, 73);
            this.coffeeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coffeeImg.TabIndex = 18;
            this.coffeeImg.TabStop = false;
            // 
            // keyboardImg
            // 
            this.keyboardImg.Image = global::코딩타자연습게임.Properties.Resources.keyboard;
            this.keyboardImg.Location = new System.Drawing.Point(228, 423);
            this.keyboardImg.Name = "keyboardImg";
            this.keyboardImg.Size = new System.Drawing.Size(126, 76);
            this.keyboardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.keyboardImg.TabIndex = 17;
            this.keyboardImg.TabStop = false;
            // 
            // languageImg
            // 
            this.languageImg.Image = global::코딩타자연습게임.Properties.Resources.coding_language;
            this.languageImg.Location = new System.Drawing.Point(241, 453);
            this.languageImg.Name = "languageImg";
            this.languageImg.Size = new System.Drawing.Size(204, 183);
            this.languageImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.languageImg.TabIndex = 16;
            this.languageImg.TabStop = false;
            // 
            // laptopImg
            // 
            this.laptopImg.Image = global::코딩타자연습게임.Properties.Resources.programming;
            this.laptopImg.Location = new System.Drawing.Point(6, 537);
            this.laptopImg.Name = "laptopImg";
            this.laptopImg.Size = new System.Drawing.Size(117, 99);
            this.laptopImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.laptopImg.TabIndex = 15;
            this.laptopImg.TabStop = false;
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("함초롬돋움", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWords.Location = new System.Drawing.Point(190, 45);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(0, 18);
            this.lblWords.TabIndex = 14;
            // 
            // txtBoxTyping
            // 
            this.txtBoxTyping.BackColor = System.Drawing.Color.Snow;
            this.txtBoxTyping.Font = new System.Drawing.Font("함초롬돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxTyping.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxTyping.Location = new System.Drawing.Point(50, 706);
            this.txtBoxTyping.Name = "txtBoxTyping";
            this.txtBoxTyping.Size = new System.Drawing.Size(383, 32);
            this.txtBoxTyping.TabIndex = 13;
            this.txtBoxTyping.Text = "Enter키를 누르면 입력됩니다.";
            this.txtBoxTyping.TextChanged += new System.EventHandler(this.txtBoxTyping_TextChanged);
            this.txtBoxTyping.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxTyping_KeyDown);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MintCream;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(487, 698);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 45);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.MintCream;
            this.btnEnd.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEnd.Location = new System.Drawing.Point(587, 698);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(80, 45);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Text = "종료";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // pgBarBattery
            // 
            this.pgBarBattery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgBarBattery.Location = new System.Drawing.Point(57, 19);
            this.pgBarBattery.Maximum = 5;
            this.pgBarBattery.Name = "pgBarBattery";
            this.pgBarBattery.Size = new System.Drawing.Size(134, 20);
            this.pgBarBattery.TabIndex = 0;
            this.pgBarBattery.Value = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Orbit-B BT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Snow;
            this.lblLogo.Location = new System.Drawing.Point(484, 14);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(182, 31);
            this.lblLogo.TabIndex = 12;
            this.lblLogo.Text = "SpeedyCoding";
            // 
            // tmrWords
            // 
            this.tmrWords.Interval = 1000;
            this.tmrWords.Tick += new System.EventHandler(this.tmrWords_Tick);
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattery.Font = new System.Drawing.Font("함초롬돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBattery.ForeColor = System.Drawing.Color.Snow;
            this.lblBattery.Location = new System.Drawing.Point(203, 18);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(2, 19);
            this.lblBattery.TabIndex = 20;
            this.lblBattery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batteryImage
            // 
            this.batteryImage.Image = global::코딩타자연습게임.Properties.Resources.img1;
            this.batteryImage.Location = new System.Drawing.Point(21, 16);
            this.batteryImage.Name = "batteryImage";
            this.batteryImage.Size = new System.Drawing.Size(27, 25);
            this.batteryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batteryImage.TabIndex = 21;
            this.batteryImage.TabStop = false;
            // 
            // grpbBug
            // 
            this.grpbBug.Controls.Add(this.radioButton2);
            this.grpbBug.Controls.Add(this.radioButton3);
            this.grpbBug.Controls.Add(this.rbtnbOff);
            this.grpbBug.Controls.Add(this.rbtnbOn);
            this.grpbBug.Font = new System.Drawing.Font("함초롬돋움", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpbBug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grpbBug.Location = new System.Drawing.Point(579, 276);
            this.grpbBug.Name = "grpbBug";
            this.grpbBug.Size = new System.Drawing.Size(86, 100);
            this.grpbBug.TabIndex = 24;
            this.grpbBug.TabStop = false;
            this.grpbBug.Text = "Obstacle";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(-82, 58);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 25);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "- Bug";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(-83, 33);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 25);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "+ Bug";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbtnbOff
            // 
            this.rbtnbOff.AutoSize = true;
            this.rbtnbOff.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnbOff.Location = new System.Drawing.Point(21, 58);
            this.rbtnbOff.Name = "rbtnbOff";
            this.rbtnbOff.Size = new System.Drawing.Size(49, 25);
            this.rbtnbOff.TabIndex = 1;
            this.rbtnbOff.TabStop = true;
            this.rbtnbOff.Text = "Off";
            this.rbtnbOff.UseVisualStyleBackColor = true;
            this.rbtnbOff.CheckedChanged += new System.EventHandler(this.rbtnbOff_CheckedChanged);
            // 
            // rbtnbOn
            // 
            this.rbtnbOn.AutoSize = true;
            this.rbtnbOn.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnbOn.Location = new System.Drawing.Point(21, 33);
            this.rbtnbOn.Name = "rbtnbOn";
            this.rbtnbOn.Size = new System.Drawing.Size(49, 25);
            this.rbtnbOn.TabIndex = 0;
            this.rbtnbOn.TabStop = true;
            this.rbtnbOn.Text = "On";
            this.rbtnbOn.UseVisualStyleBackColor = true;
            this.rbtnbOn.CheckedChanged += new System.EventHandler(this.rbtnbOn_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(680, 758);
            this.Controls.Add(this.grpbBug);
            this.Controls.Add(this.batteryImage);
            this.Controls.Add(this.txtBoxTyping);
            this.Controls.Add(this.lblBattery);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pgBarBattery);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpTutorial);
            this.Controls.Add(this.grpSpeed);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.grpScore);
            this.Name = "Form";
            this.Text = "SpeedyCoding";
            this.Load += new System.EventHandler(this.Form_Load);
            this.grpScore.ResumeLayout(false);
            this.grpScore.PerformLayout();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpSpeed.ResumeLayout(false);
            this.grpSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkBarSpeed)).EndInit();
            this.grpTutorial.ResumeLayout(false);
            this.grpTutorial.PerformLayout();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wBugImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wBugImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wBugImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBugImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumblerImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteryImage)).EndInit();
            this.grpbBug.ResumeLayout(false);
            this.grpbBug.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpScore;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.GroupBox grpSpeed;
        private System.Windows.Forms.GroupBox grpTutorial;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ProgressBar pgBarBattery;
        private System.Windows.Forms.TrackBar tkBarSpeed;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Timer tmrWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTyping;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.PictureBox batteryImage;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.PictureBox laptopImg;
        private System.Windows.Forms.PictureBox languageImg;
        private System.Windows.Forms.PictureBox keyboardImg;
        private System.Windows.Forms.PictureBox coffeeImg;
        private System.Windows.Forms.PictureBox tumblerImg;
        private System.Windows.Forms.PictureBox wBugImg1;
        private System.Windows.Forms.PictureBox bBugImg;
        private System.Windows.Forms.PictureBox wBugImg2;
        private System.Windows.Forms.PictureBox wBugImg3;
        private System.Windows.Forms.GroupBox grpbBug;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbtnbOff;
        private System.Windows.Forms.RadioButton rbtnbOn;
        private System.Windows.Forms.RadioButton rbtnHard;
        private System.Windows.Forms.RadioButton rbtnEasy;
    }
}

