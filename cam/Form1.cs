using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cam {
    public partial class camForm : Form {
        public int GraphicNum = 0;
        private void numChecker(KeyPressEventArgs e) {
            if (e.KeyChar == (Char)48 || e.KeyChar == (Char)49 ||
                e.KeyChar == (Char)50 || e.KeyChar == (Char)51 ||
                e.KeyChar == (Char)52 || e.KeyChar == (Char)53 ||
                e.KeyChar == (Char)54 || e.KeyChar == (Char)55 ||
                e.KeyChar == (Char)56 || e.KeyChar == (Char)57 ||
                e.KeyChar == (Char)13 || e.KeyChar == (Char)8) {
                e.Handled = false;

            }
            else {
                e.Handled = true;
            }
        }
        private bool emptyChecker() {
            if (camNum.Text == "" || camStationNum.Text == "") {
                MessageBox.Show("數值不得為空!", "錯誤");
                return false;
            }
            return true;
        }
        public camForm() {
            InitializeComponent();
        }

        private void camStationNum_KeyPress(object sender, KeyPressEventArgs e) {
            numChecker(e);
        }

        private void camNum_KeyPress(object sender, KeyPressEventArgs e) {
            numChecker(e);
        }

        private void generate_Click(object sender, EventArgs e) {
            if (emptyChecker()) {
                int camStationValue = int.Parse(camStationNum.Text);
                int camValue = int.Parse(camNum.Text);
                
                string ErrorMsg = "";

                if (camStationValue > 4 || camStationValue <= 0) {
                    ErrorMsg += "監視站數量範圍為 1～4 !! \n";
                    camStationNum.Clear();
                }

                if (camValue > 9 || camValue <= 0) {
                    ErrorMsg += "監視器數量範圍為 1～9 !! \n";
                    camNum.Clear();
                }
                if (ErrorMsg == "") {
                    GraphicNum = 1;
                    GraphicForm GraphicForm = new GraphicForm();
                    GraphicForm.Show();
                }
                    

            }
        }

        
        
            


    }
}
