namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            library = new Library();


        }


        // action button add 
        private void addbook_Click(object sender, EventArgs e)
        {
            labelAuthor.Visible = true;
            labelTitle.Visible = true;
            labelISBN.Visible = true;


            label1.Visible = false;
            label2.Visible = false;
            addbook.Visible = false;
            buttonDisplayAll.Visible = false;
            searchbtn.Visible = false;


            textBoxAuthor.Visible = true;
            textBoxISBN.Visible = true;
            textBoxTitle.Visible = true;
            buttonAdd.Visible = true;
            listViewBooks.Visible = false;
            deletebtn.Visible = false;



        }

        // action button search
        private void searchbtn_Click(object sender, EventArgs e)
        {

            label3.Visible = true;
            textBoxSearch.Visible = true;
            buttonSearch.Visible = true;
            buttonDelete.Visible = false;


            addbook.Visible = false;
            buttonDisplayAll.Visible = false;
            searchbtn.Visible = false;


            listViewBooks.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            deletebtn.Visible = false;



        }

        // action button delete
        private void deletebtn_Click(object sender, EventArgs e)
        {
            labelAuthor.Visible = true;
            labelTitle.Visible = true;
            labelISBN.Visible = true;
            buttonDelete.Visible=true;


            label1.Visible = false;
            label2.Visible = false;
            addbook.Visible = false;
            buttonDisplayAll.Visible = false;
            searchbtn.Visible = false;


            textBoxAuthor.Visible = true;
            textBoxISBN.Visible = true;
            textBoxTitle.Visible = true;
            buttonAdd.Visible = true;
            listViewBooks.Visible = false;
            deletebtn.Visible = false;
            buttonAdd.Visible= false;

            
        }
    }


}
