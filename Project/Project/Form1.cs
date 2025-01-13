using System.Net.NetworkInformation;

namespace Project
{
    public partial class Form1 : Form
    {
        private static string msg_to_enc = "";
        private static int n, n1, m;
        private static int[] x_i = new int[7];
        private static int[] k_i = new int[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void Encrypt_buttton_Click(object sender, EventArgs e)
        {
            collectData();


        }

        private void collectData()
        {
            msg_to_enc = Msg_to_encrypt.Text;

            n = Int32.Parse(N_field.Text);
            n1 = Int32.Parse(N1_field.Text);
            m = Int32.Parse(M_field.Text);

            string[] tmp_x = Public_key.Text.Split(' ');
            for (int i = 0; i < 7; i++)
            {
                x_i[i] = Int32.Parse(tmp_x[i]);
            }

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

                Random random = new Random();
                int tmpGen = random.Next(k_i[0], k_i[0] + 100);

                for (int i = 1; i < 7; i++)
                {
                    while (sumOfPrevious(k_i,i) > tmpGen)
                    {
                        tmpGen = random.Next();
                    }

                    k_i[i] = tmpGen;
                    tmpGen = random.Next();
                }

                MessageBox.Show(k_i[0] + " " +  k_i[1] + " " + k_i[2] + " " + k_i[3] + " " + k_i[4] + " " + k_i[5] + " " + k_i[6]);
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
        }

        private int sumOfPrevious(int[] arr, int stop_ind)
        {
            int sum = 0;

            for(int i = 0; i  < stop_ind; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        private bool checkCorrectSequence(int[] sequence)
        {
            for (int i = 0; i < 7; i++)
            {
                if(!(i == 0)) {
                    if (sequence[i] < sumOfPrevious(sequence, i)) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
