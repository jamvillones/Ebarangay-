using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Barangay.Forms
{
    public partial class temp : Form
    {

        public temp()
        {
            InitializeComponent();
            // addControls(this);
            //conts.addControls(this);
            //textBox1.TextChanged += testing.TextBoxCallback;
            //textBox1.Validated += testing.TextBoxTrimSpaces;

            foreach(var i in this.GetContainedControls<TextBox>())
            {
                i.Validated += testing.TextBoxTrimSpaces;
            }
            //conts = this.GetContainedControls<Button>();
            //foreach (var i in conts)
            //    Console.WriteLine(i.Text);
        }
        List<Button> conts = new List<Button>();
    }
    public static class testing
    {
        public static void TextBoxTrimSpaces(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            if (string.IsNullOrEmpty(t.Text))
                return;
            if (t.Multiline)
                return;
            t.Text = t.Text.Trim(' ');
        }
        public static void addControls<T>(this List<T> collections, Control control) where T : Control
        {

            foreach (var i in control.Controls)
            {
                if (i is T)
                    collections.Add(i as T);
                else
                    addControls<T>(collections, i as Control);
            }
        }
        public static List<T> GetContainedControls<T>(this Control control) where T : Control
        {
            List<T> temp = new List<T>();
            foreach (var i in control.Controls)
            {
                if (i is T)
                    temp.Add((T)i);

                else
                    foreach (var j in GetContainedControls<T>(i as Control))
                        temp.Add(j);
            }
            return temp;
        }
    }
}
