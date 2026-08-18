using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem
{
    public partial class SearchBookInfo : Form
    {
        SqlConnection con = new DBConnection().getDBConnection();
        public SearchBookInfo()
        {
            InitializeComponent();
        }

        private void SearchBookInfo_Load(object sender, EventArgs e)
        {

        }

        public void SetBookData(string bookID, string bookTitle, string bookAuthor, string language, string category, string ISBN, string availability)
        {
            lblBookID.Text = bookID;
            lblBookTitle.Text = bookTitle;
            lblAuthor.Text = bookAuthor;
            lblLanguage.Text = language;
            lblCategory.Text = category;
            lblISBN.Text = ISBN;
            lblAvailability.Text = availability;


        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }
    }
}
