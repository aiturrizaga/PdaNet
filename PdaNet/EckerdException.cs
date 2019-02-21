using System;

using System.Windows.Forms;

namespace PdaNet
{
    public class EckerdException : Exception
    {
        public EckerdException(string str)
        {
            MessageBox.Show("Error:" + str);
        }
    }
}
