using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp
{
    /*  Создание делегата и его использование:
     *  Делегат - тип данных, который может хранить ссылку на метод, 
     *  сигнатура которого совпадает с сигнатурой, объявленной в делегате.
     *  1) Объявляем делегат CountDelegat с сигнатурой int(string)
     *  
    */

    public partial class Form1 : Form
    {
        // Создание списка
        List<Button> listButtons = new List<Button>();

        public Form1()
        {
            InitializeComponent();

            // добавляет в список list ссылки экземпляров класса System.Windows.Forms.Button()
            listButtons.Add(button1);  
            listButtons.Add(button2);
            listButtons.Add(button3);
            listButtons.Add(button4);
            listButtons.Add(button5);
            listButtons.Add(button6); 
            listButtons.Add(button7);
            listButtons.Add(button8);
            listButtons.Add(button9);
            listButtons.Add(button10);
        }

        // Меняем свойства кнопок buttons(n) нажатием на переключатель RadioButton
        private void Usual_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Usual_RadioButton.Checked == true)
            {
                for (int i = 0; i < listButtons.Count; i++)
                {
                    listButtons[i].ForeColor = SystemColors.WindowText;
                    listButtons[i].BackColor = SystemColors.Control;
                    //listButtons[i].BackColor = SystemColors.WindowFrame;
                }
            }
        }

        private void Dark_RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (Dark_RadioButton.Checked == true)
            {
                for (int i = 0; i < listButtons.Count; i++)
                {
                    listButtons[i].ForeColor = Color.DarkGoldenrod;
                    listButtons[i].BackColor = Color.DarkBlue;
                }
            }            
        }

        private void Orchid_RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (Orchid_RadioButton.Checked == true)
            {
                for (int i = 0; i < listButtons.Count; i++)
                {
                    listButtons[i].ForeColor = Color.Orchid;
                    listButtons[i].BackColor = Color.YellowGreen;
                }
            }
        }
    }
}
