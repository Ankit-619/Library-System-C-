namespace WinFormsApp1
{
    partial class Form1

    {

        private System.ComponentModel.IContainer components = null;

        private Library library;
        protected override void Dispose(bool disposing)

        {

            if (disposing && (components != null))

            {

                components.Dispose();

            }

            base.Dispose(disposing);

        }



        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelAuthor = new Label();
            labelISBN = new Label();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxISBN = new TextBox();
            buttonAdd = new Button();
            buttonDisplayAll = new Button();
            buttonSearch = new Button();
            listViewBooks = new ListView();
            columnHeaderTitle = new ColumnHeader();
            columnHeaderAuthor = new ColumnHeader();
            columnHeaderISBN = new ColumnHeader();
            textBoxSearch = new TextBox();
            buttonDelete = new Button();
            label1 = new Label();
            addbook = new Button();
            searchbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            deletebtn = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(107, 19);
            labelTitle.Margin = new Padding(5, 0, 5, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(41, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title:";
            labelTitle.Visible = false;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(107, 59);
            labelAuthor.Margin = new Padding(5, 0, 5, 0);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(57, 20);
            labelAuthor.TabIndex = 1;
            labelAuthor.Text = "Author:";
            labelAuthor.Visible = false;
            // 
            // labelISBN
            // 
            labelISBN.AutoSize = true;
            labelISBN.Location = new Point(107, 99);
            labelISBN.Margin = new Padding(5, 0, 5, 0);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(44, 20);
            labelISBN.TabIndex = 2;
            labelISBN.Text = "ISBN:";
            labelISBN.Visible = false;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(170, 15);
            textBoxTitle.Margin = new Padding(5, 4, 5, 4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(133, 27);
            textBoxTitle.TabIndex = 3;
            textBoxTitle.Visible = false;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(170, 55);
            textBoxAuthor.Margin = new Padding(5, 4, 5, 4);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(133, 27);
            textBoxAuthor.TabIndex = 4;
            textBoxAuthor.Visible = false;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(170, 95);
            textBoxISBN.Margin = new Padding(5, 4, 5, 4);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(133, 27);
            textBoxISBN.TabIndex = 5;
            textBoxISBN.Visible = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(170, 133);
            buttonAdd.Margin = new Padding(5, 4, 5, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(133, 36);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Visible = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDisplayAll
            // 
            buttonDisplayAll.BackColor = Color.DeepSkyBlue;
            buttonDisplayAll.Location = new Point(359, 137);
            buttonDisplayAll.Margin = new Padding(5, 4, 5, 4);
            buttonDisplayAll.Name = "buttonDisplayAll";
            buttonDisplayAll.Size = new Size(101, 36);
            buttonDisplayAll.TabIndex = 7;
            buttonDisplayAll.Text = "Display All";
            buttonDisplayAll.UseVisualStyleBackColor = false;
            buttonDisplayAll.Click += buttonDisplayAll_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(405, 94);
            buttonSearch.Margin = new Padding(5, 4, 5, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(101, 36);
            buttonSearch.TabIndex = 8;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Visible = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listViewBooks
            // 
            listViewBooks.BackColor = Color.Orange;
            listViewBooks.Columns.AddRange(new ColumnHeader[] { columnHeaderTitle, columnHeaderAuthor, columnHeaderISBN });
            listViewBooks.Location = new Point(170, 198);
            listViewBooks.Margin = new Padding(5, 4, 5, 4);
            listViewBooks.Name = "listViewBooks";
            listViewBooks.Size = new Size(535, 190);
            listViewBooks.TabIndex = 9;
            listViewBooks.UseCompatibleStateImageBehavior = false;
            listViewBooks.View = View.Details;
            listViewBooks.Visible = false;
            // 
            // columnHeaderTitle
            // 
            columnHeaderTitle.Text = "Title";
            columnHeaderTitle.Width = 230;
            // 
            // columnHeaderAuthor
            // 
            columnHeaderAuthor.Text = "Author";
            columnHeaderAuthor.Width = 230;
            // 
            // columnHeaderISBN
            // 
            columnHeaderISBN.Text = "ISBN";
            columnHeaderISBN.Width = 230;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(514, 44);
            textBoxSearch.Margin = new Padding(5, 4, 5, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search Box";
            textBoxSearch.Size = new Size(191, 27);
            textBoxSearch.TabIndex = 10;
            textBoxSearch.Visible = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Location = new Point(182, 177);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(99, 36);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Wanted M54", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(281, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 31);
            label1.TabIndex = 12;
            label1.Text = "Welcome to Library";
            // 
            // addbook
            // 
            addbook.BackColor = Color.Gold;
            addbook.Location = new Point(236, 141);
            addbook.Name = "addbook";
            addbook.Size = new Size(94, 29);
            addbook.TabIndex = 13;
            addbook.Text = "Add book";
            addbook.UseVisualStyleBackColor = false;
            addbook.Click += addbook_Click;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.DeepPink;
            searchbtn.Location = new Point(483, 139);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(119, 29);
            searchbtn.TabIndex = 13;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Wanted M54", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(304, 101);
            label2.Name = "label2";
            label2.Size = new Size(295, 21);
            label2.TabIndex = 12;
            label2.Text = "Press buttons for action";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 47);
            label3.Name = "label3";
            label3.Size = new Size(172, 20);
            label3.TabIndex = 14;
            label3.Text = "Enter Title/Author/ISBN :";
            label3.Visible = false;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Crimson;
            deletebtn.Location = new Point(622, 138);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(94, 29);
            deletebtn.TabIndex = 15;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(824, 401);
            Controls.Add(deletebtn);
            Controls.Add(label3);
            Controls.Add(searchbtn);
            Controls.Add(addbook);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxSearch);
            Controls.Add(listViewBooks);
            Controls.Add(buttonSearch);
            Controls.Add(buttonDisplayAll);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxISBN);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxTitle);
            Controls.Add(labelISBN);
            Controls.Add(labelAuthor);
            Controls.Add(labelTitle);
            ForeColor = SystemColors.MenuText;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Library Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sucesfully deleted");
            labelAuthor.Visible = false;
            labelTitle.Visible = false;
            labelISBN.Visible = false;
            buttonDelete.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            addbook.Visible = true;
            buttonDisplayAll.Visible = true;
            searchbtn.Visible = true;

            textBoxAuthor.Visible = false;
            textBoxISBN.Visible = false;
            textBoxTitle.Visible = false;
            buttonAdd.Visible = false;
            listViewBooks.Visible = true;
            deletebtn.Visible = true;
            buttonAdd.Visible = false;

            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            string isbn = textBoxISBN.Text;

            // Check if any of the fields (title, author, or ISBN) is empty
            if (string.IsNullOrEmpty(title) && string.IsNullOrEmpty(author) && string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("book not found");
                return;
            }

            // Find the book in the library based on title, author, and ISBN
            List<Book> booksToRemove = library.SearchBooks(title, author, isbn);

            // Check if the book was found
            if (booksToRemove.Count == 0)
            {
                MessageBox.Show("Book not found ");
                return;
            }

            // Remove the found book(s) from the library
            foreach (Book bookToRemove in booksToRemove)
            {
                library.removeBook(bookToRemove);
            }
            listViewBooks.Items.Clear();








        }

        // for search button
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            

            // to change the properties of objects
            listViewBooks.Visible = true;
            label3.Visible = false;
            textBoxSearch.Visible = false;
            buttonSearch.Visible = false;
            buttonDelete.Visible = false;

            addbook.Visible = true;
            buttonDisplayAll.Visible = true;
            searchbtn.Visible = true;
            deletebtn.Visible=true;

            listViewBooks.Visible = true;
            label1.Visible = true;
            label2.Visible = true;

            string searchText = textBoxSearch.Text.Trim();
            // shows error if the search box is empty or wrong name
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Book not found");
                return;
            }

            List<Book> searchResults = library.SearchBooks(searchText);

           
            // clears the list box so only result will appear
            listViewBooks.Items.Clear();

            foreach (Book b in searchResults)
            {
                ListViewItem item = new ListViewItem(b.Title);
                item.SubItems.Add(b.Author);
                item.SubItems.Add(b.Isbn);
                listViewBooks.Items.Add(item);
            }
            textBoxSearch.Text = "";
        }






        public void displayBooks()
        {
            listViewBooks.Items.Clear();
            foreach (Book b in library.getBooks())
            {
                ListViewItem item = new ListViewItem(b.Title);
                item.SubItems.Add(b.Author);
                item.SubItems.Add(b.Isbn);
                listViewBooks.Items.Add(item);
            }
        }
        // display button
        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            displayBooks();
            listViewBooks.Visible= true;
        }

    // add button
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            deletebtn.Visible= true;
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            string isbn = textBoxISBN.Text;

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Title cannot be empty");
                return;
            }
            Book newBook = new Book(title, author, isbn);
            library.addBook(newBook);
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            textBoxISBN.Text = "";
            displayBooks();


            // for changning properteis 
            listViewBooks.Visible = true;

            labelAuthor.Visible = false;
            labelTitle.Visible = false;
            labelISBN.Visible = false;

            label1.Visible = true;
            label2.Visible = true  ;
            addbook.Visible = true;
            buttonDisplayAll.Visible = true;
            searchbtn.Visible = true;

            textBoxAuthor.Visible = false;
            textBoxISBN.Visible = false;
            textBoxTitle.Visible = false;
            buttonAdd.Visible = false;

        }


        private System.Windows.Forms.Label labelTitle;

        private System.Windows.Forms.Label labelAuthor;

        private System.Windows.Forms.Label labelISBN;

        private System.Windows.Forms.TextBox textBoxTitle;

        private System.Windows.Forms.TextBox textBoxAuthor;

        private System.Windows.Forms.TextBox textBoxISBN;

        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.Button buttonDisplayAll;

        private System.Windows.Forms.Button buttonSearch;

        private System.Windows.Forms.ListView listViewBooks;

        private System.Windows.Forms.ColumnHeader columnHeaderTitle;

        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;

        private System.Windows.Forms.ColumnHeader columnHeaderISBN;

        private System.Windows.Forms.TextBox textBoxSearch;
        private Button buttonDelete;
        private Label label1;
        private Button addbook;
        private Button searchbtn;
        private Label label2;
        private Label label3;
        private Button deletebtn;
    }
}