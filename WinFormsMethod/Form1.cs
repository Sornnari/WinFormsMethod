namespace WinFormsMethod
{
    public partial class Form1 : Form
    {
        private object clearForms;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hellow", "��������ͺ������ǹ���");
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //���� "�ӹǳ BMI"
            //input �Ѻ��� TextbtnBMI
            string name = txtxName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //1  double hegiht = Convert.ToDouble(txtHeight.Text);
            //1  double weight = Convert.ToDouble(txtWeight.Text);

            //2  double height = 0;
            //2  f (double.TryParse(txtHeight.Text, out height) == false)
            //2  {
            //2   MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
            //2    return; //��Ҥ��� if �繨�ԧ ��騺��÷ӧҹ
            //2  }
            //2  double weight = 0;
            //2  if (double.TryParse(txtWeight.Text, out weight) == false)
            //2  {
            //2   MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
            //2    return; //��Ҥ��� if �繨�ԧ ��騺��÷ӧҹ
            //2  }


            double height = 0;
            double weight = 0;
            if (CheckDouble(txtWeight,txtHeight))
            {
                height = Convert.ToInt32(txtWeight.Text);
                weight = Convert.ToInt32(txtWeight.Text);
            }



            //process �ӹǳ��� BMI
            //double bmi = weight / Math.Pow(hegiht / 100, 2);
            double bmi = BMI(height, weight); // ���¡��Method MBI
            //Output �ż� �¹Ӥ�� BMI ����º�Ѻ����ҵðҹ
            lblResult.Text = bmi.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtxName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            txtxName.Focus();
        }

        private void InputDataValid(TextBox name, TextBox age) //���ͺ����� Textbox � Method
        {
            if (name.Text.Length != 0)
            {
                name.ForeColor = Color.DarkGreen;
            }
            else
            {
                name.ForeColor = Color.Black;
            }
            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.DarkGreen;
            }
            else
            {
                age.ForeColor = Color.Black;
            }
        }

        private void txtxName_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtxName, txtAge);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtxName, txtAge);
        }
        private double BMI(double h, double w)
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
            //return w / Math.Pow(h / 100, 2); ��¹Ẻ���
        }
        
    

        private bool CheckDouble(TextBox txtw, TextBox teth)
        {
            double w = 0;
            double h = 0;
            if ((double.TryParse(txtw.Text, out w)==false)
                || (double.TryParse(txtHeight.Text,out h)==false))
             {
                MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
                return false;
             }
            return true;
        }
    }
}
