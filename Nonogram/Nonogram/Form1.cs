using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 21; i++)
            {
                comboBoxHeigth.Items.Add(i);
                comboBoxWidth.Items.Add(i);
            }
            defaultColor = buttonStart.BackColor;
            currentColored = 0;
            started = false;
            generated = false;
            buttonSolve.Enabled = false;
        }
        public struct tuple
        {
            public int i, j;
            public tuple(int a, int b)
            {
                i = a;
                j = b;
            }

        }


        int nonogramHeight, nonogramWidth, coloredSum, currentColored;
        Button[,] buttons;
        List<List<int>> topNumbers = new List<List<int>>();
        List<List<int>> sideNumbers = new List<List<int>>();
        List<int[,]> solutions;
        int[,] finalSolution;
        List<tuple> tried;
        Color defaultColor;
        bool started, generated, changed;

        List<int> combination = new List<int>();
        int[] tempLine;
        int correctLines = 0;
        Stopwatch sw = new Stopwatch();


        //Metode provjere ispravnosti
        private bool checkNonogram()
        {
            for (int i = 0; i < nonogramHeight; i++)
            {
                List<int> temp = new List<int>();
                int counter = 0;
                for (int j = 0; j < nonogramWidth; j++)
                {
                    if (buttons[i, j].BackColor == Color.Black)
                    {
                        ++counter;
                    }
                    else if (counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                    if (j == nonogramWidth - 1 && counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                }
                if (temp.Count == 0)
                {
                    temp.Add(0);
                }
                if (!compareLists(temp, sideNumbers[i]))
                {
                    return false;
                }
            }
            for (int i = 0; i < nonogramWidth; i++)
            {
                List<int> temp = new List<int>();
                int counter = 0;
                for (int j = 0; j < nonogramHeight; j++)
                {
                    if (buttons[j, i].BackColor == Color.Black)
                    {
                        ++counter;
                    }
                    else if (counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                    if (j == nonogramHeight - 1 && counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                }
                if (temp.Count == 0)
                {
                    temp.Add(0);
                }
                if (!compareLists(temp, topNumbers[i]))
                {
                    return false;
                }
            }
            return true;
        }
        private bool checkSolution()
        {
            for (int i = 0; i < nonogramHeight; i++)
            {
                List<int> temp = new List<int>();
                int counter = 0;
                for (int j = 0; j < nonogramWidth; j++)
                {
                    if (solutions[solutions.Count - 1][i, j] == 1)
                    {
                        ++counter;
                    }
                    else if (solutions[solutions.Count - 1][i, j] == 0 && counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                    if (j == nonogramWidth - 1 && counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                }
                if (temp.Count == 0)
                {
                    temp.Add(0);
                }
                if (!compareLists(temp, sideNumbers[i]))
                {
                    return false;
                }
            }
            for (int i = 0; i < nonogramWidth; i++)
            {
                List<int> temp = new List<int>();
                int counter = 0;
                for (int j = 0; j < nonogramHeight; j++)
                {
                    if (solutions[solutions.Count - 1][j, i] == 1)
                    {
                        ++counter;
                    }
                    else if (solutions[solutions.Count - 1][j, i] == 0 && counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                    if (j == nonogramHeight - 1 && counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                }
                if (temp.Count == 0)
                {
                    temp.Add(0);
                }
                if (!compareLists(temp, topNumbers[i]))
                {
                    return false;
                }
            }
            return true;
        }


        //Metode generiranja linija
        private void combinations(int start, int k, int s, int line, bool row)
        {
            if (k == 0)
            {
                if (row)
                {
                    int[] temp = generateLine(combination, sideNumbers[line], nonogramWidth);
                    if (checkLineViability(temp, line, nonogramWidth, true))
                    {
                        for (int i = 0; i < nonogramWidth; ++i)
                        {
                            tempLine[i] += temp[i];
                        }
                        ++correctLines;
                    }
                }
                else
                {
                    int[] temp = generateLine(combination, topNumbers[line], nonogramHeight);
                    if (checkLineViability(temp, line, nonogramHeight, false))
                    {
                        for (int i = 0; i < nonogramHeight; ++i)
                        {
                            tempLine[i] += temp[i];
                        }
                        ++correctLines;
                    }
                }
                return;
            }
            for (int i = start; i <= s - k; ++i)
            {
                combination.Add(i + 1);
                combinations(i + 1, k - 1, s, line, row);
                combination.RemoveAt(combination.Count - 1);
            }
        }
        private int[] generateLine(List<int> combination, List<int> line, int n)
        {
            int[] temp = Enumerable.Repeat(1, n).ToArray();
            List<int> tempLine = new List<int>(line);
            List<int> tempCombination = new List<int>(combination);
            int current = 0;
            for (int i = tempCombination.Count - 1; i > 0; --i)
            {
                tempCombination[i] -= tempCombination[i - 1];
            }
            tempCombination[0]--;
            foreach (int i in tempCombination)
            {
                for (int j = 0; j < i; ++j)
                {
                    temp[current++] = 0;
                }
                current += tempLine[0];
                tempLine.RemoveAt(0);
            }
            while (current != n)
            {
                temp[current++] = 0;
            }
            return temp;
        }
        private bool checkLineViability(int[] array, int line, int n, bool row)
        {
            if (row)
            {
                int i = line;
                for (int j = 0; j < n; ++j)
                {
                    if (!(solutions[solutions.Count - 1][i, j] == 2 || array[j] == solutions[solutions.Count - 1][i, j]))
                    {
                        return false;
                    }
                }
            }
            else
            {
                int j = line;
                for (int i = 0; i < n; ++i)
                {
                    if (!(solutions[solutions.Count - 1][i, j] == 2 || array[i] == solutions[solutions.Count - 1][i, j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void solveLine(int line, bool row)
        {
            if (row)
            {
                int i = line;
                for (int j = 0; j < nonogramWidth; ++j)
                {
                    if (tempLine[j] == 0 && solutions[solutions.Count - 1][i, j] != 0)
                    {
                        solutions[solutions.Count - 1][i, j] = 0;
                        changed = true;
                    }
                    else if (tempLine[j] == correctLines && solutions[solutions.Count - 1][i, j] != 1)
                    {
                        solutions[solutions.Count - 1][i, j] = 1;
                        changed = true;
                    }
                }
            }
            else
            {
                int j = line;
                for (int i = 0; i < nonogramHeight; ++i)
                {
                    if (tempLine[i] == 0 && solutions[solutions.Count - 1][i, j] != 0)
                    {
                        solutions[solutions.Count - 1][i, j] = 0;
                        changed = true;
                    }
                    else if (tempLine[i] == correctLines && solutions[solutions.Count - 1][i, j] != 1)
                    {
                        solutions[solutions.Count - 1][i, j] = 1;
                        changed = true;
                    }
                }
            }

        }


        //Metode generiranja nonograma
        private void generateNumbers()
        {
            for (int i = 0; i < nonogramHeight; i++)
            {
                List<int> temp = new List<int>();
                int counter = 0;
                for (int j = 0; j < nonogramWidth; j++)
                {
                    if (buttons[i, j].BackColor == Color.Black)
                    {
                        ++counter;
                    }
                    else if (counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                    if (j == nonogramWidth - 1 && counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                }
                if (temp.Count == 0)
                {
                    temp.Add(0);
                }
                coloredSum += temp.Sum();
                sideNumbers.Add(temp);
            }
            for (int i = 0; i < nonogramWidth; i++)
            {
                List<int> temp = new List<int>();
                int counter = 0;
                for (int j = 0; j < nonogramHeight; j++)
                {
                    if (buttons[j, i].BackColor == Color.Black)
                    {
                        ++counter;
                    }
                    else if (counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                    if (j == nonogramHeight - 1 && counter != 0)
                    {
                        temp.Add(counter);
                        counter = 0;
                    }
                }
                if (temp.Count == 0)
                {
                    temp.Add(0);
                }
                topNumbers.Add(temp);
            }

            addTopNumbers();
            addSideNumbers();
        }
        private void addTopNumbers()
        {
            int Top = panelTop.Height - 16, Left = 5;
            for (int i = 0; i < nonogramWidth; i++)
            {
                int n = topNumbers[i].Count, j = 0;
                int[] temp = new int[n];
                foreach (int c in topNumbers[i])
                {
                    temp[n - j - 1] = c;
                    ++j;
                }
                for (j = 0; j < n; ++j)
                {
                    Label newLabel = new Label();
                    newLabel.Text = temp[j].ToString();
                    newLabel.Top = Top;
                    newLabel.Left = Left;
                    newLabel.Height = 20;
                    newLabel.Width = 20;
                    newLabel.TextAlign = ContentAlignment.MiddleCenter;
                    panelTop.Controls.Add(newLabel);
                    Top -= 22;
                }
                Top = panelTop.Height - 16;
                Left += 27;
            }
        }
        private void addSideNumbers()
        {
            int Left = panelSide.Width - 16, Top = 5;
            for (int i = 0; i < nonogramHeight; i++)
            {
                int n = sideNumbers[i].Count, j = 0;
                int[] temp = new int[n];
                foreach (int c in sideNumbers[i])
                {
                    temp[n - j - 1] = c;
                    ++j;
                }
                for (j = 0; j < n; ++j)
                {
                    Label newLabel = new Label();
                    newLabel.Text = temp[j].ToString();
                    newLabel.Top = Top;
                    newLabel.Left = Left;
                    newLabel.Height = 20;
                    newLabel.Width = 20;
                    newLabel.TextAlign = ContentAlignment.MiddleCenter;
                    panelSide.Controls.Add(newLabel);
                    Left -= 22;
                }
                Left = panelSide.Width - 16;
                Top += 27;
            }
        }
        private void createNonogram()
        {
            int Top = 2, Left = 2;
            for (int i = 0; i < nonogramHeight; i++)
            {
                for (int j = 0; j < nonogramWidth; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Top = Top;
                    buttons[i, j].Left = Left;
                    buttons[i, j].Height = 25;
                    buttons[i, j].Width = 25;
                    buttons[i, j].BackColor = defaultColor;
                    buttons[i, j].MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewPanelButton_MouseDown);
                    buttons[i, j].Font = new Font("Arial", 12, FontStyle.Bold);
                    buttons[i, j].Margin = new Padding(0, 0, 0, 0);
                    panelButtons.Controls.Add(buttons[i, j]);
                    Left += 27;
                }
                Top += 27;
                Left = 2;
            }
        }
        private void generateFeritNonogram()
        {
            coloredSum = 0;
            int[][] matrixTop = new int[16][];
            matrixTop[0] = new int[] { 18 };
            matrixTop[1] = new int[] { 5, 5 };
            matrixTop[2] = new int[] { 4, 8, 4 };
            matrixTop[3] = new int[] { 3, 10, 3 };
            matrixTop[4] = new int[] { 3, 10, 3 };
            matrixTop[5] = new int[] { 2, 4, 4, 2 };
            matrixTop[6] = new int[] { 2, 3, 5, 2 };
            matrixTop[7] = new int[] { 1, 3, 7, 1 };
            matrixTop[8] = new int[] { 1, 7, 3, 1 };
            matrixTop[9] = new int[] { 2, 5, 3, 2 };
            matrixTop[10] = new int[] { 2, 4, 4, 2 };
            matrixTop[11] = new int[] { 3, 10, 3 };
            matrixTop[12] = new int[] { 3, 10, 3 };
            matrixTop[13] = new int[] { 4, 8, 4 };
            matrixTop[14] = new int[] { 5, 5 };
            matrixTop[15] = new int[] { 18 };
            int[][] matrixSide = new int[18][];
            matrixSide[0] = new int[] { 16 };
            matrixSide[1] = new int[] { 7, 7 };
            matrixSide[2] = new int[] { 5, 2, 5 };
            matrixSide[3] = new int[] { 3, 6, 3 };
            matrixSide[4] = new int[] { 2, 10, 2 };
            matrixSide[5] = new int[] { 1, 5, 6, 1 };
            matrixSide[6] = new int[] { 1, 4, 6, 1 };
            matrixSide[7] = new int[] { 1, 3, 2, 3, 1 };
            matrixSide[8] = new int[] { 1, 3, 1, 3, 1 };
            matrixSide[9] = new int[] { 1, 3, 1, 3, 1 };
            matrixSide[10] = new int[] { 1, 3, 2, 3, 1 };
            matrixSide[11] = new int[] { 1, 6, 4, 1 };
            matrixSide[12] = new int[] { 1, 6, 5, 1 };
            matrixSide[13] = new int[] { 2, 10, 2 };
            matrixSide[14] = new int[] { 3, 6, 3 };
            matrixSide[15] = new int[] { 5, 2, 5 };
            matrixSide[16] = new int[] { 7, 7 };
            matrixSide[17] = new int[] { 16 };

            for (int i = 0; i < nonogramHeight; i++)
            {
                sideNumbers.Add(new List<int>(matrixSide[i]));
                coloredSum += matrixSide[i].Sum();
            }
            for (int i = 0; i < nonogramWidth; i++)
            {
                topNumbers.Add(new List<int>(matrixTop[i]));
            }
        }


        //Metode pritiska glavnih gumbova
        private void buttonFERIT_Click(object sender, EventArgs e)
        {
            nonogramHeight = 18;
            nonogramWidth = 16;
            buttons = new Button[nonogramHeight, nonogramWidth];
            generateFeritNonogram();
            createNonogram();
            addTopNumbers();
            addSideNumbers();
            comboBoxHeigth.Enabled = false;
            comboBoxWidth.Enabled = false;
            buttonStart.Enabled = false;
            buttonGrid.Enabled = false;
            buttonFERIT.Enabled = false;
            buttonSolve.Enabled = true;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!generated)
            {
                if (comboBoxHeigth.Text == "")
                {
                    nonogramHeight = 2;
                }
                else
                {
                    nonogramHeight = int.Parse(comboBoxHeigth.Text);
                }
                if (comboBoxWidth.Text == "")
                {
                    nonogramWidth = 2;
                }
                else
                {
                    nonogramWidth = int.Parse(comboBoxWidth.Text);
                }
                comboBoxHeigth.Enabled = false;
                comboBoxWidth.Enabled = false;
                buttonGrid.Enabled = false;
                buttonFERIT.Enabled = false;
                buttons = new Button[nonogramHeight, nonogramWidth];
                createNonogram();
                buttonStart.Text = "Generate";
                generated = true;
            }
            else
            {
                int counter = 0;
                foreach (Button f in panelButtons.Controls)
                {
                    int i, j;
                    i = (f.Top - 2) / 27;
                    j = (f.Left - 2) / 27;
                    buttons[i, j] = f;
                    ++counter;
                    if (counter == nonogramHeight * nonogramWidth)
                    {
                        break;
                    }
                }
                generateNumbers();
                started = true;
                for (int i = 0; i < nonogramHeight; ++i)
                {
                    for (int j = 0; j < nonogramWidth; ++j)
                    {
                        buttons[i, j].Text = "";
                        buttons[i, j].BackColor = defaultColor;
                    }
                }
                currentColored = 0;
                buttonStart.Enabled = false;
                buttonSolve.Enabled = true;
                panelButtons.Controls.Clear();
                createNonogram();
            }
        }
        private void buttonGrid_Click(object sender, EventArgs e)
        {
            if (comboBoxHeigth.Text == "")
            {
                nonogramHeight = 2;
            }
            else
            {
                nonogramHeight = int.Parse(comboBoxHeigth.Text);
            }
            if (comboBoxWidth.Text == "")
            {
                nonogramWidth = 2;
            }
            else
            {
                nonogramWidth = int.Parse(comboBoxWidth.Text);
            }
            int checkViability;
            coloredSum = 0;
            for (int i = 0; i < nonogramHeight; ++i)
            {
                Form2 dialog = new Form2();
                string temp = "";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    temp += dialog.textBox1.Text;
                }
                List<int> tempList = new List<int>();
                if (temp == "")
                {
                    tempList.Add(0);
                }
                else
                {
                    string[] t = temp.Split(' ');
                    foreach (string s in t)
                    {
                        tempList.Add(int.Parse(s));
                        coloredSum += int.Parse(s);
                    }
                }
                sideNumbers.Add(tempList);
                dialog.Dispose();
            }
            checkViability = coloredSum;
            for (int i = 0; i < nonogramWidth; ++i)
            {
                Form2 dialog = new Form2();
                string temp = "";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    temp += dialog.textBox1.Text;
                }
                List<int> tempList = new List<int>();
                if (temp == "")
                {
                    tempList.Add(0);
                }
                else
                {
                    string[] t = temp.Split(' ');
                    foreach (string s in t)
                    {
                        tempList.Add(int.Parse(s));
                        checkViability -= int.Parse(s);
                    }
                }
                topNumbers.Add(tempList);
                dialog.Dispose();
            }
            if (checkViability != 0)
            {
                MessageBox.Show("Nije jednak zbroj brojeva sa strane i gore.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonReset.PerformClick();
            }
            else
            {
                buttons = new Button[nonogramHeight, nonogramWidth];
                currentColored = 0;
                started = true;
                createNonogram();
                addSideNumbers();
                addTopNumbers();
                comboBoxHeigth.Enabled = false;
                comboBoxWidth.Enabled = false;
                buttonFERIT.Enabled = false;
                buttonGrid.Enabled = false;
                buttonStart.Enabled = false;
                buttonSolve.Enabled = true;
            }
        }
        private void buttonSolve_Click(object sender, EventArgs e)
        {
            solutions = new List<int[,]>();
            tried = new List<tuple>();
            changed = false;
            bool mistake = false, finalMistake = false;
            int countSolutions = 0;
            finalSolution = new int[nonogramHeight, nonogramWidth];
            Stopwatch timer = new Stopwatch();
            sw.Restart();

            do
            {
                solutions.Add(new int[nonogramHeight, nonogramWidth]);
                if (solutions.Count == 1)
                {
                    for (int i = 0; i < nonogramHeight; ++i)
                    {
                        for (int j = 0; j < nonogramWidth; ++j)
                        {
                            solutions[solutions.Count - 1][i, j] = 2;
                        }
                    }
                }
                else
                {
                    bool guessed = false;
                    for (int i = 0; i < nonogramHeight; ++i)
                    {
                        int unsolved = 0;
                        for (int j = 0; j < nonogramWidth; ++j)
                        {
                            solutions[solutions.Count - 1][i, j] = solutions[solutions.Count - 2][i, j];
                            if (solutions[solutions.Count - 1][i, j] == 2)
                            {
                                ++unsolved;
                            }
                        }

                        if (unsolved != 0 && !guessed)
                        {
                            correctLines = 0;
                            tempLine = new int[nonogramWidth];
                            int s = nonogramWidth;
                            foreach (int a in sideNumbers[i])
                            {
                                s -= a;
                            }
                            ++s;
                            combinations(0, sideNumbers[i].Count, s, i, true);
                            int max = 0;
                            for (int j = 1; j < nonogramWidth; ++j)
                            {
                                if (tempLine[j] > tempLine[max] && tempLine[j] != correctLines)
                                {
                                    max = j;
                                }
                            }
                            tried.Add(new tuple(i, max));
                            solutions[solutions.Count - 1][i, max] = 1;
                            guessed = true;
                        }
                    }
                }

                Label:
                do
                {
                    changed = false;
                    mistake = false;
                    for (int i = 0; i < nonogramHeight; ++i)
                    {
                        tempLine = new int[nonogramWidth];
                        correctLines = 0;
                        int s = nonogramWidth;
                        foreach (int a in sideNumbers[i])
                        {
                            s -= a;
                        }
                        ++s;
                        combinations(0, sideNumbers[i].Count, s, i, true);
                        if (correctLines != 0)
                        {
                            solveLine(i, true);
                        }
                        else
                        {
                            if (solutions.Count != 1)
                            {
                                solutions[solutions.Count - 2][tried[tried.Count - 1].i, tried[tried.Count - 1].j] = 0;
                                solutions.RemoveAt(solutions.Count - 1);
                                tried.RemoveAt(tried.Count - 1);
                            }
                            else
                            {
                                finalMistake = true;
                            }
                            mistake = true;
                            break;
                        }
                    }
                    if (finalMistake)
                    {
                        break;
                    }
                    for (int j = 0; j < nonogramWidth; ++j)
                    {
                        tempLine = new int[nonogramHeight];
                        correctLines = 0;
                        int s = nonogramHeight;
                        foreach (int a in topNumbers[j])
                        {
                            s -= a;
                        }
                        ++s;
                        combinations(0, topNumbers[j].Count, s, j, false);
                        if (correctLines != 0)
                        {
                            solveLine(j, false);
                        }
                        else
                        {
                            if (solutions.Count != 1)
                            {
                                solutions[solutions.Count - 2][tried[tried.Count - 1].i, tried[tried.Count - 1].j] = 0;
                                solutions.RemoveAt(solutions.Count - 1);
                                tried.RemoveAt(tried.Count - 1);
                            }
                            else
                            {
                                finalMistake = true;
                            }
                            mistake = true;
                            break;
                        }

                    }
                    if (finalMistake)
                    {
                        break;
                    }
                } while (changed || mistake);

                if (checkSolution())
                {
                    countSolutions++;
                    if (countSolutions == 1)
                    {
                        finalSolution = solutions[solutions.Count - 1];
                        timer.Restart();
                    }
                    if (solutions.Count == 1)
                    {
                        break;
                    }
                    else
                    {
                        solutions[solutions.Count - 2][tried[tried.Count - 1].i, tried[tried.Count - 1].j] = 0;
                        solutions.RemoveAt(solutions.Count - 1);
                        tried.RemoveAt(tried.Count - 1);
                        goto Label;
                    }
                }

                if (timer.Elapsed.Seconds >= 4)
                {
                    timer.Stop();
                    break;
                }
                if (finalMistake)
                {
                    break;
                }
                if (countSolutions >= 1000)
                {
                    break;
                }
            } while (true);

            sw.Stop();
            
            if (countSolutions == 1)
            {
                for (int i = 0; i < nonogramHeight; ++i)
                {
                    for (int j = 0; j < nonogramWidth; ++j)
                    {
                        if (finalSolution[i, j] == 1)
                        {
                            changeButtonState(i, j, true);
                        }
                        else if (finalSolution[i, j] == 0)
                        {
                            changeButtonState(i, j, false);
                        }
                    }
                }
            }
            else
            {
                if (countSolutions >= 1000)
                {
                    MessageBox.Show("Neispravan nonogram. Ukupno više od 1000 rješenja.", "Neispravan nonogram!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Neispravan nonogram. Ukupno " + countSolutions + " različitih rješenja.", "Neispravan nonogram!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            MessageBox.Show("Vrijeme izvršavanja algoritma: " + sw.ElapsedMilliseconds.ToString() + " ms.", "Nonogram riješen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }


        //Pomoćne metode
        private bool compareLists(List<int> first, List<int> second)
        {
            if (first.Count != second.Count)
            {
                return false;
            }
            for (int i = 0; i < first.Count; ++i)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }
            return true;
        }
        private void changeButtonState(int i, int j, bool state)
        {
            if (state)
            {
                if (buttons[i, j].BackColor != Color.Black)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].BackColor = Color.Black;
                    ++currentColored;
                    if (!changed)
                    {
                        changed = true;
                    }
                }
            }
            else if (buttons[i, j].Text != "X")
            {

                buttons[i, j].BackColor = defaultColor;
                buttons[i, j].Text = "X";
                if (!changed)
                {
                    changed = true;
                }
            }

        }
        private void NewPanelButton_MouseDown(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button)sender;
            if (e.Button == MouseButtons.Left)
            {
                currentButton.Text = "";
                if (currentButton.BackColor == Color.Black)
                {
                    currentButton.BackColor = defaultColor;
                    --currentColored;
                }
                else
                {
                    currentButton.BackColor = Color.Black;
                    ++currentColored;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (currentButton.BackColor == Color.Black)
                {
                    currentButton.BackColor = defaultColor;
                    --currentColored;
                }
                if (currentButton.Text == "X")
                {
                    currentButton.Text = "";
                }
                else
                {
                    currentButton.Text = "X";
                }
            }
            else
            {
                if (currentButton.BackColor == Color.Black)
                {
                    currentButton.BackColor = defaultColor;
                    --currentColored;
                }
                currentButton.Text = "";
            }
            if (started && currentColored == coloredSum)
            {
                if (checkNonogram())
                {
                    MessageBox.Show("Bravo!", "Točno riješen nonogram");
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
