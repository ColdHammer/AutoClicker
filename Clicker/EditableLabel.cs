using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
 
    public class EditableLabel : Label
    {
        public static Hashtable ELabelList = new Hashtable();
        public static EditableLabel ItemToEdit = null;
        public class ColorModes {
            public ColorModes() { }
            public ColorModes(Color fore, Color back)
            {
                Fore = fore;
                Background = back;
            }
            public Color Fore = DefaultForeColor, Background = Color.Transparent; }
        ColorModes DefaultMode = new ColorModes();
        ColorModes EditMode = new ColorModes(Color.Lime, Color.DarkGreen);
        ColorModes EmptyMode = new ColorModes(Color.Coral, Color.DarkRed);
        public Action KeyDownAction = null;
        
        private int? LetterValue = null;

        public static EditableLabel GetLabelIfItExists(int key)
        {
            return (EditableLabel)ELabelList[key];
        }
        bool IsListed = false;

        public int KeyValue { get => (int)LetterValue; set { 
                            if (value >= 0 && value <= 255) {
                                Text = $"{(Keys)value}";
                                if(LetterValue!=null)ELabelList.Remove(LetterValue);
                                LetterValue = value;
                                IsListed = this.Add();
                                SetColor();
                            } 
                        } }



        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EditableLabel
            // 
            this.ForeColor = EmptyMode.Fore;
            this.SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
            this.DoubleClick += new EventHandler(this.EditableLabel_DoubleClick);
            this.Click += new EventHandler(this.EditableLabel_Click);
            this.ResumeLayout(false);
            this.KeyValue = 0;
            while(!IsListed)
            {
                KeyValue++;
            }
            SetColor();
        }

        private void EditableLabel_DoubleClick(object sender, EventArgs e)
        {
            KeyValue = 0;
            SetEditMode();
        }

        static public EditableLabel IsKeyUsed(int key)
        {
            return (EditableLabel)ELabelList[key];
        }

        public EditableLabel()
        {
            InitializeComponent();
        }

        public Func<int, int, int, int, bool> StopCondition = (x, y, z, j) => x != y && x != z;

        public void SetColor()
        {
            if (ItemToEdit == this)
            {

                ForeColor = EditMode.Fore;
                BackColor = EditMode.Background;
            }
            else
            {
                if (KeyValue == 0)
                {
                    ForeColor = EmptyMode.Fore;
                    BackColor = EmptyMode.Background;
                }
                else
                {
                    ForeColor = DefaultMode.Fore;
                    BackColor = DefaultMode.Background;
                }
            }
        }


        /// <summary>
        /// Set Edit mode puts the label on Edit mode
        /// </summary>
        public void SetEditMode()
        {
            if (ItemToEdit != this)
            {
                if(ItemToEdit != null)
                {
                    ItemToEdit.SetEditMode();
                }
                ItemToEdit = this;
            }
            else
            {
                ItemToEdit = null;
            }
            SetColor();
        }

        private void EditableLabel_Click(object sender, EventArgs e)
        {
            SetEditMode();
        }
    }

    public static class Tools
    {
        public static bool Add(this EditableLabel label)
        {
            if (EditableLabel.ELabelList.ContainsKey(label.KeyValue)) return false;
            EditableLabel.ELabelList.Add(label.KeyValue, label);
            return true;
        }
    }
}
