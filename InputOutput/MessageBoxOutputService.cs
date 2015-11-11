using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputOutput
{
    public class MessageBoxOutputService : IOutputService
    {

        public void WriteMessage(string message)
        {
            MessageBox.Show(message);
        }

    }
}
