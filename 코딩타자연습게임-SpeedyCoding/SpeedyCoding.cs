using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 코딩타자연습게임
{
    public partial class Form : System.Windows.Forms.Form
    {
        Random rnd = new Random();
        Stopwatch sw = new Stopwatch();

        int battery = 100;
        int errorCount = 0;

        string eMode, hMode;
        string[] eMList, hMList;
        string eMWord, hMWord;

        int fCorrect = 0;
        int fWrong = 0;
        int fTotal = 0;

        double correctCharCount = 0;
        double avgSpeed = 0;
        
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Size = new Size(700, 800);  //게임 전체 영역 설정
            lblWords.Visible = false;  //폼이 로드 되었을 때에는 글자가 보이지 않음 
            rbtnbOn.Checked = true;  //화면 중간 검정 버그 이미지 : 기본 장애물로 설정
            rbtnEasy.Checked = true;  //Mode 초기값 : Easy
            tkBarSpeed.Value = 3;  //Speed 초기값 : 3
            pgBarBattery.Value = 5;  //총 5번의 오타 기회
            lblBattery.Text = $"{battery}%";

            //단어 파일 불러오기
            //Mode : Easy
            eMode = Properties.Resources.easywords_C_;
            eMList = eMode.Split('\n');

            //Mode : Hard
            hMode = Properties.Resources.hardwords_C_;
            hMList = hMode.Split('\n');
        }

        private void rbtnbOn_CheckedChanged(object sender, EventArgs e)
        {
            bBugImg.Visible = true;
        }

        private void rbtnbOff_CheckedChanged(object sender, EventArgs e)
        {
            bBugImg.Visible = false;
        }

        //단어 생성 함수
        private void makeWords()
        {
            if (rbtnEasy.Checked)
            {
                //Mode : Easy - 랜덤으로 단어 선택
                int eMIndex = rnd.Next(0, eMList.Length);
                eMWord = eMList[eMIndex];

                lblWords.Text = eMWord.ToString();

                //단어의 x좌표가 부모 컨테이너인 grpMain 영역 밖을 넘어가지 않게 설정
                lblWords.Left = rnd.Next(grpMain.Width - lblWords.Width);
                //grpMain 상단에서부터 단어의 y좌표가 시작되게 함.
                lblWords.Top = grpMain.Top;
            }
            else
            {
                //Mode : Hard - 랜덤으로 단어 선택
                int hMIndex = rnd.Next(0, hMList.Length);
                hMWord = hMList[hMIndex];

                lblWords.Text = hMWord.ToString();

                int maxWidth = Math.Max(grpMain.Width - lblWords.Width, 0);  //둘 중 더 큰 값을 변수에 저장
                lblWords.Left = rnd.Next(maxWidth);
                lblWords.Top = grpMain.Top;
            }
            
        }

        //단어를 담은 label 컨트롤의 높이 만큼 단어를 계속 떨어뜨림
        //장애물 충돌 시 Total Score에 반영, 새 단어 생성
        private void tmrWords_Tick(object sender, EventArgs e)
        {
            lblWords.Visible = true;
            lblWords.Top += lblWords.Height;

            if (rbtnbOn.Checked)
            {
                if (CheckCollision(bBugImg))
                {
                    CalCollision();
                }
                else
                {
                    CollisionOdds();
                }
            }
            else
            {
                CollisionOdds();
            }
        }

        private bool CheckCollision(Control obstacle)
        {
            int bBLeft = bBugImg.Left;
            int bBRight = bBugImg.Right;
            int bBTop = bBugImg.Top;

            int lblWLeft = lblWords.Left;
            int lblWRight = lblWords.Right;
            int lblWBottom = lblWords.Bottom;

            //lblWords와 bBugImage
            return (bBRight >= lblWLeft && bBLeft <= lblWRight && bBTop <= lblWBottom);
        }

        private void CollisionOdds()
        {
            //단어와 장애물 간 충돌 계산
            int kLeft = keyboardImg.Left;
            int kRight = keyboardImg.Right;
            int kTop = keyboardImg.Top;

            int ltTop = laptopImg.Top;
            int lgTop = languageImg.Top;
            int cTop = coffeeImg.Top;
            int tTop = tumblerImg.Top;

            int lblWLeft = lblWords.Left;
            int lblWRight = lblWords.Right;
            int lblWBottom = lblWords.Bottom;
           
            //grpMain 하단의 장애물들
            if (kRight >= lblWLeft && kLeft <= lblWRight && kTop <= lblWBottom
                || lgTop <= lblWBottom || ltTop <= lblWords.Bottom
                || cTop <= lblWords.Bottom || tTop <= lblWords.Bottom)
            {
                CalCollision();
            }
        }

        private void CalCollision()
        {
            fWrong += 1;
            lblWrong.Text = fWrong.ToString();
            fTotal -= 10;
            lblTotal.Text = fTotal.ToString();
            lblWords.Text = "";
            makeWords();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //일시 정지 버튼을 누른 상태
            if (tmrWords.Enabled)  
            {
                tmrWords.Stop();

                //연습 시간 기록 일시 정지
                sw.Stop();
              
                txtBoxTyping.Text = "";
                this.ActiveControl = txtBoxTyping;
                txtBoxTyping.Focus();
                btnStart.Text = "시작";

                CalRecords();
                lblWords.Visible = false;
            }
            //시작 버튼을 누른 상태
            else
            {
                txtBoxTyping.Text = "";
                this.ActiveControl = txtBoxTyping;
                txtBoxTyping.Focus();

                makeWords();
                tmrWords.Start();

                //연습 시간 기록 시작
                sw.Start();

                //게임이 시작되면 시작 버튼이 일시 정지 버튼으로 바뀜
                btnStart.Text = "일시 정지";
            }
        }

        private void CalRecords()
        {
            //연습 시간 출력
            sw.Stop();
            TimeSpan elapsed = sw.Elapsed;  //시간 기록을 TimeSpan(시간 간격)으로 얻음
            double minutes = elapsed.Minutes;
            double seconds = elapsed.Seconds;
            lblTime.Visible = true;
            lblTime.Text = minutes + "분 " + seconds + "초";

            //평균 타수 출력
            double TotalMinutes = elapsed.TotalMinutes;
            if (TotalMinutes > 0)
            {
                avgSpeed = correctCharCount / TotalMinutes;
                lblAvg.Visible = true;
                lblAvg.Text = $"{avgSpeed:F2} 타";
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (tmrWords.Enabled)
            {
                tmrWords.Stop();
                btnEnd.Text = "초기화";
                txtBoxTyping.Text = "";
                lblWords.Visible = false;

                CalRecords();
            }
            else
            {
                //전체 값 초기화
                txtBoxTyping.Text = "";
                this.ActiveControl = txtBoxTyping;
                txtBoxTyping.Focus();
                lblWords.Visible = false;

                fCorrect = 0;
                fWrong = 0;
                fTotal = 0;
                correctCharCount = 0;
                avgSpeed = 0;
                lblCorrect.Text = "0";
                lblWrong.Text = "0";
                lblTotal.Text = "0";
                lblTime.Visible = false;
                lblAvg.Visible = false;

                pgBarBattery.Value = 5;
                errorCount = 0;
                battery = 100;
                lblBattery.Text = $"{battery}%";

                sw.Reset();

                btnStart.Text = "시작";
                //초기화 버튼을 누르면 해당 버튼 텍스트가 종료 버튼으로 바뀜
                btnEnd.Text = "종료";
            }
        }

        //txtBoxTyping에 이벤트 발생 시
        private void txtBoxTyping_TextChanged(object sender, EventArgs e)
        {
            txtBoxTyping.ForeColor = Color.Black;
        }

        private void txtBoxTyping_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // 떨어지던 문자열과 입력 문자열 비교 (대소문자 구분)
                string typedWord = txtBoxTyping.Text;
                string displayedWord = lblWords.Text.Trim();  // 표시된 단어에서 앞뒤 공백 제거

                if (string.Compare(typedWord, displayedWord) == 0)
                {
                    fCorrect += 1;
                    lblCorrect.Text = fCorrect.ToString();
                    fTotal += 10;
                    lblTotal.Text = fTotal.ToString();

                    lblWords.Text = "";  //두 문자열이 일치할 때 랜덤 단어 초기화
                    makeWords();  //새로운 단어 생성

                    //옳게 입력한 단어에 한해서 타수 기록
                    correctCharCount += typedWord.Length;
                }
                else
                {
                    fWrong += 1;
                    lblWrong.Text = fWrong.ToString();
                    fTotal -= 10;
                    lblTotal.Text = fTotal.ToString();
                }
                txtBoxTyping.Text = "";
            }
            txtBoxTyping.Focus() ;
        }

        //좌상단 프로그레스바를 UI로 활용, 5번의 오타 기회 제공
        private void lblWrong_TextChanged(object sender, EventArgs e)
        {
            errorCount++;
            //틀린 개수가 쌓일 때마다 좌상단 프로그레스바의 Value를 5에서부터 1씩 감소
            if (errorCount <= 4)
            {
                if (pgBarBattery.Value > 0)
                {
                    pgBarBattery.Value -= 1;
                }
                else
                {
                    pgBarBattery.Value = 0;
                    tmrWords.Stop();
                    lblWords.Visible = false;
                }

                if (battery >= 20)
                {
                    battery -= 20;
                }
                lblBattery.Text = $"{battery}%";
            }
            else
            {
                lblBattery.Text = "Game Over!!";
                pgBarBattery.Value = 0;
                tmrWords.Stop();
                lblWords.Visible = false;
                CalRecords();
                btnEnd.Text = "초기화";
            }
        }

        //속도 설정
        private void tkBarSpeed_Scroll(object sender, EventArgs e)
        {
            if (rbtnEasy.Checked)
            {
                if (tkBarSpeed.Value == 1)
                {
                    tmrWords.Interval = 1000;
                }
                else if (tkBarSpeed.Value == 2)
                {
                    tmrWords.Interval = 800;
                }
                else if (tkBarSpeed.Value == 3)
                {
                    tmrWords.Interval = 600;
                }
                else if (tkBarSpeed.Value == 4)
                {
                    tmrWords.Interval = 400;
                }
                else if (tkBarSpeed.Value == 5)
                {
                    tmrWords.Interval = 200;
                }
            }
            else
            {
                if (tkBarSpeed.Value == 1)
                {
                    tmrWords.Interval = 1000;
                }
                else if (tkBarSpeed.Value == 2)
                {
                    tmrWords.Interval = 800;
                }
                else if (tkBarSpeed.Value == 3)
                {
                    tmrWords.Interval = 600;
                }
                else if (tkBarSpeed.Value == 4)
                {
                    tmrWords.Interval = 400;
                }
                else if (tkBarSpeed.Value == 5)
                {
                    tmrWords.Interval = 200;
                }
            }
        }
    }
}
