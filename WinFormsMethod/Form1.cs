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
            MessageBox.Show("Hellow", "โปรแกรมทดสอบความอ้วนผอม");
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //ปุ่ม "คำนวณ BMI"
            //input รับค่า TextbtnBMI
            string name = txtxName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //1  double hegiht = Convert.ToDouble(txtHeight.Text);
            //1  double weight = Convert.ToDouble(txtWeight.Text);

            //2  double height = 0;
            //2  f (double.TryParse(txtHeight.Text, out height) == false)
            //2  {
            //2   MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //2    return; //ถ้าค่าใน if เป็นจริง ให้จบการทำงาน
            //2  }
            //2  double weight = 0;
            //2  if (double.TryParse(txtWeight.Text, out weight) == false)
            //2  {
            //2   MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //2    return; //ถ้าค่าใน if เป็นจริง ให้จบการทำงาน
            //2  }


            double height = 0;
            double weight = 0;
            if (CheckDouble(txtWeight,txtHeight))
            {
                height = Convert.ToInt32(txtWeight.Text);
                weight = Convert.ToInt32(txtWeight.Text);
            }



            //process คำนวณค่า BMI
            //double bmi = weight / Math.Pow(hegiht / 100, 2);
            double bmi = BMI(height, weight); // เรียกใช้Method MBI
            //Output แปลผล โดยนำค่า BMI มาเทียบกับค่ามาตรฐาน
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

        private void InputDataValid(TextBox name, TextBox age) //ทดสอบการส่ง Textbox ใน Method
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
            //return w / Math.Pow(h / 100, 2); เขียนแบบสั้น
        }
        
    

        private bool CheckDouble(TextBox txtw, TextBox teth)
        {
            double w = 0;
            double h = 0;
            if ((double.TryParse(txtw.Text, out w)==false)
                || (double.TryParse(txtHeight.Text,out h)==false))
             {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return false;
             }
            return true;
        }
    }
}
