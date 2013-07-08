using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPort_GUI
{
    /// <summary>
    /// a delegate is used to callback the update method 
    /// </summary>
    /// <param name="buffer">Byte array buffer.</param>
    public delegate void UpdateForm(Byte[] buffer);

    /// <summary>
    /// GUI part 
    /// </summary>
    public partial class Form1 : Form
    {
        SerialComm com1 = null;//a SerialComm class object.
        StreamWriter sw = null;//
        FileStream fs = null;//

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            com1 = new SerialComm(this);//create a new SerialComm, and pass a reference(Form1)  
        }


        /// <summary>
        /// Updates the text. It will update the form textbox. 
        /// If it is neccesary, this method will update txt file at as well.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        public void UpdateText(Byte[] buffer)
        {
            String sentence = String.Format("{0}", Encoding.ASCII.GetString(buffer));
            msgDisplayTextBox.Text += sentence;
            //if the check box is checked, it will save this data to .txt file.
            if (openSaveFileDialogButton.Enabled == true)
            {
                sw.Write(sentence);
            }

        }
        /// <summary>
        /// Handles the Click event of the openSaveFileDialogButton control.
        /// open the openfile dialog
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void openSaveFileDialogButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            filePathTextBox.Text = path.SelectedPath;
        }

        /// <summary>
        /// Handles the DropDown event of the portNumberComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void portNumberComboBox_DropDown(object sender, EventArgs e)
        {
            string[] aa = System.IO.Ports.SerialPort.GetPortNames();
            portNumberComboBox.Items.Clear();
            //show all available ports
            foreach (string com in System.IO.Ports.SerialPort.GetPortNames())
            {
                portNumberComboBox.Items.Add(com);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the isSaveFileCheckBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void isSaveFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (isSaveFileCheckBox.Checked == true)
            {
                filePathTextBox.Enabled = true;
                openSaveFileDialogButton.Enabled = true;
                

            }
            else
            {
                filePathTextBox.Enabled = false;
                openSaveFileDialogButton.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the isSendCheckBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void isSendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isSendCheckBox.Enabled == true)
            {
                sendPeriodTextBox.Enabled = true;
                com1.SleepTime = Convert.ToInt16(sendPeriodTextBox.Text);
            }
            else 
            {
                sendPeriodTextBox.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the openPortButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void openPortButton_Click(object sender, EventArgs e)
        {
            if (openPortButton.Text == "Open")
            {
                if(this.isSaveFileCheckBox.Checked ==true)
                    OpenTxtStream();
                com1.SetPort(portNumberComboBox.Text, Convert.ToInt32(baudRateComboBox.Text));
                com1.Open();
                openPortButton.Text = "Close";

            }
            else
            {
                openPortButton.Text = "Open";
                com1.Close();
            }

        }

        /// <summary>
        /// Handles the FormClosing event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            com1.Terminate();
            if (sw != null && fs != null)
            {
                sw.Close();
                fs.Close();
            }
        }

        /// <summary>
        /// Handles the FormClosed event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the TextChanged event of the msgDisplayTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void msgDisplayTextBox_TextChanged(object sender, EventArgs e)
        {

            if (msgDisplayTextBox.Text.Length >= 100000)
                msgDisplayTextBox.Text = "";
        }

        /// <summary>
        /// Handles the Click event of the sendButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if (com1 != null && com1.IsOpen == true)
                //{

                    com1.WriteTimeout = Convert.ToInt32(writeTimeOutTextBox.Text);
                    com1.Write(sendMsgTextBox.Text);
                //}
                //else
                //{

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sending message error: " + ex.Message, "Warning!");
            }
        }

        /// <summary>
        /// Handles the Click event of the clearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            msgDisplayTextBox.Text = "";
        }
        /// <summary>
        /// Opens the TXT stream.
        /// </summary>
        private void OpenTxtStream()
        {
            fs = null;
            DateTime NowTime = DateTime.Now;
            string dateString = NowTime.ToString("[yyyy-MM-dd]_HHmmss");
            string fileName = filePathTextBox.Text + dateString + "_Record.txt";
            try
            {
                fs = new FileStream(fileName,
                   FileMode.CreateNew, FileAccess.Write, FileShare.Read);
            }
            catch (ArgumentNullException ex)
            {
                fileName = dateString + "_Record.txt";
                fs = new FileStream(fileName,
                   FileMode.CreateNew, FileAccess.Write, FileShare.Read);
                MessageBox.Show(ex.Message + Environment.NewLine + "change folder");
            }

            sw = new StreamWriter(fs);

            sw.WriteLine("Record Time :" + NowTime.ToString("yyyy-MM-dd HH:mm:ss"));
        }


    }
    
    
    
}
