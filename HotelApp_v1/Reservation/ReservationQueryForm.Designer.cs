namespace HotelApp_v1
{
    partial class ReservationQueryForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.txtRoomTypeDeletion = new System.Windows.Forms.TextBox();
            this.txtRoomNoDeletion = new System.Windows.Forms.TextBox();
            this.txtLocNameDeletion = new System.Windows.Forms.TextBox();
            this.cmbResID = new System.Windows.Forms.ComboBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSubmitDelete = new System.Windows.Forms.Button();
            this.btnGetPrice = new System.Windows.Forms.Button();
            this.cmbRoomNo = new System.Windows.Forms.ComboBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbLocName = new System.Windows.Forms.ComboBox();
            this.cmbCustName = new System.Windows.Forms.ComboBox();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitCreate = new System.Windows.Forms.Button();
            this.btnSubmitEdit = new System.Windows.Forms.Button();
            this.dtpResEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpResStart = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblResID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblLocID = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblResStart = new System.Windows.Forms.Label();
            this.lblResEnd = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvReservations);
            this.panel2.Controls.Add(this.txtRoomTypeDeletion);
            this.panel2.Controls.Add(this.txtRoomNoDeletion);
            this.panel2.Controls.Add(this.txtLocNameDeletion);
            this.panel2.Controls.Add(this.cmbResID);
            this.panel2.Controls.Add(this.btnCancel2);
            this.panel2.Controls.Add(this.btnSubmitDelete);
            this.panel2.Controls.Add(this.btnGetPrice);
            this.panel2.Controls.Add(this.cmbRoomNo);
            this.panel2.Controls.Add(this.cmbRoomType);
            this.panel2.Controls.Add(this.lblRoomType);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.cmbLocName);
            this.panel2.Controls.Add(this.cmbCustName);
            this.panel2.Controls.Add(this.txtResID);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSubmitCreate);
            this.panel2.Controls.Add(this.btnSubmitEdit);
            this.panel2.Controls.Add(this.dtpResEnd);
            this.panel2.Controls.Add(this.dtpResStart);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.lblResID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblCustID);
            this.panel2.Controls.Add(this.lblLocID);
            this.panel2.Controls.Add(this.lblRoomNo);
            this.panel2.Controls.Add(this.lblResStart);
            this.panel2.Controls.Add(this.lblResEnd);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 545);
            this.panel2.TabIndex = 23;
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(0, 202);
            this.dgvReservations.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(692, 301);
            this.dgvReservations.TabIndex = 39;
            this.dgvReservations.Visible = false;
            // 
            // txtRoomTypeDeletion
            // 
            this.txtRoomTypeDeletion.Enabled = false;
            this.txtRoomTypeDeletion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomTypeDeletion.Location = new System.Drawing.Point(71, 233);
            this.txtRoomTypeDeletion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtRoomTypeDeletion.Name = "txtRoomTypeDeletion";
            this.txtRoomTypeDeletion.ReadOnly = true;
            this.txtRoomTypeDeletion.Size = new System.Drawing.Size(225, 27);
            this.txtRoomTypeDeletion.TabIndex = 40;
            this.txtRoomTypeDeletion.Visible = false;
            // 
            // txtRoomNoDeletion
            // 
            this.txtRoomNoDeletion.Enabled = false;
            this.txtRoomNoDeletion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNoDeletion.Location = new System.Drawing.Point(382, 232);
            this.txtRoomNoDeletion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtRoomNoDeletion.Name = "txtRoomNoDeletion";
            this.txtRoomNoDeletion.ReadOnly = true;
            this.txtRoomNoDeletion.Size = new System.Drawing.Size(228, 27);
            this.txtRoomNoDeletion.TabIndex = 41;
            this.txtRoomNoDeletion.Visible = false;
            // 
            // txtLocNameDeletion
            // 
            this.txtLocNameDeletion.Enabled = false;
            this.txtLocNameDeletion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocNameDeletion.Location = new System.Drawing.Point(382, 138);
            this.txtLocNameDeletion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLocNameDeletion.Name = "txtLocNameDeletion";
            this.txtLocNameDeletion.ReadOnly = true;
            this.txtLocNameDeletion.Size = new System.Drawing.Size(228, 27);
            this.txtLocNameDeletion.TabIndex = 39;
            this.txtLocNameDeletion.Visible = false;
            // 
            // cmbResID
            // 
            this.cmbResID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbResID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbResID.Enabled = false;
            this.cmbResID.FormattingEnabled = true;
            this.cmbResID.Location = new System.Drawing.Point(67, 391);
            this.cmbResID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbResID.Name = "cmbResID";
            this.cmbResID.Size = new System.Drawing.Size(228, 28);
            this.cmbResID.TabIndex = 50;
            this.cmbResID.Visible = false;
            this.cmbResID.SelectedIndexChanged += new System.EventHandler(this.cmbResID_SelectedIndexChanged);
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnCancel2.Enabled = false;
            this.btnCancel2.FlatAppearance.BorderSize = 0;
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.ForeColor = System.Drawing.Color.White;
            this.btnCancel2.Location = new System.Drawing.Point(0, 501);
            this.btnCancel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(139, 44);
            this.btnCancel2.TabIndex = 49;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Visible = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSubmitDelete
            // 
            this.btnSubmitDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSubmitDelete.Enabled = false;
            this.btnSubmitDelete.FlatAppearance.BorderSize = 0;
            this.btnSubmitDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitDelete.ForeColor = System.Drawing.Color.White;
            this.btnSubmitDelete.Location = new System.Drawing.Point(540, 501);
            this.btnSubmitDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSubmitDelete.Name = "btnSubmitDelete";
            this.btnSubmitDelete.Size = new System.Drawing.Size(152, 44);
            this.btnSubmitDelete.TabIndex = 48;
            this.btnSubmitDelete.Text = "Submit Delete";
            this.btnSubmitDelete.UseVisualStyleBackColor = false;
            this.btnSubmitDelete.Visible = false;
            this.btnSubmitDelete.Click += new System.EventHandler(this.btnSubmitDelete_Click);
            // 
            // btnGetPrice
            // 
            this.btnGetPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnGetPrice.Enabled = false;
            this.btnGetPrice.FlatAppearance.BorderSize = 0;
            this.btnGetPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPrice.ForeColor = System.Drawing.Color.White;
            this.btnGetPrice.Location = new System.Drawing.Point(451, 428);
            this.btnGetPrice.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnGetPrice.Name = "btnGetPrice";
            this.btnGetPrice.Size = new System.Drawing.Size(103, 31);
            this.btnGetPrice.TabIndex = 47;
            this.btnGetPrice.Text = "Calculate Price";
            this.btnGetPrice.UseVisualStyleBackColor = false;
            this.btnGetPrice.Click += new System.EventHandler(this.btnGetPrice_Click);
            // 
            // cmbRoomNo
            // 
            this.cmbRoomNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRoomNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomNo.Enabled = false;
            this.cmbRoomNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomNo.FormattingEnabled = true;
            this.cmbRoomNo.Location = new System.Drawing.Point(382, 233);
            this.cmbRoomNo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoomNo.Name = "cmbRoomNo";
            this.cmbRoomNo.Size = new System.Drawing.Size(228, 28);
            this.cmbRoomNo.TabIndex = 41;
            this.cmbRoomNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbRoomNo_MouseClick_1);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRoomType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.Enabled = false;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(70, 232);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(225, 28);
            this.cmbRoomType.TabIndex = 40;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BackColor = System.Drawing.Color.White;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(66, 202);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(84, 20);
            this.lblRoomType.TabIndex = 44;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(403, 391);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 43;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(451, 388);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(103, 27);
            this.txtPrice.TabIndex = 42;
            // 
            // cmbLocName
            // 
            this.cmbLocName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLocName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocName.Enabled = false;
            this.cmbLocName.FormattingEnabled = true;
            this.cmbLocName.Location = new System.Drawing.Point(382, 137);
            this.cmbLocName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocName.Name = "cmbLocName";
            this.cmbLocName.Size = new System.Drawing.Size(228, 28);
            this.cmbLocName.TabIndex = 39;
            // 
            // cmbCustName
            // 
            this.cmbCustName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustName.Enabled = false;
            this.cmbCustName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustName.FormattingEnabled = true;
            this.cmbCustName.Location = new System.Drawing.Point(70, 137);
            this.cmbCustName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCustName.Name = "cmbCustName";
            this.cmbCustName.Size = new System.Drawing.Size(226, 28);
            this.cmbCustName.TabIndex = 38;
            // 
            // txtResID
            // 
            this.txtResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResID.Location = new System.Drawing.Point(67, 391);
            this.txtResID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtResID.Name = "txtResID";
            this.txtResID.ReadOnly = true;
            this.txtResID.Size = new System.Drawing.Size(227, 27);
            this.txtResID.TabIndex = 34;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(553, 501);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 44);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // btnSubmitCreate
            // 
            this.btnSubmitCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSubmitCreate.Enabled = false;
            this.btnSubmitCreate.FlatAppearance.BorderSize = 0;
            this.btnSubmitCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCreate.ForeColor = System.Drawing.Color.White;
            this.btnSubmitCreate.Location = new System.Drawing.Point(276, 501);
            this.btnSubmitCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitCreate.Name = "btnSubmitCreate";
            this.btnSubmitCreate.Size = new System.Drawing.Size(139, 44);
            this.btnSubmitCreate.TabIndex = 31;
            this.btnSubmitCreate.Text = "Submit Create";
            this.btnSubmitCreate.UseVisualStyleBackColor = false;
            this.btnSubmitCreate.Visible = false;
            this.btnSubmitCreate.Click += new System.EventHandler(this.button_submit_create_Click);
            // 
            // btnSubmitEdit
            // 
            this.btnSubmitEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSubmitEdit.Enabled = false;
            this.btnSubmitEdit.FlatAppearance.BorderSize = 0;
            this.btnSubmitEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEdit.ForeColor = System.Drawing.Color.White;
            this.btnSubmitEdit.Location = new System.Drawing.Point(415, 501);
            this.btnSubmitEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitEdit.Name = "btnSubmitEdit";
            this.btnSubmitEdit.Size = new System.Drawing.Size(139, 44);
            this.btnSubmitEdit.TabIndex = 30;
            this.btnSubmitEdit.Text = "Submit Edit";
            this.btnSubmitEdit.UseVisualStyleBackColor = false;
            this.btnSubmitEdit.Visible = false;
            this.btnSubmitEdit.Click += new System.EventHandler(this.button_submit_edit_Click);
            // 
            // dtpResEnd
            // 
            this.dtpResEnd.CustomFormat = "ddd, MMMM dd, yyyy";
            this.dtpResEnd.Enabled = false;
            this.dtpResEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpResEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpResEnd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpResEnd.Location = new System.Drawing.Point(382, 309);
            this.dtpResEnd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpResEnd.Name = "dtpResEnd";
            this.dtpResEnd.Size = new System.Drawing.Size(228, 27);
            this.dtpResEnd.TabIndex = 43;
            // 
            // dtpResStart
            // 
            this.dtpResStart.CustomFormat = "ddd, MMMM dd, yyyy";
            this.dtpResStart.Enabled = false;
            this.dtpResStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpResStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpResStart.Location = new System.Drawing.Point(70, 309);
            this.dtpResStart.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpResStart.Name = "dtpResStart";
            this.dtpResStart.Size = new System.Drawing.Size(226, 27);
            this.dtpResStart.TabIndex = 42;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(139, 501);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 44);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button_search_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(553, 501);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 44);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(415, 501);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(139, 44);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(276, 501);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(139, 44);
            this.btnCreate.TabIndex = 24;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.button_create_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 501);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 44);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button_home_Click);
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.BackColor = System.Drawing.Color.White;
            this.lblResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResID.Location = new System.Drawing.Point(65, 360);
            this.lblResID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(144, 20);
            this.lblResID.TabIndex = 0;
            this.lblResID.Text = "Reservation Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Create or Search for a Reservation";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.BackColor = System.Drawing.Color.White;
            this.lblCustID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(66, 105);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(116, 20);
            this.lblCustID.TabIndex = 1;
            this.lblCustID.Text = "Customer Name";
            // 
            // lblLocID
            // 
            this.lblLocID.AutoSize = true;
            this.lblLocID.BackColor = System.Drawing.Color.White;
            this.lblLocID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocID.Location = new System.Drawing.Point(378, 105);
            this.lblLocID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocID.Name = "lblLocID";
            this.lblLocID.Size = new System.Drawing.Size(66, 20);
            this.lblLocID.TabIndex = 4;
            this.lblLocID.Text = "Location";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.BackColor = System.Drawing.Color.White;
            this.lblRoomNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(378, 202);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(107, 20);
            this.lblRoomNo.TabIndex = 3;
            this.lblRoomNo.Text = "Room Number";
            // 
            // lblResStart
            // 
            this.lblResStart.AutoSize = true;
            this.lblResStart.BackColor = System.Drawing.Color.White;
            this.lblResStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResStart.Location = new System.Drawing.Point(68, 278);
            this.lblResStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResStart.Name = "lblResStart";
            this.lblResStart.Size = new System.Drawing.Size(157, 20);
            this.lblResStart.TabIndex = 5;
            this.lblResStart.Text = "Reservation Start Date";
            // 
            // lblResEnd
            // 
            this.lblResEnd.AutoSize = true;
            this.lblResEnd.BackColor = System.Drawing.Color.White;
            this.lblResEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResEnd.Location = new System.Drawing.Point(378, 278);
            this.lblResEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResEnd.Name = "lblResEnd";
            this.lblResEnd.Size = new System.Drawing.Size(151, 20);
            this.lblResEnd.TabIndex = 6;
            this.lblResEnd.Text = "Reservation End Date";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ESCO-PC\\SQLEXPRESS01;Initial Catalog=HOTEL_TEST;Integrated Security=T" +
    "rue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // ReservationQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReservationQueryForm";
            this.Size = new System.Drawing.Size(692, 545);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblResID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblLocID;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblResStart;
        private System.Windows.Forms.Label lblResEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpResEnd;
        private System.Windows.Forms.DateTimePicker dtpResStart;
        private System.Windows.Forms.Button btnSubmitEdit;
        private System.Windows.Forms.Button btnSubmitCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtResID;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.ComboBox cmbCustName;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.ComboBox cmbLocName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomNo;
        private System.Windows.Forms.Button btnGetPrice;
        private System.Windows.Forms.Button btnSubmitDelete;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.ComboBox cmbResID;
        private System.Windows.Forms.TextBox txtRoomTypeDeletion;
        private System.Windows.Forms.TextBox txtRoomNoDeletion;
        private System.Windows.Forms.TextBox txtLocNameDeletion;
    }
}
