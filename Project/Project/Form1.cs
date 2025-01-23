using System.Net.NetworkInformation;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project
{
    public partial class Form1 : Form
    {
        private static char[] msg_to_enc = new char[7];
        private static int n, n1, m;
        private static int[] x_i = new int[7];
        private static int[] k_i = new int[7];
        private static int[] c_i = new int[7];

        public Form1()
        {
            InitializeComponent();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void Encrypt_buttton_Click(object sender, EventArgs e)
        {
            collectData();


        }

        private void collectData()
        {
            msg_to_enc = Msg_to_encrypt.Text.ToCharArray();

            string[] tmp_x = Public_key.Text.Split(' ');
            for (int i = 0; i < 7; i++)
            {
                x_i[i] = Int32.Parse(tmp_x[i]);
            }


            //k_i
            if (checkBox1.Checked)
            {
                string[] tmp_k = Private_key.Text.Split(' ');
                for (int i = 0; i < 7; i++)
                {
                    k_i[i] = Int32.Parse(tmp_k[i]);
                }

                if (!checkCorrectSequence(k_i))
                {
                    MessageBox.Show("Incorrect sequence entered!");
                    return;
                }

                MessageBox.Show(k_i[0] + " " + k_i[1] + " " + k_i[2] + " " + k_i[3] + " " + k_i[4] + " " + k_i[5] + " " + k_i[6]);
            }
            else if (checkBox2.Checked)
            {
                k_i[0] = Int32.Parse(Private_key.Text);

                Random rand = new Random();
                int tmpGen = rand.Next(k_i[0], k_i[0] + 100);

                for (int i = 1; i < 7; i++)
                {
                    while (sumOfPrevious(k_i, i) > tmpGen)
                    {
                        tmpGen = rand.Next();
                    }

                    k_i[i] = tmpGen;
                    tmpGen = rand.Next();
                }

                MessageBox.Show(k_i[0] + " " + k_i[1] + " " + k_i[2] + " " + k_i[3] + " " + k_i[4] + " " + k_i[5] + " " + k_i[6]);
            }
            else if (checkBox3.Checked)
            {
                string[] private_key = File.ReadAllText("private_key.txt").Split(' ');

                for (int i = 0; i < 7; i++)
                {
                    k_i[i] = Int32.Parse(private_key[i]);
                }

                if (!checkCorrectSequence(k_i))
                {
                    MessageBox.Show("Incorrect sequence entered!");
                    return;
                }

                MessageBox.Show(k_i[0] + " " + k_i[1] + " " + k_i[2] + " " + k_i[3] + " " + k_i[4] + " " + k_i[5] + " " + k_i[6]);
            }
            else
            {
                MessageBox.Show("U didnt choose any variant!");
                return;
            }


            //M
            if (checkBox4.Checked)
            {
                if (sumOfPrivateKeyEl() < Int32.Parse(M_field.Text))
                {
                    m = Int32.Parse(M_field.Text);
                }
                else
                {
                    MessageBox.Show("M is not correct!");
                    return;
                }
            }
            else if (checkBox5.Checked)
            {
                Random rand = new Random();

                if ((int)sumOfPrivateKeyEl() + 1 > 0)
                    m = rand.Next((int)sumOfPrivateKeyEl() + 1, Int32.MaxValue);
                else
                    m = rand.Next(((int)sumOfPrivateKeyEl() + 1) * -1, Int32.MaxValue);

                M_field.Text = m.ToString();
            }
            else if (checkBox6.Checked)
            {
                if (Int32.Parse(File.ReadAllText("m.txt")) > sumOfPrivateKeyEl())
                {
                    m = Int32.Parse(File.ReadAllText("m.txt"));
                }
                else
                {
                    MessageBox.Show("M from file is not correct!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("U didnt choose any variant!");
                return;
            }

            Random random = new Random();

            while (true)
            {
                n = random.Next(2, 10000);

                if (IsPrime(n) && NOD(n, m) == 1)
                {
                    break;
                }
            }

            n1 = generateN1(n, m);

            N_field.Text = n.ToString();
            N1_field.Text = n1.ToString();


            Symb1.Text = msg_to_enc[0].ToString();
            Symb2.Text = msg_to_enc[1].ToString();
            Symb3.Text = msg_to_enc[2].ToString();
            Symb4.Text = msg_to_enc[3].ToString();
            Symb5.Text = msg_to_enc[4].ToString();
            Symb6.Text = msg_to_enc[5].ToString();
            Symb7.Text = msg_to_enc[6].ToString();


            int[,] bins = new int[7, 7];

            for (int i = 1; i < 8; i++)
            {
                Bin1.Text += toBin(msg_to_enc[0])[i];
                bins[0, i - 1] = toBin(msg_to_enc[0])[i];

                Bin2.Text += toBin(msg_to_enc[1])[i];
                bins[1, i - 1] = toBin(msg_to_enc[1])[i];

                Bin3.Text += toBin(msg_to_enc[2])[i];
                bins[2, i - 1] = toBin(msg_to_enc[2])[i];

                Bin4.Text += toBin(msg_to_enc[3])[i];
                bins[3, i - 1] = toBin(msg_to_enc[3])[i];

                Bin5.Text += toBin(msg_to_enc[4])[i];
                bins[4, i - 1] = toBin(msg_to_enc[4])[i];

                Bin6.Text += toBin(msg_to_enc[5])[i];
                bins[5, i - 1] = toBin(msg_to_enc[5])[i];

                Bin7.Text += toBin(msg_to_enc[6])[i];
                bins[6, i - 1] = toBin(msg_to_enc[6])[i];
            }

            int[] sumsOfCol = new int[7];
            int stLabel = 15;
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (bins[j, i] == 1)
                    {
                        Controls["label" + (stLabel + (i * 7))].Text = x_i[i].ToString();
                        sumsOfCol[j] += x_i[i];
                    }
                    else
                    {
                        Controls["label" + (stLabel + (i * 7))].Text = "";
                    }
                }
                stLabel--;
            }


            Encrypted_message.Text = "";
            stLabel = 64;
            for (int i = 0; i < 7; i++)
            {
                Controls["label" + stLabel].Text = (sumsOfCol[i] % m).ToString();
                c_i[i] = sumsOfCol[i] % m;
                Encrypted_message.Text += c_i[i].ToString() + " ";
                stLabel--;
            }


        }

        private int generateN1(int n, int m)
        {
            // алгоритм Эвклида для нахождения обратного элемента
            int t = 0, newT = 1;
            int r = m, newR = n;

            while (newR != 0)
            {
                int quotient = r / newR;

                int tempT = t;
                t = newT;
                newT = tempT - quotient * newT;

                int tempR = r;
                r = newR;
                newR = tempR - quotient * newR;
            }

            t += m;

            return t;
        }

        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        private int[] toBin(char symb)
        {
            byte[] bytes = Encoding.GetEncoding("windows-1251").GetBytes(new char[] { symb });
            string binaryValue = Convert.ToString(bytes[0], 2).PadLeft(8, '0');

            int[] binaryArray = new int[binaryValue.Length];
            for (int i = 0; i < binaryValue.Length; i++)
            {
                binaryArray[i] = binaryValue[i] == '1' ? 1 : 0;
            }

            return binaryArray;
        }

        private long sumOfPrivateKeyEl()
        {
            long sum = 0;

            for (int i = 0; i < 7; i++)
            {
                sum += k_i[i];
            }

            return sum;
        }

        private int sumOfPrevious(int[] arr, int stop_ind)
        {
            int sum = 0;

            for (int i = 0; i < stop_ind; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        private bool checkCorrectSequence(int[] sequence)
        {
            for (int i = 0; i < 7; i++)
            {
                if (!(i == 0))
                {
                    if (sequence[i] < sumOfPrevious(sequence, i))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            File.WriteAllText("n.txt", n.ToString());
            File.WriteAllText("n1.txt", n1.ToString());
            File.WriteAllText("m.txt", m.ToString());

            string c_i_tmp = "";
            for (int i = 0; i < 7; i++)
            {
                c_i_tmp += c_i[i].ToString() + " ";
            }
            File.WriteAllText("c_i.txt", c_i_tmp);

            string opKeyTmp = "";
            for (int i = 0; i < 7; i++)
            {
                opKeyTmp += x_i[i].ToString() + " ";
            }
            File.WriteAllText("public_key.txt", opKeyTmp);

            string clKeyTmp = "";
            for (int i = 0; i < 7; i++)
            {
                clKeyTmp += k_i[i].ToString() + " ";
            }
            File.WriteAllText("private_key.txt", clKeyTmp);

            MessageBox.Show("Data has been saved successfully!");
        }

        private void Upload_button_Click(object sender, EventArgs e)
        {
            uplData();
            MessageBox.Show("Data has successfully uploaded!");
        }

        void uplData()
        {
            using (StreamReader sr = new StreamReader("n.txt"))
            {
                n = Int32.Parse(sr.ReadLine());
                N_field.Text = n.ToString();
            }

            using (StreamReader sr = new StreamReader("n1.txt"))
            {
                n1 = Int32.Parse(sr.ReadLine());
                N1_field.Text = n1.ToString();
            }

            using (StreamReader sr = new StreamReader("m.txt"))
            {
                m = Int32.Parse(sr.ReadLine());
                M_field.Text = m.ToString();
            }

            using (StreamReader sr = new StreamReader("c_i.txt"))
            {
                string c_i_str = sr.ReadLine();

                Msg_to_encrypt.Text = c_i_str;

                for (int i = 0; i < 7; i++)
                {
                    c_i[i] = Int32.Parse(c_i_str.Split(' ')[i]);
                }
            }

            using (StreamReader sr = new StreamReader("public_key.txt"))
            {
                string public_key_str = sr.ReadLine();

                Public_key.Text = public_key_str;

                for (int i = 0; i < 7; i++)
                {
                    x_i[i] = Int32.Parse(public_key_str.Split(' ')[i]);
                }
            }

            using (StreamReader sr = new StreamReader("private_key.txt"))
            {
                string private_key_str = sr.ReadLine();

                Private_key.Text = private_key_str;

                for (int i = 0; i < 7; i++)
                {
                    k_i[i] = Int32.Parse(private_key_str.Split(' ')[i]);
                }
            }
        }

        private void Decrypt_button_Click(object sender, EventArgs e)
        {
            uplData();


        }
    }
}
