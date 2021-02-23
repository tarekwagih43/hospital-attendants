using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirary
{
    public partial class Form1 : Form
    {
        int leftcontrol = 1;
        string PatientName;
        string PatientPhone;
        string PatientCondition;

        public ControlEventHandler DeletBut { get; private set; }

        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientName = PName.Text;
            PatientPhone = PPhone.Text;
            PatientCondition = ConditionIn.Text;
            if(PatientPhone!= null)
            {
                PatientPhone = PatientPhone;
            }
            else
            {
                var PatientPhoneRa = new Random();
                //PatientPhone = PatientPhone2.ToString;
            }
            string NewID = DateTime.Now.Month + "-" + PatientPhone.Substring(PatientPhone.Length - 3).PadLeft(3, '0');

            TextBox NameField = new TextBox();
            this.Controls.Add(NameField);
            NameField.Top = leftcontrol * 25;
            NameField.Left = 600;
            NameField.ReadOnly = true;
            NameField.Size = new Size(120, 40);
            NameField.Text = PatientName.ToString();

            TextBox Phone = new TextBox();
            this.Controls.Add(Phone);
            Phone.Top = leftcontrol * 25;
            Phone.Left = 605 + NameField.Width;
            Phone.ReadOnly = true;
            Phone.Size = new Size(120, 40);
            Phone.Text = PatientPhone.ToString();

            TextBox PaID = new TextBox();
            this.Controls.Add(PaID);
            PaID.Top = leftcontrol * 25;
            PaID.Left = 610 + NameField.Width + Phone.Width;
            PaID.ReadOnly = true;
            PaID.Size = new Size(120, 40);
            PaID.Text = NewID.ToString();

            TextBox PatCondition = new TextBox();
            this.Controls.Add(PatCondition);
            PatCondition.Top = leftcontrol * 25;
            PatCondition.Left = 610 + NameField.Width + Phone.Width;
            PatCondition.ReadOnly = true;
            PatCondition.Size = new Size(120, 40);
            PatCondition.Text = PatientCondition.ToString();

            Button DeletBut = new Button();
            DeletBut.Location = new Point(10, 10);
            DeletBut.Text = "Remove";
            DeletBut.BackColor = Color.Red;
            DeletBut.ForeColor = Color.White;
            DeletBut.Size = new Size(75, 40);
            DeletBut.Click += new System.EventHandler(this.RemovePatient);

            if (ViewTable.Height == 1000 ) {
            }
            else
            {
                ViewTable.RowStyles.Clear();
            }

            // Add child controls to TableLayoutPanel and specify rows and column  

            ViewTable.Controls.Add(NameField, 0 , leftcontrol);
            ViewTable.Controls.Add(Phone, 1  , leftcontrol);
            ViewTable.Controls.Add(PaID, 2, leftcontrol);
            ViewTable.Controls.Add(PatCondition, 3, leftcontrol);
            ViewTable.Controls.Add(DeletBut, 4, leftcontrol);

            ViewTable.RowCount++;

            Controls.Add(ViewTable);

            PName.Text = "";
            PPhone.Text = "";
            PPhone.Text = "";
            ConditionIn.Text = "";

            leftcontrol = leftcontrol + 1;
        }

        private void RemovePatient(object sender, EventArgs e)
        {
            string message = "Do You Want To Remove That Patient?";
            string title = "Remove Patient";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {

            }
            else
            {
                 ViewTable.Controls.RemoveByKey(PatientName);
            }
        }

    }
}
