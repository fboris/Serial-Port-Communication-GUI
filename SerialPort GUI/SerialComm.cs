using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace SerialPort_GUI
{
    class SerialComm : SerialPort
    {
        private Boolean IsReceiving = false;
        private Boolean IsRuning = false;
        private Boolean IsPeriodSending = false;
        private int sleepTime = 200;
        Thread receivingThread = null;

        Form1 form;

        /// <summary>
        /// Initializes a new instance of the <see cref="SerialComm"/> class.
        /// </summary>
        /// <param name="form">The form.</param>
        public SerialComm(Form1 form)
        {
            this.form = form;
            base.WriteTimeout = 100;
            //base.= new SerialPort();
            receivingThread = new Thread(DoReceive);
            IsRuning = true;
            receivingThread.Start();
            
            
            
        }
        /// <summary>
        /// Gets or sets the sleep time.
        /// </summary>
        /// <value>
        /// The sleep time.
        /// </value>
        public int SleepTime
        {
           get
           {
               return sleepTime;
           }
           set
           {
               sleepTime = value;
           }
        }
        /// <summary>
        /// Does the receive.
        /// </summary>
        private void DoReceive()
        {
            Byte[] buffer = new Byte[1024];
            while (IsRuning)
            {
                while (IsReceiving)
                {
                    try
                    {
                        if (base.BytesToRead > 0)
                        {

                            Int32 length = base.Read(buffer, 0, buffer.Length);
                            Array.Resize(ref buffer, length);
                            UpdateForm u = new UpdateForm(form.UpdateText);
                            form.Invoke(u, new Object[] { buffer });

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Receving thread error: " + ex.Message ,"Warning!");
                        IsReceiving = false;
                    }

                    Thread.Sleep(50);
                }
                while (!IsReceiving) Thread.Sleep(10);
            }
        }
        private void DoPeriodWrite(Object data)
        {
            while (true)
            {

                Byte[] dataBytes = data as Byte[];
                try
                {
                    base.Write(dataBytes, 0, dataBytes.Length);
                }
                catch (Exception e)
                {
                    //show something exception details in dialog
                    MessageBox.Show("Writing thread error: " + e.Message, "Warning!");
                }
                Thread.Sleep(sleepTime);
            }
        }
        private void DoWrite(Object data)
        {
            
                Byte[] dataBytes = data as Byte[];
                try
                {
                    base.Write(dataBytes, 0, dataBytes.Length);
                }
                catch (Exception e)
                {
                    //show something exception details in dialog
                    MessageBox.Show("Writing thread error: " + e.Message, "Warning!");
                }
              

        }
        /// <summary>
        /// Writes the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        new public void Write(string msg)
        {
            
            Byte[] dataBytes = Encoding.ASCII.GetBytes(msg);
            Object o = dataBytes;
            Thread writing = new Thread(DoWrite);
            writing.Start(o);
            writing.IsBackground = true;

           

        }

        /// <summary>
        /// Sets the port.
        /// </summary>
        /// <param name="portName">Name of the port.</param>
        /// <param name="baudRate">The baud rate.</param>
        public void SetPort(string portName, int baudRate)
        {
            try
            {
                base.PortName = portName;
                base.BaudRate = baudRate;
            }
            catch (Exception e)
            {
                //show something exception details in dialog
                MessageBox.Show("Set port error: " + e.Message, "Warning!"); ;
            }
            base.DataBits = 8;
            base.Parity = System.IO.Ports.Parity.None;
            base.StopBits = System.IO.Ports.StopBits.One;
            base.Encoding = Encoding.ASCII;
            
        }
        /// <summary>
        /// 開啟新的序列埠連線。
        /// </summary>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
        ///   </PermissionSet>
        new public void Open()
        {
            try
            {
                base.Open();
                Thread.Sleep(200);
                    
            }
            catch (Exception e)
            {
                MessageBox.Show("Open port error: " + e.Message,"Warning!"); ;
            }
  
            IsReceiving = true;
            Thread.Sleep(200);
        }
        /// <summary>
        /// 關閉連接埠連線，將 <see cref="P:System.IO.Ports.SerialPort.IsOpen" /> 屬性設為 false，並處置內部 <see cref="T:System.IO.Stream" /> 物件。
        /// </summary>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
        ///   </PermissionSet>
        new public void Close()
        {
            try
            {
                if (base.IsOpen == true)
                {
                    IsReceiving = false;
                    
                    base.Close();
                    
                }
                
                Thread.Sleep(200);

            }
            catch (Exception e)
            {
                MessageBox.Show("Closing comport error: " + e.Message, "warning!"); ;
            }

            
        }
        /// <summary>
        /// Terminates this instance.
        /// </summary>
        public void Terminate()
        {
            IsRuning = false;
            Close();
            receivingThread.Abort();
            receivingThread.Join();

        }
    }
}
