using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using static System.Math;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static DnD_Fight_Assist.Enums;
using static DnD_Fight_Assist.Monsters;
using static DnD_Fight_Assist.Player;

namespace DnD_Fight_Assist
{
    public partial class Form1 : Form
    {
        List<Monster> monsters = Monsters.monsters;
        List<Character> characters = Player.characters;
        Monster monster;
        TextBox MonName, Type, AC, HP, Str, Dex, Con, Int, Wis, Cha, Resist, Vuln, Immun;
        Label AtkRange, AtkTH, AtkDice, AtkMod, AtkType;
        Label SplRange, SplTH, SplDice, SplMod, SplType;
        int timer, th, dice, nodice, mod, DC, save, adv;
        types type;
        Random rnd;

        Character player;
        ComboBox Attacks, Spells;



        public Form1()
        {
            InitializeComponent();
            //textBoxDmgRoll.Text = DefaultFont.ToString() + DefaultFont.Height.ToString();
        }
        private void buttonMonsterSelect_Click(object sender, EventArgs e)
        {
            monster = monsters
                .Where(x => x.Name.ToLower().Equals(comboBoxMonsters.SelectedItem.ToString().ToLower()))
                .FirstOrDefault();
            setUpPanel2();
            if (monster == null)
            {
                customMonster();
            }
            else
            {
                setUpMonster();
            }
            //textBoxAtkRoll.Text = comboBoxMonsters.SelectedItem.ToString();
        }
        private void buttonPlayerSelect_Click(object sender, EventArgs e)
        {
            player = characters
                .Where(x => x.Name.ToLower().Equals(comboBoxPlayers.SelectedItem.ToString().ToLower()))
                .FirstOrDefault();
            if (player == null)
            {
                //customPlayer();
            }
            else
            {
                setUpPlayer();
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMonsters.Items.Add("Custom Monster");
            foreach (Monster m in monsters)
            {
                comboBoxMonsters.Items.Add(m.Name);
            }
            comboBoxMonsters.SelectedItem = "Custom Monster";
            comboBoxMonsters.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Character p in characters)
            {
                comboBoxPlayers.Items.Add(p.Name);
            }
            comboBoxPlayers.SelectedIndex = 0;
            comboBoxPlayers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAdvantage.SelectedIndex = 1;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void setUpPlayer()
        {
            panel1.Controls.Clear();
            TextBox playerName = new TextBox() { Left = 40, Top = 40, Height = 20, Width = 140, Text = player.Name };

            //Attacks
            Attacks = new ComboBox() { Left = 40, Top = 80, Height = 20, Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            if (player.Attacks.Count != 0)
            {
                AtkRange = new Label() { Left = 40, Top = 120, Height = 20, Width = 40, TextAlign = ContentAlignment.MiddleLeft, Text = player.Attacks[0].Range.ToString() + " ft" };
                AtkTH = new Label() { Left = 80, Top = 120, Height = 20, Width = 60, TextAlign = ContentAlignment.MiddleLeft, Text = "+" + player.Attacks[0].AttackModifier.ToString() + " to hit" };
                AtkDice = new Label() { Left = 40, Top = 160, Height = 20, Width = 40, TextAlign = ContentAlignment.MiddleLeft, Text = player.Attacks[0].DiceNumber.ToString() + "d" + player.Attacks[0].DiceType.ToString() };
                AtkMod = new Label() { Left = 80, Top = 160, Height = 20, Width = 40, TextAlign = ContentAlignment.MiddleLeft, Text = "+" + player.Attacks[0].DamageModifier.ToString() };
                AtkType = new Label() { Left = 120, Top = 160, Height = 20, Width = 80, TextAlign = ContentAlignment.MiddleLeft, Text = player.Attacks[0].DamageType.ToString() };

                Attacks.SelectedIndexChanged += new EventHandler(this.NewComboBox_SelectedIndexChanged1);
                foreach (Attack s in player.Attacks)
                {
                    Attacks.Items.Add(s.Name);
                }
                Attacks.SelectedIndex = 0;
            }
            Button AttackB = new Button() { Left = 260, Top = 80, Height = 20, Width = 60, Text = "Attack" };
            AttackB.MouseDown += new MouseEventHandler(this.AttackButton_MouseDown);

            //Spells
            Spells = new ComboBox() { Left = 40, Top = 240, Height = 20, Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };

            if (player.Spells.Count != 0)
            {
                SplRange = new Label() { Left = 40, Top = 280, Height = 20, Width = 40, TextAlign = ContentAlignment.MiddleLeft, Text = player.Spells[0].Range.ToString() + " ft" };
                SplTH = new Label() { Left = 80, Top = 280, Height = 20, Width = 100, TextAlign = ContentAlignment.MiddleLeft };
                if (player.Spells[0].AlwaysHits == true)
                {
                    SplTH.Text = "Always hits";
                }
                else if (player.Spells[0].AttackSave == 0)
                {
                    SplTH.Text = "+" + player.SpellAttackModifier.ToString() + " to hit";
                }
                else
                {
                    SplTH.Text = player.SpellSaveDC.ToString() + "DC, " + Enum.GetName(typeof(stats), player.Spells[0].AttackSave) + " save";
                }
                SplDice = new Label() { Left = 40, Top = 320, Height = 20, Width = 40, TextAlign = ContentAlignment.MiddleLeft, Text = player.Spells[0].DiceNumber.ToString() + "d" + player.Spells[0].DiceType.ToString() };
                SplMod = new Label() { Left = 80, Top = 320, Height = 20, Width = 40, TextAlign = ContentAlignment.MiddleLeft, Text = "+" + player.Spells[0].DamageModifier.ToString() };
                SplType = new Label() { Left = 120, Top = 320, Height = 20, Width = 80, TextAlign = ContentAlignment.MiddleLeft, Text = player.Spells[0].DamageType.ToString() };

                Spells.SelectedIndexChanged += new EventHandler(this.NewComboBox_SelectedIndexChanged2);
                foreach (Spell s in player.Spells)
                {
                    Spells.Items.Add(s.Name);
                }
                Spells.SelectedIndex = 0;
            }
            Button SpellB = new Button() { Left = 260, Top = 240, Height = 20, Width = 60, Text = "Spell" };
            SpellB.MouseDown += new MouseEventHandler(this.SpellButton_MouseDown);

            panel1.Controls.Add(playerName);
            panel1.Controls.Add(Attacks);
            panel1.Controls.Add(AttackB);
            panel1.Controls.Add(AtkRange);
            panel1.Controls.Add(AtkTH);
            panel1.Controls.Add(AtkDice);
            panel1.Controls.Add(AtkMod);
            panel1.Controls.Add(AtkType);
            panel1.Controls.Add(Spells);
            panel1.Controls.Add(SplRange);
            panel1.Controls.Add(SplTH);
            panel1.Controls.Add(SplDice);
            panel1.Controls.Add(SplMod);
            panel1.Controls.Add(SplType);
            panel1.Controls.Add(SpellB);
        }
        private void setUpPanel2()
        {
            panel2.Controls.Clear();
            MonName = new TextBox() { Left = 40, Top = 40, Height = 20, Width = 80 };
            Type = new TextBox() { Left = 40, Top = 80, Height = 20, Width = 80 };
            Label labelAC = new Label() { Left = 130, Top = 43, Height = 20, Width = 30, Text = "AC:" };
            AC = new TextBox() { Left = 160, Top = 40, Height = 20, Width = 20 };
            Label labelHP = new Label() { Left = 130, Top = 83, Height = 20, Width = 30, Text = "HP:" };
            HP = new TextBox() { Left = 160, Top = 80, Height = 20, Width = 20 };
            List<Label> labels = new List<Label>()
            {
                new Label() { Left = 80, Top = 120, Height = 20, Width = 40, Text = "Str:", TextAlign = ContentAlignment.MiddleRight },
                new Label() { Left = 80, Top = 140, Height = 20, Width = 40, Text = "Dex:", TextAlign = ContentAlignment.MiddleRight },
                new Label() { Left = 80, Top = 160, Height = 20, Width = 40, Text = "Con:", TextAlign = ContentAlignment.MiddleRight },
                new Label() { Left = 80, Top = 180, Height = 20, Width = 40, Text = "Int:", TextAlign = ContentAlignment.MiddleRight },
                new Label() { Left = 80, Top = 200, Height = 20, Width = 40, Text = "Wis:", TextAlign = ContentAlignment.MiddleRight },
                new Label() { Left = 80, Top = 220, Height = 20, Width = 40, Text = "Cha:", TextAlign = ContentAlignment.MiddleRight },
                new Label() { Left = 40, Top = 260, Height = 20, Width = 80, Text = "Resistances:", TextAlign = ContentAlignment.MiddleRight },
                new Label() { Left = 40, Top = 280, Height = 20, Width = 80, Text = "Vulnerabilities:", TextAlign = ContentAlignment.MiddleRight },
                new Label() { Left = 40, Top = 300, Height = 20, Width = 80, Text = "Immunities:", TextAlign = ContentAlignment.MiddleRight }
            };
            Str = new TextBox() { Left = 120, Top = 120, Height = 20, Width = 30 };
            Dex = new TextBox() { Left = 120, Top = 140, Height = 20, Width = 30 };
            Con = new TextBox() { Left = 120, Top = 160, Height = 20, Width = 30 };
            Int = new TextBox() { Left = 120, Top = 180, Height = 20, Width = 30 };
            Wis = new TextBox() { Left = 120, Top = 200, Height = 20, Width = 30 };
            Cha = new TextBox() { Left = 120, Top = 220, Height = 20, Width = 30 };
            Resist = new TextBox() { Left = 120, Top = 260, Height = 20, Width = 100 };
            Vuln = new TextBox() { Left = 120, Top = 280, Height = 20, Width = 100 };
            Immun = new TextBox() { Left = 120, Top = 300, Height = 20, Width = 100 };
            //Button button = new Button() { Left = panel2.Width / 2 - 50, Top = 340, Height = 20, Width = 100, Text = "New Monster" };
            //button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewPanelButton_MouseDown);
            panel2.Controls.Add(MonName);
            panel2.Controls.Add(Type);
            panel2.Controls.Add(labelAC);
            panel2.Controls.Add(AC);
            panel2.Controls.Add(labelHP);
            panel2.Controls.Add(HP);
            foreach (Label label in labels)
            {
                panel2.Controls.Add(label);
            }
            panel2.Controls.Add(Str);
            panel2.Controls.Add(Dex);
            panel2.Controls.Add(Con);
            panel2.Controls.Add(Int);
            panel2.Controls.Add(Wis);
            panel2.Controls.Add(Cha);
            panel2.Controls.Add(Resist);
            panel2.Controls.Add(Vuln);
            panel2.Controls.Add(Immun);
        }
        private void customMonster()
        {
            MonName.Text = "name";
            Type.Text = "type";
            AC.Text = 12.ToString();
            HP.Text = 10.ToString();
            Str.Text = 0.ToString();
            Dex.Text = 0.ToString();
            Con.Text = 0.ToString();
            Int.Text = 0.ToString();
            Wis.Text = 0.ToString();
            Cha.Text = 0.ToString();
            Resist.Text = "";
            Vuln.Text = "";
            Immun.Text = "";
            Button button = new Button() { Left = panel2.Width / 2 - 50, Top = 340, Height = 20, Width = 100, Text = "New Monster" };
            button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewPanelButton_MouseDown);
            panel2.Controls.Add(button);
        }
        private void NewComboBox_SelectedIndexChanged1(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            AtkRange.Text = player.Attacks[comboBox.SelectedIndex].Range.ToString() + " ft";
            AtkTH.Text = "+" + player.Attacks[comboBox.SelectedIndex].AttackModifier.ToString() + " to hit";
            AtkDice.Text = player.Attacks[comboBox.SelectedIndex].DiceNumber.ToString() + "d" + player.Attacks[0].DiceType.ToString();
            AtkMod.Text = "+" + player.Attacks[comboBox.SelectedIndex].DamageModifier.ToString();
            AtkType.Text = player.Attacks[comboBox.SelectedIndex].DamageType.ToString();
        }
        private void NewComboBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            SplRange.Text = player.Spells[comboBox.SelectedIndex].Range.ToString() + " ft";
            if (player.Spells[comboBox.SelectedIndex].AlwaysHits == true)
            {
                SplTH.Text = "Always hits";
            }
            else if (player.Spells[comboBox.SelectedIndex].AttackSave == 0)
            {
                SplTH.Text = "+" + player.SpellAttackModifier.ToString() + " to hit";
            }
            else
            {
                SplTH.Text = player.SpellSaveDC.ToString() + "DC, " + Enum.GetName(typeof(stats), player.Spells[comboBox.SelectedIndex].AttackSave) + " save";
            }
            SplDice.Text = player.Spells[comboBox.SelectedIndex].DiceNumber.ToString() + "d" + player.Spells[0].DiceType.ToString();
            SplMod.Text = "+" + player.Spells[comboBox.SelectedIndex].DamageModifier.ToString();
            SplType.Text = player.Spells[comboBox.SelectedIndex].DamageType.ToString();
        }
        private void NewPanelButton_MouseDown(object sender, MouseEventArgs e)
        {
            monster = new Monster()
            {
                Name = MonName.Text,
                Type = Type.Text,
                AC = Int32.Parse(AC.Text),
                HP = Int32.Parse(HP.Text),
                SavingThrows = new SavingThrows()
                {
                    Str = Int32.Parse(Str.Text),
                    Dex = Int32.Parse(Dex.Text),
                    Con = Int32.Parse(Con.Text),
                    Int = Int32.Parse(Int.Text),
                    Wis = Int32.Parse(Wis.Text),
                    Cha = Int32.Parse(Cha.Text)
                }
            };
            string[] resists = Resist.Text.Split(',');
            foreach (string s in resists)
            {
                Enums.types t;
                Enum.TryParse(s, out t);
                if (t != 0)
                {
                    monster.Resistances.Add(t);
                }
            }
            string[] vulns = Vuln.Text.Split(',');
            foreach (string s in vulns)
            {
                Enums.types t;
                Enum.TryParse(s, out t);
                if (t != 0)
                {
                    monster.Vulnerabilities.Add(t);
                }
            }
            string[] immuns = Immun.Text.Split(',');
            foreach (string s in immuns)
            {
                Enums.types t;
                Enum.TryParse(s, out t);
                if (t != 0)
                {
                    monster.Immunities.Add(t);
                }
            }
            Button currentButton = (Button)sender;
            currentButton.Dispose();
            setUpMonster();
        }
        private void AttackButton_MouseDown(object sender, MouseEventArgs e)
        {
            rnd = new Random();
            timer = 0;
            adv = comboBoxAdvantage.SelectedIndex;
            th = player.Attacks[Attacks.SelectedIndex].AttackModifier;
            dice = player.Attacks[Attacks.SelectedIndex].DiceType;
            nodice = player.Attacks[Attacks.SelectedIndex].DiceNumber;
            mod = player.Attacks[Attacks.SelectedIndex].DamageModifier;
            type = player.Attacks[Attacks.SelectedIndex].DamageType;
            textBoxAtkRoll.Text = "";
            textBoxDmgRoll.Text = "";
            textBoxSaveRoll.Text = "";
            if (monster == null)
            {
                return;
            }
            else
            {
                timer1.Start();
            }
        }
        private void SpellButton_MouseDown(object sender, MouseEventArgs e)
        {
            rnd = new Random();
            timer = 0;
            adv = comboBoxAdvantage.SelectedIndex;
            th = player.SpellAttackModifier;
            dice = player.Spells[Spells.SelectedIndex].DiceType;
            nodice = player.Spells[Spells.SelectedIndex].DiceNumber;
            mod = player.Spells[Spells.SelectedIndex].DamageModifier;
            type = player.Spells[Spells.SelectedIndex].DamageType;
            DC = player.SpellSaveDC;
            save = player.Spells[Spells.SelectedIndex].AttackSave;
            textBoxAtkRoll.Text = "";
            textBoxDmgRoll.Text = "";
            textBoxSaveRoll.Text = "";
            if (monster == null)
            {
                return;
            }
            else if (player.Spells[Spells.SelectedIndex].AlwaysHits)
            {
                damageRoll(false, false);
                checkDeadness(int.Parse(HP.Text));
            }
            else if (save == 0)
            {
                timer1.Start();
            }
            else
            {
                timer2.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ++timer;
            int ac = int.Parse(AC.Text);
            int roll;
            if (timer == 20)
            {
                roll = rnd.Next(1, 21);
                if (adv != 1)
                {
                    int roll2;
                    roll2 = rnd.Next(1, 21);
                    if (adv == 0)
                    {
                        textBoxAtkRoll.Text = "[" + roll.ToString() + "|" + roll2.ToString() + "]";
                        roll = Min(roll, roll2);
                        if(th >= 0)
                        {
                            textBoxAtkRoll.Text += "+";
                        }
                        textBoxAtkRoll.Text += th.ToString() + " (" + (roll + th).ToString() + ")";
                    }
                    else
                    {
                        textBoxAtkRoll.Text = "[" + roll.ToString() + "|" + roll2.ToString() + "]";
                        roll = Max(roll, roll2);
                        if (th >= 0)
                        {
                            textBoxAtkRoll.Text += "+";
                        }
                        textBoxAtkRoll.Text += th.ToString() + " (" + (roll + th).ToString() + ")";
                    }
                }
                else
                {
                    textBoxAtkRoll.Text = roll.ToString();
                    if (th >= 0)
                    {
                        textBoxAtkRoll.Text += "+";
                    }
                    textBoxAtkRoll.Text += th.ToString() + " (" + (roll + th).ToString() + ")";
                }
                textBoxRoll.Text = roll.ToString();
                timer = 0;
                if (roll == 20)
                {
                    textBoxAtkRoll.Text = "CRIT!";
                    damageRoll(true, false);
                }
                else if ((roll + th) >= ac)
                {
                    damageRoll(false, false);
                }
                timer1.Stop();
                checkDeadness(int.Parse(HP.Text));
            }
            else if (timer % 2 == 0)
            {
                textBoxRoll.Text = rnd.Next(1, 21).ToString();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            ++timer;
            int saveMod = (int)monster.SavingThrows.GetType().GetProperty(Enum.GetName(typeof(stats), save)).GetValue(monster.SavingThrows);
            int roll;
            if (timer == 20)
            {
                roll = rnd.Next(1, 21);
                if (adv != 1)
                {
                    int roll2;
                    roll2 = rnd.Next(1, 21);
                    if (adv == 0)
                    {
                        textBoxSaveRoll.Text = "[" + roll.ToString() + "|" + roll2.ToString() + "]";
                        roll = Min(roll, roll2);
                        if (saveMod >= 0)
                        {
                            textBoxSaveRoll.Text += "+";
                        }
                        textBoxSaveRoll.Text += saveMod.ToString() + " (" + (roll + saveMod).ToString() + ")";
                    }
                    else
                    {
                        textBoxSaveRoll.Text = "[" + roll.ToString() + "|" + roll2.ToString() + "]";
                        roll = Max(roll, roll2);
                        if (saveMod >= 0)
                        {
                            textBoxSaveRoll.Text += "+";
                        }
                        textBoxSaveRoll.Text += saveMod.ToString() + " (" + (roll + saveMod).ToString() + ")";
                    }
                }
                else
                {
                    textBoxSaveRoll.Text = roll.ToString();
                    if (saveMod >= 0)
                    {
                        textBoxSaveRoll.Text += "+";
                    }
                    textBoxSaveRoll.Text += saveMod.ToString() + " (" + (roll + saveMod).ToString() + ")";
                }
                textBoxRoll.Text = roll.ToString();
                timer = 0;
                if ((roll + saveMod) >= DC)
                {
                    damageRoll(false, true);
                }
                else
                {
                    damageRoll(false, false);
                }
                timer2.Stop();
                checkDeadness(int.Parse(HP.Text));
            }
            else if (timer % 2 == 0)
            {
                textBoxRoll.Text = rnd.Next(1, 21).ToString();
            }
        }
        private void damageRoll(bool crit, bool saved)
        {
            int hp = int.Parse(HP.Text);
            double dmg = 0;
            for (int i = 0; i < nodice; ++i)
            {
                dmg += rnd.Next(1, dice + 1);
            }
            textBoxDmgRoll.Text = dmg.ToString();
            if (mod >= 0)
            {
                textBoxDmgRoll.Text += "+";
            }
            textBoxDmgRoll.Text += mod.ToString();
            if (crit)
            {
                dmg *= 2;
            }
            dmg += mod;
            if (saved)
            {
                dmg *= player.Spells[Spells.SelectedIndex].SavedMod;
            }
            if (monster.Immunities.Contains(type))
            {
                dmg = 0;
            }
            else if (monster.Resistances.Contains(type))
            {
                dmg /= 2;
            }
            else if (monster.Vulnerabilities.Contains(type))
            {
                dmg *= 2;
            }
            hp -= (int)dmg;
            textBoxDmgRoll.Text += " (" + ((int)dmg).ToString() + ")";
            HP.Text = hp.ToString();
        }
        private void checkDeadness(int hp)
        {
            if (hp <= 0)
            {
                Form2 form = new Form2();
                form.ShowDialog(this);
                buttonReset.PerformClick();
            }
        }
        private void setUpMonster()
        {
            MonName.Text = monster.Name;
            Type.Text = monster.Type;
            AC.Text = monster.AC.ToString();
            HP.Text = monster.HP.ToString();
            Str.Enabled = false;
            Str.Text = monster.SavingThrows.Str.ToString();
            Dex.Enabled = false;
            Dex.Text = monster.SavingThrows.Dex.ToString();
            Con.Enabled = false;
            Con.Text = monster.SavingThrows.Con.ToString();
            Int.Enabled = false;
            Int.Text = monster.SavingThrows.Int.ToString();
            Wis.Enabled = false;
            Wis.Text = monster.SavingThrows.Wis.ToString();
            Cha.Enabled = false;
            Cha.Text = monster.SavingThrows.Cha.ToString();
            Resist.Text = "";
            foreach (Enums.types t in monster.Resistances)
            {
                Resist.Text += t.ToString() + ", ";
            }
            if (Resist.Text != string.Empty)
            {
                Resist.Text = Resist.Text.Substring(0, Resist.Text.Length - 2);
            }
            Vuln.Text = "";
            foreach (Enums.types t in monster.Vulnerabilities)
            {
                Vuln.Text += t.ToString() + ", ";
            }
            if (Vuln.Text != string.Empty)
            {
                Vuln.Text = Vuln.Text.Substring(0, Vuln.Text.Length - 2);
            }
            Immun.Text = "";
            foreach (Enums.types t in monster.Immunities)
            {
                Immun.Text += t.ToString() + ", ";
            }
            if (Immun.Text != string.Empty)
            {
                Immun.Text = Immun.Text.Substring(0, Immun.Text.Length - 2);
            }
        }
    }
}

