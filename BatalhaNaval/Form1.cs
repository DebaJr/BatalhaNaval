using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Web;

namespace BatalhaNaval
{
    public partial class Form1 : Form
    {
        char[] letterPositions = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
        List<Button> enemyShipPositions = new List<Button>();
        List<Button> playerShipPositions = new List<Button>();
        List<Button> playerBoard = new List<Button>();
        List<Button> enemyBoard = new List<Button>();

        bool playerChoosingPositions = false;

        int playerScore = 0;
        int cpuScore = 0;

        int tamanhoTabuleiro = 10;

        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();

            CreatePlayerBoard(playerBoard, 40, 50);
            CreateEnemyBoard(enemyBoard, 400, 50);

            ResetGame();
        }

        private void ResetGame()
        {
            enemyShipPositions.Clear();
            playerShipPositions.Clear();

            foreach (Button btn in playerBoard)
            {
                btn.Enabled = true;
                btn.Tag = null;
                btn.BackColor = Color.White;
                btn.Text = btn.Name.ToUpper();
            }

            foreach (Button btn in enemyBoard)
            {
                btn.Enabled = false;
                btn.BackColor = Color.White;
                btn.Text = btn.Name.ToUpper();
            }

            enemyPositionPicker();
            txtPlayerPhase.Text = "Escolha suas posições (" + (10 - playerShipPositions.Count) + ")!";
            playerChoosingPositions = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playerBoard_Click(object sender, EventArgs e)
        {
            if (playerChoosingPositions && playerShipPositions.Count < tamanhoTabuleiro)
            {
                Button clickedButton = (Button)sender;

                playerShipPositions.Add(clickedButton);
                clickedButton.BackColor = Color.Yellow;
                clickedButton.Enabled = false;

                if (playerShipPositions.Count < tamanhoTabuleiro)
                {
                    txtPlayerPhase.Text = "Escolha suas posições (" + (10 - playerShipPositions.Count) + ")!";
                }
                else
                {
                    txtPlayerPhase.Text = "Escolha uma posição no tabuleiro inimigo!";
                    foreach (Button btn in playerBoard)
                    {
                        btn.Enabled = false;
                    }

                    foreach (Button btn in enemyBoard)
                    {
                        btn.Enabled = true;
                    }
                    playerChoosingPositions = false;
                }
            }
        }

        private void enemyBoard_Click(object sender, EventArgs e)
        {
            if (!playerChoosingPositions)
            {
                Button clickedButton = (Button)sender;

                if (enemyShipPositions.Contains(clickedButton))
                {
                    clickedButton.BackColor = Color.Red;
                    clickedButton.Enabled = false;
                    enemyShipPositions.Remove(clickedButton);
                    MessageBox.Show("Acertou!");
                    if (enemyShipPositions.Count < 1)
                    {
                        MessageBox.Show("Parabéns, você venceu!");
                        playerScore++;
                        txtPlayerScore.Text = playerScore.ToString();
                        ResetGame();
                    }
                    else
                    {
                        EnemyAttack();
                    }
                }
                else
                {
                    clickedButton.BackColor = (Color)Color.DarkBlue;
                    clickedButton.Enabled = false;
                    MessageBox.Show("Água!");
                    EnemyAttack();
                }


            }
        }

        private void EnemyAttack()
        {
            int index = randGen.Next(playerBoard.Count);

            while (playerBoard[index].Tag == "shot")
            {
                index = randGen.Next(playerBoard.Count);
            }

            MessageBox.Show("O ataque da CPU vai em: " + playerBoard[index].Text);
            if (playerShipPositions.Contains(playerBoard[index]))
            {
                playerBoard[index].BackColor = Color.Red;
                playerBoard[index].Tag = "shot";
                playerShipPositions.Remove(playerBoard[index]);
                MessageBox.Show("Te acertei!");
                if (playerShipPositions.Count < 1)
                {
                    MessageBox.Show("Você perdeu...");
                    cpuScore++;
                    txtCPUScore.Text = cpuScore.ToString();
                    ResetGame();
                }

            }
            else
            {
                playerBoard[index].BackColor = Color.DarkBlue;
                playerBoard[index].Tag = "shot";
                MessageBox.Show("Água... sua vez.");
            }
        }

        private void CreatePlayerBoard(List<Button> boardToCreate, int startPositionX, int startPositionY)
        {
            for (int i = 0; i < tamanhoTabuleiro; i++)
            {
                for (int j = 0; j < tamanhoTabuleiro; j++)
                {
                    Button newButton = new Button();
                    this.Controls.Add(newButton);
                    newButton.Name = letterPositions[i].ToString() + (j + 1).ToString();
                    newButton.Text = newButton.Name.ToUpper();
                    newButton.Location = new Point(i * 35 + startPositionX, j * 35 + startPositionY);
                    newButton.Size = new Size(35, 35);
                    newButton.Click += playerBoard_Click;
                    boardToCreate.Add(newButton);
                }
            }
        }

        private void CreateEnemyBoard(List<Button> boardToCreate, int startPositionX, int startPositionY)
        {
            for (int i = 0; i < tamanhoTabuleiro; i++)
            {
                for (int j = 0; j < tamanhoTabuleiro; j++)
                {
                    Button newButton = new Button();
                    this.Controls.Add(newButton);
                    newButton.Name = letterPositions[i].ToString() + (j + 1).ToString();
                    newButton.Text = newButton.Name.ToUpper();
                    newButton.Location = new Point(i * 35 + startPositionX, j * 35 + startPositionY);
                    newButton.Size = new Size(35, 35);
                    newButton.Click += enemyBoard_Click;
                    boardToCreate.Add(newButton);
                }
            }
        }

        private void enemyPositionPicker()
        {
            while (enemyShipPositions.Count < tamanhoTabuleiro)
            {
                int index = randGen.Next(enemyBoard.Count);
                if (!enemyShipPositions.Contains(enemyBoard[index]))
                {
                    enemyShipPositions.Add(enemyBoard[index]);
                    Debug.WriteLine(enemyBoard[index].Text);
                }
            }

        }
    }
}
