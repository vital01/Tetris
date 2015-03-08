using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
//test
namespace Tetris
{
    public static class Animator
    {
        private static Dictionary<Label, AutoResetEvent> ActiveLabels { get; set; }

        static Animator()
        {
            ActiveLabels = new Dictionary<Label, AutoResetEvent>();
        }

        public static void FlickerLabel(Label label, int timeout, int count, Action action = null)
        {
            ActiveLabels.Add(label, new AutoResetEvent(false));
            Task.Factory.StartNew
                (delegate()
                {
                    while (true)
                    {
                        if (count == 0)
                        {
                            break;
                        }
                        count -= (count == -1 ? 0 : 1);
                        MainForm.BeginInvokeControl(label, new Action(() => { label.ForeColor = Color.FromArgb(~label.ForeColor.ToArgb()); }));
                        if (ActiveLabels[label].WaitOne(timeout))
                        {
                            MainForm.BeginInvokeControl(label, new Action(() => { label.ForeColor = Color.White; }));
                            break;
                        }
                    }                 
                    if (action != null)
                    {
                        action();
                    }
                    ActiveLabels.Remove(label);
                });
        }

        public static void CancelAnimation(Label label)
        {
            ActiveLabels[label].Set();
        }

        public static bool Active(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                if (ActiveLabels.ContainsKey(label))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool Active()
        {
            if (ActiveLabels.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
